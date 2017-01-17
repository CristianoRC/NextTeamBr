#pragma once

#include "stdafx.h"
#include <map>
#include <vector>

struct STRUCT_JOB_DATA 
{
	std::string cargo;
	int variant;
	std::string target;
	int urgency;
	int distance;
	int ferryTime;
	int ferryPrice;
};

enum Context {
	CONTEXT_UNIT_START,
	CONTEXT_ATTRIBUTE,
	CONTEXT_UNIT_END
};

struct JOB_CURR_DATA 
{
	std::string company_name;
	int job_id;
};

typedef std::map<std::string, std::vector<STRUCT_JOB_DATA>> JOBLISTER;
typedef std::map<std::string, JOB_CURR_DATA> CURR_JOB_NAMES;

typedef std::function<bool(Context context, const std::string& name, const std::string& value, const std::string& sourceValue, unsigned long offset)> ParseCallback;

int GetLineType(std::string str);