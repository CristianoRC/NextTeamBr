using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.ComponentModel;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ETS2_route_maker
{
    public class Form1 : Form
    {
        private string version = "Version: 1.7";

        private string miejsce_savea;

        private string[] plik = null;

        private bool file_decoded = false;

        private string[] companies = new string[]
        {
            ""
        };

        private string[] cities = new string[]
        {
            ""
        };

        private string[] cargoes = new string[]
        {
            ""
        };

        private int game_time;

        private string[] available_cities = new string[]
        {
            ""
        };

        private int number_of_jobs_added = 0;

        private string[] jobs_added;

        private string[] write_company;

        private string[] economy_event;

        private string[] excluded_company = new string[]
        {
            ""
        };

        private string[] config_file = new string[3];

        private System.DateTime modification_timestamp;

        private int job_pickup_time = 50;

        private string last_visited_city = "";

        private string[] economy_event_queue;

        private string[,] economy_events_table;

        private string propose_randoms;

        private string language;

        private string no_company_exclude = "0";

        private System.Random rand = new System.Random();

        private string[,] stored_cities = new string[1, 3];

        private SqlCeConnection DBconnection = new SqlCeConnection("Data Source = Database1.sdf");

        private int sql_batch_load_records_count;

        private string[] added_cities_to_compare = new string[1];

        private string DB_mode = "Normal";

        private string initial_sql_batch_load_statment = "insert into Cities (City, destination, distance) ";

        private string game = "ETS";

        private int total_km = 0;

        private int loop_every = 0;

        private string loop_start_city = "";

        private string loop_start_company = "";

        private string cargoFileonly = "";

        private string companyMode = "";

        private string companyMode_company = "";

        private string empty_mode_cargo = "";

        private int empty_mode = 1;

        private IContainer components = null;

        private FolderBrowserDialog folderBrowserDialog1;

        private TextBox textField_enter_directory;

        private Button button_Select_directory;

        private Label label_katalog_savea;

        private Button button_Load_save;

        private Label message_board;

        private ComboBox dropbox_source_city;

        private ComboBox dropbox_destination_city;

        private Label label_source;

        private Label label_dest;

        private ComboBox dropbox_destination_company;

        private ComboBox dropbox_source_company;

        private Label label_destination_company;

        private Label label_source_company;

        private Label label_cargo;

        private ComboBox dropbox_list_cargo;

        private Button Add_cargo_button;

        private Button button_save_file;

        private Label label_added_cargo_list;

        private Button button_clear_jobs;

        private Label label1;

        private Label label_version;

        private Label Label_Profile;

        private Label Label_profile_loaded;

        private Label label_total;

        public Form1()
        {
            this.InitializeComponent();
            this.change_language();
            this.label_version.Text = this.version;
            try
            {
                this.config_file = System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + "\\config.cfg");
                this.textField_enter_directory.Text = this.config_file[0];
                this.job_pickup_time = int.Parse(this.config_file[1].Split(new char[]
                {
                    ':'
                })[1]);
                this.propose_randoms = this.config_file[2].Split(new char[]
                {
                    ':'
                })[1];
                this.language = this.config_file[3].Split(new char[]
                {
                    ':'
                })[1];
                this.DB_mode = this.config_file[4].Split(new char[]
                {
                    ':'
                })[1];
                this.no_company_exclude = this.config_file[5].Split(new char[]
                {
                    ':'
                })[1];
                this.loop_every = int.Parse(this.config_file[6].Split(new char[]
                {
                    ':'
                })[1]);
                this.cargoFileonly = this.config_file[7].Split(new char[]
                {
                    ':'
                })[1];
                this.companyMode = this.config_file[8].Split(new char[]
                {
                    ':'
                })[1];
                this.companyMode_company = this.config_file[8].Split(new char[]
                {
                    ':'
                })[2];
                this.empty_mode_cargo = this.config_file[9].Split(new char[]
                {
                    ':'
                })[1];
                if (this.language != "0")
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(this.language);
                    this.change_language();
                }
            }
            catch
            {
                System.Array.Resize<string>(ref this.config_file, 10);
                this.log_writer("config.cfg wasn't found");
                this.config_file[0] = "Libraries\\Documents\\Euro Truck Simulator 2\\profiles\\xxx\\save\\autosave";
                this.config_file[1] = "job pickup time:72";
                this.config_file[2] = "propose randoms:1";
                this.config_file[3] = "Language:0";
                this.config_file[4] = "DB Mode:normal";
                this.config_file[5] = "no_exclude:0";
                this.config_file[6] = "loop:0";
                this.config_file[7] = "cargo File only:0";
                this.config_file[8] = "Company Mode:0:trameri";
                this.config_file[9] = "Empty Mode:0";
                this.write_config();
            }
        }

        private void change_language()
        {
            this.label_dest.Text = Resource.Label_destination;
            this.button_Load_save.Text = Resource.button_Load_save;
            this.label_source.Text = Resource.label_source;
            this.label_destination_company.Text = Resource.label_source_company;
            this.label_source_company.Text = Resource.label_source_company;
            this.Add_cargo_button.Text = Resource.Add_cargo_button;
            this.label_cargo.Text = Resource.label_cargo;
            this.button_save_file.Text = Resource.button_save_file;
            this.label_added_cargo_list.Text = Resource.label_added_cargo_list;
            this.button_clear_jobs.Text = Resource.button_clear_jobs;
            this.Label_profile_loaded.Text = Resource.Label_profile_loaded;
            this.label_katalog_savea.Text = Resource.label_katalog_savea;
        }

        private void write_config()
        {
            try
            {
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\config.cfg", this.config_file[0] + "\n");
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + "\\config.cfg", true))
                {
                    for (int i = 1; i < this.config_file.Length; i++)
                    {
                        streamWriter.WriteLine(this.config_file[i]);
                    }
                }
            }
            catch
            {
                this.log_writer("Could not write to " + System.IO.Directory.GetCurrentDirectory());
                this.message_board.ForeColor = Color.Red;
                this.message_board.Text = Resource.Error_Could_not_write_to + " " + System.IO.Directory.GetCurrentDirectory();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, System.EventArgs e)
        {
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
        }

        private void Select_directory_Click(object sender, System.EventArgs e)
        {
            this.folderBrowserDialog1.SelectedPath = this.textField_enter_directory.Text;
            DialogResult dialogResult = this.folderBrowserDialog1.ShowDialog();
            string selectedPath = this.folderBrowserDialog1.SelectedPath;
            this.textField_enter_directory.Text = selectedPath;
        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, System.EventArgs e)
        {
        }

        public string ConvertHexToString(string HexValue)
        {
            string text = "";
            while (HexValue.Length > 0)
            {
                text += System.Convert.ToChar(System.Convert.ToUInt32(HexValue.Substring(0, 2), 16)).ToString();
                HexValue = HexValue.Substring(2, HexValue.Length - 2);
            }
            return text;
        }

        private void Load_save_Click(object sender, System.EventArgs e)
        {
            this.config_file[0] = this.textField_enter_directory.Text;
            this.write_config();
            this.clear_data();
            this.message_board.ForeColor = Color.Black;
            this.message_board.Text = Resource.Message_Decoding_save_file;
            this.message_board.Refresh();
            string text = this.textField_enter_directory.Text;
            this.miejsce_savea = text;
            if (!System.IO.File.Exists(this.miejsce_savea + "\\game.sii"))
            {
                this.log_writer("File does not exist in " + this.miejsce_savea);
                this.message_board_display_message("e", Resource.Error_Could_not_find_file);
            }
            else
            {
                if (text.Contains("American Truck"))
                {
                    this.game = "ATS";
                }
                else
                {
                    this.game = "ETS";
                }
                string[] array = this.miejsce_savea.Split(new char[]
                {
                    '\\'
                });
                string text2 = array[array.Length - 3];
                text2 = this.ConvertHexToString(text2);
                this.Label_Profile.Text = text2;
                try
                {
                    this.plik = this.decode_file(this.miejsce_savea);
                }
                catch
                {
                    this.log_writer("Could not read: " + this.miejsce_savea + "\\game.sii");
                    return;
                }
                if (this.plik == null || this.plik[0] != "SiiNunit")
                {
                    this.log_writer("Wrongly decoded file or wrong file format");
                    this.message_board_display_message("e", Resource.Error_file_not_decoded);
                }
                else if (this.plik != null)
                {
                    this.modification_timestamp = System.IO.File.GetLastWriteTime(this.miejsce_savea + "\\game.sii");
                    this.prepare_data();
                }
            }
        }

        private void read_file_to_memory(string file)
        {
            this.message_board.ForeColor = Color.Black;
            this.message_board.Text = Resource.Message_Loading_save_file;
            this.message_board.Refresh();
            this.plik = new string[1];
            try
            {
                this.plik = System.IO.File.ReadAllLines(file);
            }
            catch
            {
                this.log_writer("Could not find file in: " + this.miejsce_savea);
                this.message_board_display_message("e", Resource.Error_Could_not_find_file);
                this.file_decoded = false;
                return;
            }
            if (this.plik[0] == "SiiNunit")
            {
                this.file_decoded = true;
                this.message_board_display_message("m", Resource.Message_Save_file_loaded);
            }
            else
            {
                this.log_writer("File wasn't decoded properly");
                this.file_decoded = false;
                this.message_board_display_message("e", Resource.Error_file_not_decoded);
            }
        }

        private string[] decode_file(string file_path)
        {
            System.IO.File.Copy(file_path + "/game.sii", file_path + "/game.sii_backup", true);
            byte[] keyBytes = new byte[]
            {
                42,
                95,
                203,
                23,
                145,
                210,
                47,
                182,
                2,
                69,
                179,
                216,
                54,
                158,
                208,
                178,
                194,
                115,
                113,
                86,
                63,
                191,
                31,
                60,
                158,
                223,
                107,
                17,
                130,
                90,
                93,
                10
            };
            this.message_board_display_message("m", Resource.Message_Loading_save_file);
            byte[] array = this.load_file_to_memory(file_path + "/game.sii");
            string[] result;
            if (array == null)
            {
                result = null;
            }
            else
            {
                string @string = System.Text.Encoding.UTF8.GetString(array, 0, 8);
                if (@string == "SiiNunit")
                {
                    string[] array2 = System.IO.File.ReadAllLines(file_path + "/game.sii");
                    result = array2;
                }
                else
                {
                    this.message_board_display_message("m", Resource.Message_Decoding_save_file);
                    byte[] array3 = new byte[16];
                    byte[] array4 = new byte[array.Length - 56];
                    System.Array.Copy(array, 56, array4, 0, array4.Length);
                    System.Array.Copy(array, 36, array3, 0, array3.Length);
                    try
                    {
                        byte[] buffer = Form1.AESDecrypt(array4, keyBytes, array3);
                        string input = "";
                        using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(buffer))
                        {
                            using (InflaterInputStream inflaterInputStream = new InflaterInputStream(memoryStream))
                            {
                                using (System.IO.StreamReader streamReader = new System.IO.StreamReader(inflaterInputStream))
                                {
                                    input = streamReader.ReadToEnd();
                                }
                            }
                        }
                        string[] array5 = Regex.Split(input, "\r\n|\r|\n");
                        result = array5;
                    }
                    catch
                    {
                        this.log_writer("could not decode file: + " + file_path + "/game.sii");
                        this.message_board_display_message("e", Resource.Error_Could_not_decode);
                        result = null;
                    }
                }
            }
            return result;
        }

        private byte[] load_file_to_memory(string path)
        {
            byte[] array;
            byte[] result;
            try
            {
                array = System.IO.File.ReadAllBytes(path);
            }
            catch
            {
                this.log_writer("Could not find file in: " + this.miejsce_savea);
                this.message_board_display_message("e", Resource.Error_Could_not_find_file);
                this.file_decoded = false;
                result = null;
                return result;
            }
            result = array;
            return result;
        }

        private static byte[] AESDecrypt(byte[] encryptedData, byte[] keyBytes, byte[] iv)
        {
            return new System.Security.Cryptography.RijndaelManaged
            {
                Mode = System.Security.Cryptography.CipherMode.CBC,
                Padding = System.Security.Cryptography.PaddingMode.None,
                IV = iv,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = iv
            }.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        }

        private void prepare_data()
        {
            this.log_writer("prepare start");
            this.message_board.ForeColor = Color.Black;
            this.message_board.Text = Resource.Message_Preparing_data;
            this.companies = new string[1];
            this.cities = new string[1];
            int num = 0;
            int num2 = 0;
            this.dropbox_source_city.Items.Clear();
            this.dropbox_destination_city.Items.Clear();
            this.dropbox_list_cargo.Items.Clear();
            int num3 = 0;
            int num4 = 0;
            string text = this.initial_sql_batch_load_statment;
            this.sql_batch_load_records_count = 0;
            this.message_board_display_message("m", "Loading DataBase");
            this.stored_cities = this.get_all_distances_from_DB();
            if (this.companyMode == "1")
            {
                this.log_writer("Company mode selected with company name: " + this.companyMode_company);
            }
            int i;
            if (this.DB_mode == "import")
            {
                this.message_board_display_message("m", "Importing data");
                this.config_file[4] = "DB Mode:normal";
                this.write_config();
                try
                {
                    string[] array = System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + "\\Database1.txt");
                    for (i = 0; i < array.Length; i++)
                    {
                        string[] array2 = array[i].Split(new char[]
                        {
                            ';'
                        });
                        text = this.add_distance_to_DB_batchLoad(array2[0], array2[1], array2[2], text);
                        if (this.sql_batch_load_records_count > 900)
                        {
                            text = this.write_to_db(text);
                        }
                    }
                    this.stored_cities = this.get_all_distances_from_DB();
                }
                catch
                {
                    text = this.initial_sql_batch_load_statment;
                    this.sql_batch_load_records_count = 0;
                    this.log_writer("import failed, wrong file format or missing file");
                    this.message_board_display_message("e", Resource.error_import_aborted);
                }
            }
            this.message_board_display_message("m", Resource.Message_Preparing_data);
            i = 0;
            while (i < this.plik.Length)
            {
                if (!this.plik[i].StartsWith(" companies[") || !(this.plik[i] != "null"))
                {
                    goto IL_2B5;
                }
                string[] array3 = this.plik[i].Split(new char[]
                {
                    '.'
                });
                if (array3[3] != null)
                {
                    System.Array.Resize<string>(ref this.companies, this.companies.Length + 1);
                    System.Array.Resize<string>(ref this.cities, this.cities.Length + 1);
                    this.companies[num] = array3[2];
                    this.cities[num] = array3[3];
                    num++;
                    goto IL_2B5;
                }
            IL_8BD:
                i++;
                continue;
            IL_2B5:
                if (this.plik[i].StartsWith(" last_visited_city: "))
                {
                    string[] array4 = this.plik[i].Split(new char[]
                    {
                        ' '
                    });
                    this.last_visited_city = array4[2];
                }
                if (this.plik[i].StartsWith(" cargo: cargo") && this.cargoFileonly != "1")
                {
                    array3 = this.plik[i].Split(new char[]
                    {
                        '.'
                    });
                    System.Array.Resize<string>(ref this.cargoes, this.cargoes.Length + 1);
                    for (int j = 1; j < array3.Length; j++)
                    {
                        if (j > 1)
                        {
                            this.cargoes[num2] = this.cargoes[num2] + '.';
                        }
                        this.cargoes[num2] = this.cargoes[num2] + array3[j];
                    }
                    num2++;
                }
                if (this.plik[i].StartsWith(" game_time: "))
                {
                    array3 = this.plik[i].Split(new char[]
                    {
                        ' '
                    });
                    this.game_time = int.Parse(array3[2]);
                }
                if (this.no_company_exclude != "1")
                {
                    if (this.plik[i].StartsWith("company : company.volatile.") && this.plik[i + 4] == " job_offer: 0")
                    {
                        string[] array5 = this.plik[i].Split(new char[]
                        {
                            '.'
                        });
                        string[] array6 = array5[3].Split(new char[]
                        {
                            ' '
                        });
                        System.Array.Resize<string>(ref this.excluded_company, this.excluded_company.Length + 1);
                        this.excluded_company[this.excluded_company.Length - 1] = array5[2] + "." + array6[0];
                    }
                    else if (this.plik[i].StartsWith("company : company.volatile.") && this.companyMode == "1")
                    {
                        if (!this.plik[i].StartsWith("company : company.volatile." + this.companyMode_company))
                        {
                            string[] array5 = this.plik[i].Split(new char[]
                            {
                                '.'
                            });
                            string[] array6 = array5[3].Split(new char[]
                            {
                                ' '
                            });
                            System.Array.Resize<string>(ref this.excluded_company, this.excluded_company.Length + 1);
                            this.excluded_company[this.excluded_company.Length - 1] = array5[2] + "." + array6[0];
                        }
                    }
                }
                if (this.plik[i].StartsWith("company : company.volatile."))
                {
                    string[] array5 = this.plik[i].Split(new char[]
                    {
                        '.'
                    });
                    string start_city = array5[3].Split(new char[]
                    {
                        ' '
                    })[0];
                    int num5 = int.Parse(this.plik[i + 4].Split(new char[]
                    {
                        ' '
                    })[2]);
                    if (num5 != 0)
                    {
                        for (int k = 0; k < num5; k++)
                        {
                            string[] array7 = this.plik[i + (9 + num5) + k * 15 + 3].Split(new char[]
                            {
                                '"'
                            });
                            if (array7.Length == 3 && array7[1] != "")
                            {
                                string dest_city = array7[1].Split(new char[]
                                {
                                    '.'
                                })[1];
                                string distance = this.plik[i + (9 + num5) + k * 15 + 6].Split(new char[]
                                {
                                    ' '
                                })[2];
                                text = this.add_distance_to_DB_batchLoad(start_city, dest_city, distance, text);
                            }
                        }
                    }
                }
                if (this.sql_batch_load_records_count > 900)
                {
                    text = this.write_to_db(text);
                }
                if (this.plik[i].StartsWith("economy_event_queue :"))
                {
                    int num6 = int.Parse(this.plik[i + 1].Split(new char[]
                    {
                        ' '
                    })[2]);
                    System.Array.Resize<string>(ref this.economy_event_queue, num6);
                    this.economy_events_table = new string[num6, 5];
                }
                if (this.plik[i].StartsWith(" data[") && this.plik[i].Contains("nameless"))
                {
                    string text2 = this.plik[i].Split(new char[]
                    {
                        ' '
                    })[2];
                    this.economy_events_table[num3, 0] = text2;
                    num3++;
                }
                if (this.plik[i].StartsWith("economy_event : "))
                {
                    for (int j = 1; j < 5; j++)
                    {
                        this.economy_events_table[num4, j] = this.plik[i + j - 1];
                        if (j == 2)
                        {
                            string text3 = this.economy_events_table[num4, j].Split(new char[]
                            {
                                ' '
                            })[2];
                            this.economy_events_table[num4, j] = text3;
                        }
                    }
                    num4++;
                }
                goto IL_8BD;
            }
            if (this.sql_batch_load_records_count > 0)
            {
                text = this.write_to_db(text);
                this.stored_cities = null;
                this.stored_cities = this.get_all_distances_from_DB();
            }
            if (this.DB_mode == "export")
            {
                this.config_file[4] = "DB Mode:normal";
                this.DB_mode = "normal";
                this.write_config();
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\Database1.txt", string.Concat(new string[]
                {
                    this.stored_cities[0, 0],
                    ";",
                    this.stored_cities[0, 1],
                    ";",
                    this.stored_cities[0, 2],
                    "\n"
                }));
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + "\\Database1.txt", true))
                {
                    for (i = 1; i < this.stored_cities.Length / 3; i++)
                    {
                        streamWriter.WriteLine(string.Concat(new string[]
                        {
                            this.stored_cities[i, 0],
                            ";",
                            this.stored_cities[i, 1],
                            ";",
                            this.stored_cities[i, 2]
                        }));
                    }
                }
            }
            this.load_additional_cargo();
            this.cargoes = this.cargoes.Distinct<string>().ToArray<string>();
            System.Array.Sort<string>(this.cargoes);
            for (i = 1; i < this.cargoes.Length; i++)
            {
                this.dropbox_list_cargo.Items.Add(this.cargoes[i]);
            }
            int num7 = 0;
            for (i = 1; i < this.cities.Length - 1; i++)
            {
                bool flag = false;
                for (int j = 1; j < this.excluded_company.Length; j++)
                {
                    if (this.companies[i] + "." + this.cities[i] == this.excluded_company[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    num7++;
                    System.Array.Resize<string>(ref this.available_cities, num7);
                    this.available_cities[num7 - 1] = this.cities[i];
                }
            }
            this.available_cities = this.available_cities.Distinct<string>().ToArray<string>();
            for (i = 0; i < this.available_cities.Length; i++)
            {
                this.dropbox_source_city.Items.Add(this.available_cities[i]);
                this.dropbox_destination_city.Items.Add(this.available_cities[i]);
            }
            this.dropbox_source_city.SelectedItem = this.last_visited_city;
            this.trigger_visibility_of_objects(true);
            this.message_board.ForeColor = Color.Black;
            this.message_board.Text = Resource.Message_Done;
            this.log_writer("prepare stop");
        }

        private void message_board_display_message(string status, string message)
        {
            if (status == "e")
            {
                this.message_board.ForeColor = Color.Red;
                this.message_board.Text = message;
            }
            if (status == "m")
            {
                this.message_board.ForeColor = Color.Black;
                this.message_board.Text = message;
            }
            this.message_board.Refresh();
        }

        private string write_to_db(string sql_batch_load_statment)
        {
            sql_batch_load_statment += ";";
            this.update_database(sql_batch_load_statment);
            this.log_writer("Added " + this.sql_batch_load_records_count + " routes to DB");
            this.sql_batch_load_records_count = 0;
            sql_batch_load_statment = this.initial_sql_batch_load_statment;
            return sql_batch_load_statment;
        }

        private void update_database(string SQL_string)
        {
            this.DBconnection.Open();
            SqlCeCommand sqlCeCommand = this.DBconnection.CreateCommand();
            sqlCeCommand.CommandText = SQL_string;
            sqlCeCommand.ExecuteNonQuery();
            this.DBconnection.Close();
        }

        private string get_random_city_within_distance(string start_city, int distance)
        {
            string text = "";
            string result;
            try
            {
                this.DBconnection.Open();
                string commandText = string.Concat(new object[]
                {
                    "select top(1) * from Cities where City = '",
                    start_city,
                    "' and destination != '",
                    start_city,
                    "' and distance < ",
                    distance,
                    " order by NEWID();"
                });
                SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, this.DBconnection);
                SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
                int num = 0;
                while (sqlCeDataReader.Read())
                {
                    if (num == 1)
                    {
                        break;
                    }
                    text = sqlCeDataReader["destination"].ToString();
                    string text2 = sqlCeDataReader["distance"].ToString();
                    num++;
                }
                this.DBconnection.Close();
            }
            catch
            {
                this.log_writer("missing Database1.sdf file");
                result = "0";
                return result;
            }
            result = text;
            return result;
        }

        private string[,] get_all_distances_from_DB()
        {
            string[] array = new string[0];
            string[] array2 = new string[0];
            string[] array3 = new string[0];
            try
            {
                this.DBconnection.Open();
                string commandText = "select City, destination, distance from Cities;";
                SqlCeCommand sqlCeCommand = new SqlCeCommand(commandText, this.DBconnection);
                SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
                int num = 0;
                while (sqlCeDataReader.Read())
                {
                    System.Array.Resize<string>(ref array, array.Length + 1);
                    System.Array.Resize<string>(ref array2, array2.Length + 1);
                    System.Array.Resize<string>(ref array3, array3.Length + 1);
                    array[num] = sqlCeDataReader["City"].ToString();
                    array2[num] = sqlCeDataReader["destination"].ToString();
                    array3[num] = sqlCeDataReader["distance"].ToString();
                    num++;
                }
                this.DBconnection.Close();
            }
            catch
            {
                this.log_writer("missing Database1.sdf file");
            }
            string[,] array4 = new string[array.Length, 3];
            for (int i = 0; i < array.Length; i++)
            {
                array4[i, 0] = array[i];
                array4[i, 1] = array2[i];
                array4[i, 2] = array3[i];
            }
            this.log_writer("Having total of " + array4.Length / 3 + " routes in DataBase");
            return array4;
        }

        private string add_distance_to_DB_batchLoad(string start_city, string dest_city, string distance, string SQL_insert_statement)
        {
            string result;
            if (distance == "3000")
            {
                result = SQL_insert_statement;
            }
            else
            {
                for (int i = 0; i < this.stored_cities.Length / 3; i++)
                {
                    if (this.stored_cities[i, 0] == start_city && this.stored_cities[i, 1] == dest_city)
                    {
                        result = SQL_insert_statement;
                        return result;
                    }
                    if (this.stored_cities[i, 1] == start_city && this.stored_cities[i, 0] == dest_city)
                    {
                        result = SQL_insert_statement;
                        return result;
                    }
                }
                for (int j = 0; j < this.added_cities_to_compare.Length; j++)
                {
                    if (start_city + ":" + dest_city == this.added_cities_to_compare[j])
                    {
                        result = SQL_insert_statement;
                        return result;
                    }
                }
                if (this.sql_batch_load_records_count > 0)
                {
                    SQL_insert_statement += "union ";
                }
                SQL_insert_statement = string.Concat(new string[]
                {
                    SQL_insert_statement,
                    "select '",
                    start_city,
                    "', '",
                    dest_city,
                    "', '",
                    distance,
                    "' "
                });
                this.sql_batch_load_records_count++;
                System.Array.Resize<string>(ref this.added_cities_to_compare, this.sql_batch_load_records_count);
                this.added_cities_to_compare[this.sql_batch_load_records_count - 1] = start_city + ":" + dest_city;
                result = SQL_insert_statement;
            }
            return result;
        }

        private string get_distance(string start, string finish)
        {
            string result;
            if (start == finish)
            {
                result = "3";
            }
            else
            {
                for (int i = 0; i < this.stored_cities.Length / 3; i++)
                {
                    if (this.stored_cities[i, 0] == start && this.stored_cities[i, 1] == finish)
                    {
                        result = this.stored_cities[i, 2];
                        return result;
                    }
                    if (this.stored_cities[i, 1] == start && this.stored_cities[i, 0] == finish)
                    {
                        result = this.stored_cities[i, 2];
                        return result;
                    }
                }
                result = "3000";
            }
            return result;
        }

        private void load_additional_cargo()
        {
            try
            {
                string[] array = System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + "/cargo.fil");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].StartsWith("cargo."))
                    {
                        System.Array.Resize<string>(ref this.cargoes, this.cargoes.Length + 1);
                        for (int j = 1; j < array[i].Split(new char[]
                        {
                            '.'
                        }).Length; j++)
                        {
                            if (j > 1)
                            {
                                this.cargoes[this.cargoes.Length - 1] = this.cargoes[this.cargoes.Length - 1] + ".";
                            }
                            this.cargoes[this.cargoes.Length - 1] = this.cargoes[this.cargoes.Length - 1] + array[i].Split(new char[]
                            {
                                '.'
                            })[j];
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void trigger_visibility_of_objects(bool visible)
        {
            this.label_dest.Visible = visible;
            this.label_source.Visible = visible;
            this.label_destination_company.Visible = visible;
            this.label_source_company.Visible = visible;
            this.dropbox_source_city.Visible = visible;
            this.dropbox_destination_city.Visible = visible;
            this.dropbox_destination_company.Visible = visible;
            this.dropbox_source_company.Visible = visible;
            this.Add_cargo_button.Visible = visible;
            this.label_cargo.Visible = visible;
            this.dropbox_list_cargo.Visible = visible;
            this.button_save_file.Visible = visible;
            this.label_added_cargo_list.Visible = visible;
            this.button_clear_jobs.Visible = visible;
        }

        private void log_writer(string error)
        {
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + "\\error.log", true))
            {
                streamWriter.WriteLine(System.DateTime.Now + ": " + error);
            }
        }

        private void source_city_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string text = this.dropbox_source_city.SelectedItem.ToString();
            this.dropbox_source_company.Items.Clear();
            this.dropbox_source_company.Text = "";
            for (int i = 0; i < this.cities.Length; i++)
            {
                bool flag = false;
                if (this.cities[i] == text)
                {
                    for (int j = 0; j < this.excluded_company.Length; j++)
                    {
                        string text2 = this.companies[i] + "." + text;
                        string text3 = this.excluded_company[j];
                        if (this.companies[i] + "." + text == this.excluded_company[j])
                        {
                            flag = true;
                            break;
                        }
                        flag = false;
                    }
                    if (!flag)
                    {
                        this.dropbox_source_company.Items.Add(this.companies[i]);
                    }
                }
            }
        }

        private void source_company_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.propose_randoms == "1")
            {
                this.dropbox_destination_city.SelectedIndex = this.rand.Next(this.dropbox_destination_city.Items.Count);
            }
        }

        private void destination_city_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string text = this.dropbox_destination_city.SelectedItem.ToString();
            this.dropbox_destination_company.Items.Clear();
            this.dropbox_destination_company.Text = "";
            for (int i = 0; i < this.cities.Length; i++)
            {
                bool flag = false;
                if (this.cities[i] == text)
                {
                    for (int j = 0; j < this.excluded_company.Length; j++)
                    {
                        string text2 = this.companies[i] + "." + text;
                        string text3 = this.excluded_company[j];
                        if (this.companies[i] + "." + text == this.excluded_company[j])
                        {
                            flag = true;
                            break;
                        }
                        flag = false;
                    }
                    if (!flag)
                    {
                        this.dropbox_destination_company.Items.Add(this.companies[i]);
                    }
                }
            }
            if (this.propose_randoms == "1")
            {
                this.dropbox_destination_company.SelectedIndex = this.rand.Next(this.dropbox_destination_company.Items.Count);
            }
        }

        private void clear_data()
        {
            this.number_of_jobs_added = 0;
            System.Array.Resize<string>(ref this.jobs_added, 0);
            System.Array.Resize<string>(ref this.write_company, 0);
            System.Array.Resize<string>(ref this.economy_event, 0);
            this.button_save_file.Enabled = false;
            this.label_added_cargo_list.Text = Resource.label_added_cargo_list;
            this.button_clear_jobs.Enabled = false;
            this.total_km = 0;
        }

        private void Add_cargo_button_Click(object sender, System.EventArgs e)
        {
            if (this.dropbox_source_city.SelectedIndex < 0 || this.dropbox_source_company.SelectedIndex < 0 || this.dropbox_destination_city.SelectedIndex < 0 || this.dropbox_destination_company.SelectedIndex < 0 || this.dropbox_list_cargo.SelectedIndex < 0)
            {
                this.log_writer("Missing selection of Source, Destination or cargo");
                this.message_board_display_message("e", Resource.Error_Fill_all_fields);
            }
            else
            {
                this.message_board.ForeColor = Color.Black;
                this.message_board.Text = "";
                string text = this.dropbox_source_city.Text.ToString();
                string text2 = this.dropbox_destination_city.Text.ToString();
                string text3 = this.dropbox_source_company.Text.ToString();
                string text4 = this.dropbox_destination_company.Text.ToString();
                string text5 = this.dropbox_list_cargo.Text.ToString();
                string text6 = this.get_distance(text, text2);
                if (this.number_of_jobs_added == 0)
                {
                    this.loop_start_city = text;
                    this.loop_start_company = text3;
                }
                if (this.empty_mode_cargo != "0")
                {
                    this.loop_every *= 2;
                }
                this.number_of_jobs_added++;
                System.Array.Resize<string>(ref this.jobs_added, this.number_of_jobs_added);
                System.Array.Resize<string>(ref this.write_company, this.number_of_jobs_added);
                System.Array.Resize<string>(ref this.economy_event, this.number_of_jobs_added);
                string text7 = "";
                if (this.game == "ATS")
                {
                    text7 = "kenworth_w900_b\n";
                }
                else if (this.game == "ETS")
                {
                    text7 = "man_4x2_a\n";
                }
                this.write_company[this.number_of_jobs_added - 1] = string.Concat(new string[]
                {
                    "company : company.volatile.",
                    text3,
                    ".",
                    text,
                    " {"
                });
                this.economy_event[this.number_of_jobs_added - 1] = " unit_link: company.volatile." + text3 + "." + text;
                int num = this.game_time + this.number_of_jobs_added * (this.job_pickup_time * 60);
                this.jobs_added[this.number_of_jobs_added - 1] = string.Concat(new string[]
                {
                    " cargo: cargo.",
                    text5,
                    "\n company_truck: ",
                    text7,
                    " variant: 0\n target: \"",
                    text4,
                    ".",
                    text2,
                    "\"\n expiration_time: ",
                    num.ToString(),
                    "\n urgency: 0\n shortest_distance_km: ",
                    text6,
                    "\n ferry_time: 0\n ferry_price: 0\n trailer_pos: (0, 0, 0) (1; 0, 0, 0)\n trailer_pos_valid: false\n license_plate: \"\"\n}\n"
                });
                this.button_save_file.Enabled = true;
                this.button_clear_jobs.Enabled = true;
                string text8 = " " + text6 + "km";
                if (text6 == "3000")
                {
                    text8 = "";
                }
                this.label_added_cargo_list.Text = string.Concat(new object[]
                {
                    this.label_added_cargo_list.Text,
                    "\r\n",
                    this.number_of_jobs_added,
                    ". ",
                    text5,
                    " ",
                    Resource.from,
                    text,
                    "(",
                    text3,
                    ") ",
                    Resource.to,
                    text2,
                    "(",
                    text4,
                    ")",
                    text8
                });
                if (text6 != "3000")
                {
                    this.total_km += int.Parse(text6);
                }
                this.label_total.Text = this.total_km.ToString() + " km";
                this.dropbox_source_city.SelectedIndex = this.dropbox_destination_city.SelectedIndex;
                this.dropbox_source_company.SelectedIndex = this.dropbox_destination_company.SelectedIndex;
                this.empty_mode++;
                int num2;
                if (this.number_of_jobs_added == 1)
                {
                    num2 = 1;
                }
                else
                {
                    num2 = this.number_of_jobs_added + 1;
                }
                if (this.loop_every != 0 && num2 % this.loop_every == 0)
                {
                    this.dropbox_destination_city.SelectedIndex = this.dropbox_destination_city.Items.IndexOf(this.loop_start_city);
                    this.dropbox_destination_company.SelectedIndex = this.dropbox_destination_company.Items.IndexOf(this.loop_start_company);
                    text2 = this.loop_start_city;
                    text4 = this.loop_start_company;
                }
                if (this.empty_mode_cargo != "0" && this.number_of_jobs_added % 2 == 1)
                {
                    int num3 = 50;
                    string text9 = "";
                    while (text9 == "")
                    {
                        text9 = this.get_random_city_within_distance(text2, num3);
                        num3 += 50;
                        if (num3 > 400)
                        {
                            text9 = text2;
                            break;
                        }
                    }
                    text2 = text9;
                    this.dropbox_destination_city.SelectedIndex = this.dropbox_destination_city.Items.IndexOf(text2);
                    this.dropbox_list_cargo.SelectedIndex = this.dropbox_list_cargo.Items.IndexOf(this.empty_mode_cargo);
                }
            }
        }

        private void prepare_events()
        {
            for (int i = 0; i < this.economy_event.Length; i++)
            {
                for (int j = 0; j < this.economy_events_table.GetLength(0); j++)
                {
                    if (this.economy_event[i] == this.economy_events_table[j, 3] && this.economy_events_table[j, 4] == " param: 0")
                    {
                        this.economy_events_table[j, 2] = (this.game_time + (i + 1) * this.job_pickup_time * 60).ToString();
                    }
                }
            }
            string[] array = this.economy_event_queue;
            string[,] array2 = this.economy_events_table;
            string[,] array3 = new string[1, 5];
            for (int i = 1; i < this.economy_events_table.GetLength(0); i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    array3[0, k] = this.economy_events_table[i, k];
                }
                for (int j = i; j > 0; j--)
                {
                    if (int.Parse(array3[0, 2]) < int.Parse(this.economy_events_table[j - 1, 2]))
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            this.economy_events_table[j, k] = this.economy_events_table[j - 1, k];
                            this.economy_events_table[j - 1, k] = array3[0, k];
                        }
                    }
                }
            }
        }

        private void button_save_file_Click(object sender, System.EventArgs e)
        {
            this.message_board.ForeColor = Color.Black;
            this.message_board.Text = Resource.Message_saving;
            this.message_board.Refresh();
            if (System.IO.File.GetLastWriteTime(this.miejsce_savea + "\\game.sii") > this.modification_timestamp)
            {
                this.message_board.ForeColor = Color.Red;
                this.message_board.Text = Resource.Error_Save_modified;
                this.log_writer("Save game was modified - reload file to prevent progress loss");
                this.message_board.Refresh();
            }
            else
            {
                this.prepare_events();
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\manifest.txt", this.label_added_cargo_list.Text + "\r\nTotal: " + this.total_km.ToString() + " km");
                System.IO.File.WriteAllText(this.miejsce_savea + "\\game.sii", this.plik[0] + "\n");
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(this.miejsce_savea + "\\game.sii", true))
                {
                    bool flag = false;
                    int num = 0;
                    int num2 = 0;
                    for (int i = 1; i < this.plik.Length; i++)
                    {
                        streamWriter.WriteLine(this.plik[i]);
                        string text = this.plik[i];
                        for (int j = 0; j < this.write_company.Length; j++)
                        {
                            if (this.plik[i] == this.write_company[j])
                            {
                                flag = true;
                                num2 = j;
                                string text2 = this.plik[i];
                            }
                            if (this.plik[i].StartsWith("economy_event_queue :"))
                            {
                                streamWriter.WriteLine(this.plik[i + 1]);
                                i++;
                                int k;
                                for (k = 0; k < this.economy_events_table.GetLength(0); k++)
                                {
                                    streamWriter.WriteLine(string.Concat(new object[]
                                    {
                                        " data[",
                                        k,
                                        "]: ",
                                        this.economy_events_table[k, 0]
                                    }));
                                }
                                i += k;
                                streamWriter.WriteLine("}");
                                streamWriter.WriteLine("");
                                i += 2;
                                for (int l = 0; l < this.economy_events_table.GetLength(0); l++)
                                {
                                    for (int m = 1; m < this.economy_events_table.GetLength(1); m++)
                                    {
                                        if (m == 2)
                                        {
                                            streamWriter.WriteLine(" time: " + this.economy_events_table[l, m]);
                                        }
                                        else
                                        {
                                            streamWriter.WriteLine(this.economy_events_table[l, m]);
                                        }
                                    }
                                    streamWriter.WriteLine("}");
                                    streamWriter.WriteLine("");
                                    i += 6;
                                }
                            }
                            if (flag && this.plik[i].StartsWith("job_offer_data : "))
                            {
                                string text3 = this.jobs_added[num2];
                                string text4 = this.plik[i];
                                streamWriter.WriteLine(this.jobs_added[num2]);
                                i += 13;
                                flag = false;
                                num++;
                            }
                        }
                    }
                }
                this.message_board.ForeColor = Color.Black;
                this.message_board.Text = Resource.Message_File_saved;
                this.message_board.Refresh();
                this.modification_timestamp = System.IO.File.GetLastWriteTime(this.miejsce_savea + "\\game.sii");
            }
        }

        private void button_clear_jobs_Click(object sender, System.EventArgs e)
        {
            this.clear_data();
        }

        private void dropbox_destination_company_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.propose_randoms == "1")
            {
                this.dropbox_list_cargo.SelectedIndex = this.rand.Next(this.dropbox_list_cargo.Items.Count);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.textField_enter_directory = new TextBox();
            this.button_Select_directory = new Button();
            this.label_katalog_savea = new Label();
            this.button_Load_save = new Button();
            this.message_board = new Label();
            this.dropbox_source_city = new ComboBox();
            this.dropbox_destination_city = new ComboBox();
            this.label_source = new Label();
            this.label_dest = new Label();
            this.dropbox_destination_company = new ComboBox();
            this.dropbox_source_company = new ComboBox();
            this.label_destination_company = new Label();
            this.label_source_company = new Label();
            this.label_cargo = new Label();
            this.dropbox_list_cargo = new ComboBox();
            this.Add_cargo_button = new Button();
            this.button_save_file = new Button();
            this.label_added_cargo_list = new Label();
            this.button_clear_jobs = new Button();
            this.label1 = new Label();
            this.label_version = new Label();
            this.Label_Profile = new Label();
            this.Label_profile_loaded = new Label();
            this.label_total = new Label();
            base.SuspendLayout();
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest_1);
            this.textField_enter_directory.Location = new Point(12, 45);
            this.textField_enter_directory.Name = "textField_enter_directory";
            this.textField_enter_directory.Size = new Size(443, 20);
            this.textField_enter_directory.TabIndex = 0;
            this.textField_enter_directory.Text = "Libraries\\Documents\\Euro Truck Simulator 2\\profiles";
            this.button_Select_directory.Location = new Point(461, 45);
            this.button_Select_directory.Name = "button_Select_directory";
            this.button_Select_directory.Size = new Size(26, 23);
            this.button_Select_directory.TabIndex = 1;
            this.button_Select_directory.Text = "...";
            this.button_Select_directory.UseVisualStyleBackColor = true;
            this.button_Select_directory.Click += new System.EventHandler(this.Select_directory_Click);
            this.label_katalog_savea.AutoSize = true;
            this.label_katalog_savea.Location = new Point(12, 26);
            this.label_katalog_savea.Name = "label_katalog_savea";
            this.label_katalog_savea.Size = new Size(121, 13);
            this.label_katalog_savea.TabIndex = 2;
            this.label_katalog_savea.Text = "Podaj katalog do profilu:";
            this.label_katalog_savea.Click += new System.EventHandler(this.label1_Click);
            this.button_Load_save.Location = new Point(15, 72);
            this.button_Load_save.Name = "button_Load_save";
            this.button_Load_save.Size = new Size(75, 23);
            this.button_Load_save.TabIndex = 3;
            this.button_Load_save.Text = "Load";
            this.button_Load_save.UseVisualStyleBackColor = true;
            this.button_Load_save.Click += new System.EventHandler(this.Load_save_Click);
            this.message_board.AutoSize = true;
            this.message_board.Location = new Point(96, 77);
            this.message_board.MinimumSize = new Size(5, 0);
            this.message_board.Name = "message_board";
            this.message_board.Size = new Size(5, 13);
            this.message_board.TabIndex = 4;
            this.dropbox_source_city.FormattingEnabled = true;
            this.dropbox_source_city.Location = new Point(15, 119);
            this.dropbox_source_city.Name = "dropbox_source_city";
            this.dropbox_source_city.Size = new Size(145, 21);
            this.dropbox_source_city.Sorted = true;
            this.dropbox_source_city.TabIndex = 5;
            this.dropbox_source_city.Visible = false;
            this.dropbox_source_city.SelectedIndexChanged += new System.EventHandler(this.source_city_SelectedIndexChanged);
            this.dropbox_destination_city.FormattingEnabled = true;
            this.dropbox_destination_city.Location = new Point(220, 119);
            this.dropbox_destination_city.Name = "dropbox_destination_city";
            this.dropbox_destination_city.Size = new Size(145, 21);
            this.dropbox_destination_city.Sorted = true;
            this.dropbox_destination_city.TabIndex = 6;
            this.dropbox_destination_city.Visible = false;
            this.dropbox_destination_city.SelectedIndexChanged += new System.EventHandler(this.destination_city_SelectedIndexChanged);
            this.label_source.AutoSize = true;
            this.label_source.Location = new Point(15, 100);
            this.label_source.Name = "label_source";
            this.label_source.Size = new Size(33, 13);
            this.label_source.TabIndex = 7;
            this.label_source.Text = "From:";
            this.label_source.Visible = false;
            this.label_dest.AutoSize = true;
            this.label_dest.Location = new Point(220, 99);
            this.label_dest.Name = "label_dest";
            this.label_dest.Size = new Size(63, 13);
            this.label_dest.TabIndex = 8;
            this.label_dest.Text = "Destination:";
            this.label_dest.Visible = false;
            this.dropbox_destination_company.FormattingEnabled = true;
            this.dropbox_destination_company.Location = new Point(279, 147);
            this.dropbox_destination_company.Name = "dropbox_destination_company";
            this.dropbox_destination_company.Size = new Size(86, 21);
            this.dropbox_destination_company.Sorted = true;
            this.dropbox_destination_company.TabIndex = 9;
            this.dropbox_destination_company.Visible = false;
            this.dropbox_destination_company.SelectedIndexChanged += new System.EventHandler(this.dropbox_destination_company_SelectedIndexChanged);
            this.dropbox_source_company.FormattingEnabled = true;
            this.dropbox_source_company.Location = new Point(74, 147);
            this.dropbox_source_company.Name = "dropbox_source_company";
            this.dropbox_source_company.Size = new Size(86, 21);
            this.dropbox_source_company.Sorted = true;
            this.dropbox_source_company.TabIndex = 10;
            this.dropbox_source_company.Visible = false;
            this.dropbox_source_company.SelectedIndexChanged += new System.EventHandler(this.source_company_SelectedIndexChanged);
            this.label_destination_company.AutoSize = true;
            this.label_destination_company.Location = new Point(217, 147);
            this.label_destination_company.Name = "label_destination_company";
            this.label_destination_company.Size = new Size(50, 13);
            this.label_destination_company.TabIndex = 11;
            this.label_destination_company.Text = "company";
            this.label_destination_company.Visible = false;
            this.label_source_company.AutoSize = true;
            this.label_source_company.Location = new Point(15, 150);
            this.label_source_company.Name = "label_source_company";
            this.label_source_company.Size = new Size(50, 13);
            this.label_source_company.TabIndex = 12;
            this.label_source_company.Text = "company";
            this.label_source_company.Visible = false;
            this.label_cargo.AutoSize = true;
            this.label_cargo.Location = new Point(392, 99);
            this.label_cargo.Name = "label_cargo";
            this.label_cargo.Size = new Size(38, 13);
            this.label_cargo.TabIndex = 13;
            this.label_cargo.Text = "Cargo:";
            this.label_cargo.Visible = false;
            this.dropbox_list_cargo.FormattingEnabled = true;
            this.dropbox_list_cargo.Location = new Point(395, 119);
            this.dropbox_list_cargo.Name = "dropbox_list_cargo";
            this.dropbox_list_cargo.Size = new Size(126, 21);
            this.dropbox_list_cargo.Sorted = true;
            this.dropbox_list_cargo.TabIndex = 14;
            this.dropbox_list_cargo.Visible = false;
            this.Add_cargo_button.Location = new Point(15, 188);
            this.Add_cargo_button.Name = "Add_cargo_button";
            this.Add_cargo_button.Size = new Size(118, 23);
            this.Add_cargo_button.TabIndex = 15;
            this.Add_cargo_button.Text = "Add Cargo";
            this.Add_cargo_button.UseVisualStyleBackColor = true;
            this.Add_cargo_button.Visible = false;
            this.Add_cargo_button.Click += new System.EventHandler(this.Add_cargo_button_Click);
            this.button_save_file.Enabled = false;
            this.button_save_file.Location = new Point(16, 457);
            this.button_save_file.Name = "button_save_file";
            this.button_save_file.Size = new Size(75, 23);
            this.button_save_file.TabIndex = 16;
            this.button_save_file.Text = "Save file";
            this.button_save_file.UseVisualStyleBackColor = true;
            this.button_save_file.Visible = false;
            this.button_save_file.Click += new System.EventHandler(this.button_save_file_Click);
            this.label_added_cargo_list.AutoSize = true;
            this.label_added_cargo_list.Location = new Point(15, 225);
            this.label_added_cargo_list.MaximumSize = new Size(0, 210);
            this.label_added_cargo_list.MinimumSize = new Size(5, 5);
            this.label_added_cargo_list.Name = "label_added_cargo_list";
            this.label_added_cargo_list.Size = new Size(71, 13);
            this.label_added_cargo_list.TabIndex = 17;
            this.label_added_cargo_list.Text = "Added cargo:";
            this.label_added_cargo_list.Visible = false;
            this.button_clear_jobs.Enabled = false;
            this.button_clear_jobs.Location = new Point(139, 188);
            this.button_clear_jobs.Name = "button_clear_jobs";
            this.button_clear_jobs.Size = new Size(100, 23);
            this.button_clear_jobs.TabIndex = 18;
            this.button_clear_jobs.Text = "Clear Jobs";
            this.button_clear_jobs.UseVisualStyleBackColor = true;
            this.button_clear_jobs.Visible = false;
            this.button_clear_jobs.Click += new System.EventHandler(this.button_clear_jobs_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 6.5f, FontStyle.Regular, GraphicsUnit.Point, 238);
            this.label1.Location = new Point(449, 455);
            this.label1.Name = "label1";
            this.label1.Size = new Size(72, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Made by: Xyzan";
            this.label_version.AutoSize = true;
            this.label_version.Font = new Font("Microsoft Sans Serif", 6.5f, FontStyle.Regular, GraphicsUnit.Point, 238);
            this.label_version.Location = new Point(449, 468);
            this.label_version.Name = "label_version";
            this.label_version.Size = new Size(39, 12);
            this.label_version.TabIndex = 20;
            this.label_version.Text = "version:";
            this.Label_Profile.AutoSize = true;
            this.Label_Profile.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.Label_Profile.Location = new Point(245, 9);
            this.Label_Profile.Name = "Label_Profile";
            this.Label_Profile.Size = new Size(0, 13);
            this.Label_Profile.TabIndex = 21;
            this.Label_profile_loaded.AutoSize = true;
            this.Label_profile_loaded.Location = new Point(161, 9);
            this.Label_profile_loaded.Name = "Label_profile_loaded";
            this.Label_profile_loaded.Size = new Size(78, 13);
            this.Label_profile_loaded.TabIndex = 22;
            this.Label_profile_loaded.Text = "Profile Loaded:";
            this.label_total.AutoSize = true;
            this.label_total.Location = new Point(279, 225);
            this.label_total.Name = "label_total";
            this.label_total.Size = new Size(0, 13);
            this.label_total.TabIndex = 23;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(533, 489);
            base.Controls.Add(this.label_total);
            base.Controls.Add(this.Label_profile_loaded);
            base.Controls.Add(this.Label_Profile);
            base.Controls.Add(this.label_version);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button_clear_jobs);
            base.Controls.Add(this.label_added_cargo_list);
            base.Controls.Add(this.button_save_file);
            base.Controls.Add(this.Add_cargo_button);
            base.Controls.Add(this.dropbox_list_cargo);
            base.Controls.Add(this.label_cargo);
            base.Controls.Add(this.label_source_company);
            base.Controls.Add(this.label_destination_company);
            base.Controls.Add(this.dropbox_source_company);
            base.Controls.Add(this.dropbox_destination_company);
            base.Controls.Add(this.label_dest);
            base.Controls.Add(this.label_source);
            base.Controls.Add(this.dropbox_destination_city);
            base.Controls.Add(this.dropbox_source_city);
            base.Controls.Add(this.message_board);
            base.Controls.Add(this.button_Load_save);
            base.Controls.Add(this.label_katalog_savea);
            base.Controls.Add(this.button_Select_directory);
            base.Controls.Add(this.textField_enter_directory);
            base.Name = "Form1";
            this.Text = "Virtual Speditor";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}
