#include "stdafx.h"
#include "Main.h"
#include "File.h"

// -- Json Lib
#include "rapidjson\document.h"
#include "rapidjson\error\en.h"

#include <boost\algorithm\string.hpp>


using namespace rapidjson;

const std::string ECONOMY_UNIT = "economy";
const std::string GAME_TIME_ATTRIBUTE = "game_time";
const std::string COMPANY_UNIT = "company";
const std::string JOB_UNIT = "job_offer_data";
const std::string COMPANY_NAME_PREFIX = "company.volatile.";

/**
 * 0: Init Company
 * 1: Current Company
 * 2: End Company
 * 3: JobOffInit
 * 4: Current JobOff
 */
int FileReadState = -1;

enum READ_FILE_STATE
{
	eNONE,
	eCOMPANY,
	eJOBMATCH
};

void CommandLineToArg(char * Command, char*** argv)
{
	if (!Command) { return; }

	bool	Quote			=	false;
	bool	Content			=	false;
	size_t	CommandLen		=	strlen(Command);
	int		NumCommands		=	1;
	size_t	I				=	0;

	for (I=0; I < CommandLen; I++)
	{
		if (Command[I] == '"')
		{
			Quote			=	!Quote;
			Content			=	true;
		}
		else if (Command[I] == ' ')
		{
			if (!Quote&&Content)
			{
				Content		=	false;

				NumCommands++;
			}
		}
		else
		{
			Content			=	true;
		}
	}

	*argv = new char*[NumCommands];

	size_t StrBegin		=	0;
	size_t StrLen		=	0;
	size_t CommandNum	=	0;

	for (I=0; I < CommandLen; I++)
	{
		if (Command[I] == '"')
		{
			Quote = !Quote;
			Content			=	true;
		}
		else if (Command[I] == ' ')
		{
			if ( !Quote && Content)
			{
				Content		=	false;

				StrLen = I - StrBegin;
				if (Command[StrBegin] == '"')
				{
					StrBegin++;
					StrLen--;
				}
				if (Command[StrBegin+StrLen-1] == '"')
				{
					StrLen-=1;
				}
				char* Argument = 0;
				Argument = new char[StrLen+1];
				memcpy(Argument,Command + StrBegin,StrLen);
				memset(Argument+StrLen,0,1);

				(*argv)[CommandNum] = Argument;		

				CommandNum++;
				StrBegin = I+1;
			}
			else if ( !Quote )
			{
				StrBegin++;
			}
		}
		else
		{
			Content			=	true;
		}
	}
	StrLen = I - StrBegin;
	if (Command[StrBegin] == '"')
	{
		StrBegin++;
		StrLen--;
	}
	if (Command[StrBegin+StrLen-1] == '"')
	{
		StrLen-=1;
	}
	char* Argument = 0;
	Argument = new char[StrLen+1];
	memcpy(Argument,Command + StrBegin,StrLen);
	memset(Argument+StrLen,0,1);

	(*argv)[CommandNum] = Argument;
}

int _tmain(int argc, _TCHAR* argv[])
{
	size_t count = sizeof(argv);

	if(count < 3)
		return 0;

	//printf("file: %s to file: %s",argv[1], argv[2]);

	//--------------------------------------------------------------||
	// -- Job Mapping												||
	//--------------------------------------------------------------||
	JOBLISTER JobMapping;
	CURR_JOB_NAMES JobTargetNames;
	std::string currentCompany;
	STRUCT_JOB_DATA blankJob;
	blankJob.cargo = "null";
	blankJob.variant = -1;
	blankJob.target = "";
	blankJob.urgency = -1;
	blankJob.distance = 0;
	blankJob.ferryPrice = 0;
	blankJob.ferryTime = 0;
	std::vector<STRUCT_JOB_DATA> emptyJobList;
	const std::vector<STRUCT_JOB_DATA> * companyJobs = nullptr;
	const STRUCT_JOB_DATA * currentJob = nullptr;

	//--------------------------------------------------------------||
	// -- Load GameSII Text Data									||
	//--------------------------------------------------------------||
	std::string filename = argv[2];
	std::string Savefilename = argv[2];
	std::string GameSII_Data;
	::read_file(filename, GameSII_Data);


	//--------------------------------------------------------------||
	// -- Load JsonFile Text Data									||
	//--------------------------------------------------------------||
	filename.clear();
	filename = argv[1];
	std::string Json_Data;
	::read_file(filename, Json_Data);

	//--------------------------------------------------------------||
	// -- Convert Json to  Map Vector								||
	//--------------------------------------------------------------||
	Document JsonParser;
	JsonParser.ParseInsitu(&Json_Data[0]);

	if (JsonParser.HasParseError()) {
		printf("\r\nError on parser json data!!!\r\n");
		system("pause");
		return false;
	}

	std::string propName;
	std::string propValue;
	std::string jobTarget;

	for(Value::ConstMemberIterator keyIterator = JsonParser.MemberBegin(); keyIterator != JsonParser.MemberEnd(); ++keyIterator)
	{
		for(Value::ConstValueIterator jobIterator = keyIterator->value.Begin(); jobIterator != keyIterator->value.End(); ++jobIterator)
		{
			STRUCT_JOB_DATA job;

			jobTarget.clear();

			for(Value::ConstMemberIterator propIterator = jobIterator->MemberBegin(); propIterator != jobIterator->MemberEnd(); ++propIterator)
			{
				propName.assign(propIterator->name.GetString(), propIterator->name.GetStringLength());

				propValue.assign(propIterator->value.GetString(), propIterator->value.GetStringLength());

				if (propName == "cargo") 
				{
					job.cargo = propValue;
				} 
				else if (propName == "target_company") 
				{
					jobTarget.insert(0, propValue);
				} 
				else if (propName == "target_city") 
				{
					jobTarget.append(".");
					jobTarget.append(propValue);
				} 
				else if (propName == "variant") 
				{
					job.variant = std::stoi(propValue);
				} 
				else if (propName == "urgency") 
				{
					job.urgency = std::stoi(propValue);
				} 
				else if (propName == "distance") 
				{
					job.distance = std::stoi(propValue);
				} 
				else if (propName == "ferry_time") 
				{
					job.ferryTime = std::stoi(propValue);
				} 
				else if (propName == "ferry_price") 
				{
					job.ferryPrice = std::stoi(propValue);
				} 
				else if (propName != "company" && propName != "city" && propName != "dlc_city" && propName != "dlc_cargo") 
				{
					printf("\r\nError identifying json property!!\r\n");
					system("pause");
					return false;
				}
			}

			job.target = jobTarget;
			JobMapping[keyIterator->name.GetString()].push_back(job);
		}
	}

	//--------------------------------------------------------------||
	// -- Replace													||
	//--------------------------------------------------------------||
	long currentLine = 0;
	std::string newSaveData = "";
	newSaveData.reserve(20 * 1024 * 1024);
	bool hasGameTime = false;
	unsigned long lastOffset = 0;
	int lastProgress = -1;
	int progress = 0;

	if (GameSII_Data.empty()) {
		printf("\r\nSave file is empty. Aborting...!!\r\n");
		system("pause");
		return false;
	}

	size_t i_pos;

	std::string some_string = GameSII_Data;
	istringstream iss(some_string);
	std::string line;
	std::string __line = line;
	FileReadState = 0;

	std::string company_name;
	std::string job_name;

	int GameTime = 0;
	while (getline(iss, line))
	{
		if(FileReadState == 0)
		{
			__line = line;
			boost::trim(__line);
			i_pos = __line.find("company : company.volatile.");

			if(i_pos != -1)
			{
				company_name.clear();
				company_name.assign(__line, 27, __line.length() - 26);
				boost::erase_all(company_name, " {");
				//boost::trim(company_name);

				auto find_company = JobMapping.find(company_name.c_str());

				if(find_company != JobMapping.end())
				{
					FileReadState = 1;
					//printf(" %s", company_name.c_str());
				}
				else
				{
					companyJobs = &emptyJobList;
				}
			}
			else
			{
				i_pos = __line.find("job_offer_data : ");

				if(i_pos != -1)
				{

					job_name.clear();
					job_name.assign(__line, 17, __line.length() - 16);
					boost::erase_all(job_name, " {");
					//boost::trim(company_name);

					auto find_job = JobTargetNames.find(job_name.c_str());

					if(find_job != JobTargetNames.end())
					{
						auto find_company = JobMapping.find(find_job->second.company_name.c_str());

						if(find_company != JobMapping.end())
						{
							FileReadState = 2;
							companyJobs = &find_company->second;
							
							if((int)find_job->second.job_id < (int)companyJobs->size()) 
							{
								currentJob = &(*companyJobs)[find_job->second.job_id];
							}
						}
					}
				}
				else if(hasGameTime == false)
				{
					i_pos = __line.find("game_time: ");
					
					if(i_pos != -1)
					{
						std::string _game_time;
						_game_time.clear();
						_game_time.assign(__line, 11, __line.length() - 10);
						GameTime = stoi(_game_time);
						hasGameTime = true;
					}
				}
			}
		}
		else if(FileReadState == 1)
		{
			do
			{
				__line = line;
				boost::trim(__line);

				i_pos = __line.find("}");

				if(i_pos != -1)
				{
					FileReadState = 0;
					newSaveData.append(line.c_str()).append("\r\n");
					break;
				}
				else
				{
					i_pos = __line.find("job_offer[");

					if(i_pos != -1)
					{
						std::string job_id;

						job_name.clear();
						job_name.assign(__line, 14, __line.length() - 13);

						i_pos = __line.find("]");
						job_id.clear();
						job_id.assign(__line, 10, __line.length() - i_pos);
						
						int JobID = std::stoi(job_id);

						auto find_company = JobMapping.find(company_name.c_str());

						if(find_company != JobMapping.end())
						{
							if((int)JobID < (int)find_company->second.size()) 
							{
								JOB_CURR_DATA JobDataNames;
								JobDataNames.company_name = company_name;
								JobDataNames.job_id = JobID;
								JobTargetNames[job_name.c_str()] = JobDataNames;
							}
						}

						//printf("\r\n Job Name: [%d] %s \r\n", JobID, job_name.c_str());
					}

					newSaveData.append(line.c_str()).append("\r\n");
				}
			}
			while(getline(iss, line));

			continue;
		}
		else if(FileReadState == 2)
		{
			do
			{
				__line = line;
				boost::trim(__line);

				i_pos = __line.find("}");

				if(i_pos != -1)
				{
					FileReadState = 0;
					newSaveData.append(line.c_str()).append("\r\n");
					break;
				}
				else
				{
					std::vector<std::string> results;
					boost::split(results, __line, boost::is_any_of(": "));

					if(results[0] == "cargo") 
					{
						newSaveData.append(" cargo: ");
						newSaveData.append(currentJob->cargo);
					} 
					else if(results[0] == "variant") 
					{
						newSaveData.append(" variant: ");
						newSaveData.append(currentJob->variant == -1 ? "nil" : std::to_string(static_cast<long long>(currentJob->variant)));
					} 
					else if(results[0] == "target") 
					{
						newSaveData.append(" target: ");
						newSaveData.append("\"").append(currentJob->target).append("\"");
					} 
					else if(results[0] == "expiration_time") 
					{
						newSaveData.append(" expiration_time: ");
						newSaveData.append(currentJob == &blankJob ? "nil" : std::to_string(static_cast<long long>(GameTime + 30000)));
					} 
					else if(results[0] == "urgency") 
					{
						newSaveData.append(" urgency: ");
						newSaveData.append(currentJob->urgency == -1 ? "nil" : std::to_string(static_cast<long long>(currentJob->urgency)));
					} 
					else if(results[0] == "urgency") 
					{
						newSaveData.append(" urgency: ");
						newSaveData.append(currentJob->urgency == -1 ? "nil" : std::to_string(static_cast<long long>(currentJob->urgency)));
					} 
					else if(results[0] == "shortest_distance_km") 
					{
						newSaveData.append(" shortest_distance_km: ");
						newSaveData.append(std::to_string(static_cast<long long>(currentJob->distance)));
					} 
					else if(results[0] == "ferry_time") 
					{
						newSaveData.append(" ferry_time: ");
						newSaveData.append(std::to_string(static_cast<long long>(currentJob->ferryTime)));
					} 
					else if(results[0] == "ferry_price") 
					{
						newSaveData.append(" ferry_price: ");
						newSaveData.append(std::to_string(static_cast<long long>(currentJob->ferryPrice)));
					}
					else
					{
						newSaveData.append(line.c_str());
					}

					newSaveData.append("\r\n");
				}
			}
			while(getline(iss, line));

			continue;
		}

		newSaveData.append(line.c_str()).append("\r\n");
	}

	write_file(newSaveData, Savefilename);

	return 0;
}