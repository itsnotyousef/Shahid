using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using static Shahid.UserMainMenu;
using System.Windows.Forms;

namespace Shahid
{
    internal class DataBase
    {
        public static string ordb = "Data source=orcl;User Id=Hr;Password=hr;";
        public static OracleConnection conn = new OracleConnection(ordb);
       
        public static void Add_user(string firstName, string lastName, string email, string password)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "add_user";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_first_name", firstName);
            cmd.Parameters.Add("p_last_name", lastName);
            cmd.Parameters.Add("p_email", email);
            cmd.Parameters.Add("p_pass", password);
            cmd.ExecuteNonQuery();

        }

        public static bool CheckAccount(string enteredMail, string enteredPassword)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PASS from USERS where EMAIL =: enterdMail ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("enterdMail", enteredMail);
            OracleDataReader dr = cmd.ExecuteReader();
            string password = "";
            if (dr.Read())
            {
                password = dr[0].ToString();
            }
            else
            {
                return false;
            }
            if (password == enteredPassword)
                return true;
            else
                return false;
        }
        public static video Retrive_Video(Int32 Id)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from video where video_id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", Id);

            OracleDataReader dr = cmd.ExecuteReader();

            video retrivedVideo = new video();

            if (dr.Read())
            {

                retrivedVideo.VideoId = Convert.ToInt32(dr[0].ToString());
                retrivedVideo.Video_Name = dr[1].ToString();
                retrivedVideo.URL = dr[2].ToString();
                retrivedVideo.Video_Type = dr[3].ToString();
                retrivedVideo.Age_Allowed = Convert.ToInt32(dr[4].ToString());
                retrivedVideo.rate = Convert.ToInt32(dr[5].ToString());
                retrivedVideo.views = Convert.ToInt32(dr[6].ToString());
                retrivedVideo.description = dr[7].ToString();
            }
            return retrivedVideo;
        }
        public static int GetUserId(string Mail)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select user_id from USERS where EMAIL =: Mail ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Mail", Mail);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return Convert.ToInt32(dr[0].ToString());
            }
            return -1;

        }
        public static void AddRate(int user_id, int video_id, int rate)
        {
            OracleCommand CheckCmd = new OracleCommand();
            CheckCmd.Connection = conn;
            CheckCmd.CommandText = "select * from rate where user_id = :user_id and video_id = :video_id";
            CheckCmd.CommandType = CommandType.Text;
            CheckCmd.Parameters.Add("user_id", user_id);
            CheckCmd.Parameters.Add("video_id", video_id);

            OracleDataReader dr = CheckCmd.ExecuteReader();

            if (dr.Read())
            {
                OracleCommand update = new OracleCommand();
                update.Connection = conn;
                update.CommandText = "update rate set rate = :rate where user_id = :user_id and video_id = :video_id";
                update.CommandType = CommandType.Text;
                update.Parameters.Add("user_id", user_id);
                update.Parameters.Add("video_id", video_id);
                update.Parameters.Add("rate", rate);

                try
                {
                    int u = update.ExecuteNonQuery();
                    MessageBox.Show("rating updated");
                }
                catch
                {
                    MessageBox.Show("please select video");
                }
                
                
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into rate values (:user_id , :video_id  , :rate ) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("user_id", user_id);
                cmd.Parameters.Add("video_id", video_id);
                cmd.Parameters.Add("rate", rate);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("rating added");
                }
                catch
                {
                    MessageBox.Show("please select video");
                }

                
            }

            
        }
        public static void AddToFavoriteList(int user_id, int video_id)
        {
            OracleCommand checkingCmd = new OracleCommand();
            checkingCmd.Connection = conn;
            checkingCmd.CommandText = "select * from Favorite_List where video_id = :video_id and user_id = :user_id";
            checkingCmd.CommandType = CommandType.Text;
            checkingCmd.Parameters.Add("video_id", video_id);
            checkingCmd.Parameters.Add("user_id", user_id);

            OracleDataReader dr = checkingCmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("already in favorite");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Favorite_List values (:user_id , :video_id ) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("user_id", user_id);
                cmd.Parameters.Add("video_id", video_id);
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show("added to favorite");
            }

            
        }

        public static void AddToWatchLaterList(int user_id, int video_id)
        {
            OracleCommand checkingCmd = new OracleCommand();
            checkingCmd.Connection = conn;
            checkingCmd.CommandText = "select * from Watch_Later_List where video_id = :video_id and user_id = :user_id";
            checkingCmd.CommandType = CommandType.Text;
            checkingCmd.Parameters.Add("video_id", video_id);
            checkingCmd.Parameters.Add("user_id", user_id);

            OracleDataReader dr = checkingCmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("already in watch later");
            }
            else
            {
                
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Watch_Later_List values (:user_id , :video_id ) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("user_id", user_id);
                cmd.Parameters.Add("video_id", video_id);
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show("added to watch later");
            }
        }
        public static int GetVideoId(string name)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select video_id from video where video_name =: name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", name);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return Convert.ToInt32(dr[0].ToString());
            }

            return -1;

        }
        public static User Retrive_User_Info(int user_id)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Users where user_id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", user_id);

            OracleDataReader dr = cmd.ExecuteReader();

            User user = new User();

            if (dr.Read())

                user.user_id = Convert.ToInt32(dr[0].ToString());
            user.first_name = dr[1].ToString();
            user.last_name = dr[2].ToString();
            user.email = dr[3].ToString();
            user.password = dr[4].ToString();


            return user;
        }
        public static void Save_Password(int user_id, string password)
        {
            string conn = "Data source = orcl ; User Id = Hr ; password = hr ;";


            using (OracleConnection connection = new OracleConnection(conn))
            {
                // Step 1: Create a DataAdapter and a DataTable
                OracleDataAdapter dataAdapter = new OracleDataAdapter("SELECT * FROM Users WHERE User_id = :Id", connection);
                dataAdapter.SelectCommand.Parameters.Add(":Id", OracleDbType.Int32).Value = user_id;
                DataTable dataTable = new DataTable();

                // Step 2: Use the OracleCommandBuilder to generate update commands
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(dataAdapter);

                // Step 3: Fill the DataTable with data from the database
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    Console.WriteLine("No rows found.");
                    return;
                }

                // Step 4: Modify the DataTable (for example, update the password)
                foreach (DataRow row in dataTable.Rows)
                {
                    row["Pass"] = password; // Change "password_column_name" to your actual column name
                }

                // Step 5: Use the DataAdapter to update changes back to the database
                dataAdapter.Update(dataTable);
            }



        }

        public static void Get_Favorite_Names(int user_id)
        {
            string connectionString = "Data source = orcl ; User Id = Hr ; password = hr ;";


            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT video_id FROM Favorite_List WHERE user_id = :userID";
                OracleCommand command = new OracleCommand(sqlQuery, connection);
                command.Parameters.Add(new OracleParameter("userID", OracleDbType.Int32)).Value = user_id;

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, " Favorite_List");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return;
                }

                // Data is now loaded into the DataSet.
                DataTable videosTable = dataSet.Tables[" Favorite_List"];
                if (videosTable.Rows.Count > 0)
                {

                    foreach (DataRow row in videosTable.Rows)
                    {
                        int video_id = Convert.ToInt32(row["video_id"].ToString());
                        string video_name = GetVideoName(video_id);
                        Console.WriteLine("is here " + video_name);
                        Shahid.ShowLists.Favorite_Videos_Names.Add(video_name);

                    }
                    Console.WriteLine("is " + Shahid.ShowLists.Favorite_Videos_Names.Count.ToString());
                }
             
            }
        }
        public static void Get_Watch_Later_Names(int user_id)
        {
            string connectionString = "Data source = orcl ; User Id = Hr ; password = hr ;";


            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT video_id FROM Watch_Later_list WHERE user_id = :userID";
                OracleCommand command = new OracleCommand(sqlQuery, connection);
                command.Parameters.Add(new OracleParameter("userID", OracleDbType.Int32)).Value = user_id;

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, " Watch_Later_list");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return;
                }

                // Data is now loaded into the DataSet.
                DataTable videosTable = dataSet.Tables[" Watch_Later_list"];
                if (videosTable.Rows.Count > 0)
                {

                    foreach (DataRow row in videosTable.Rows)
                    {
                        int video_id = Convert.ToInt32(row["video_id"].ToString());
                        string video_name = GetVideoName(video_id);
                        Console.WriteLine("is here " + video_name);
                        Shahid.ShowLists.Watch_Later_Videos_Names.Add(video_name);

                    }
                  
                }

            }
        }


        public static string GetVideoName(int video_id)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select video_name from video where video_id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", video_id);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr[0].ToString();

        }
        public static void AddVideo( string video_name , string url , string video_type,int age_allowed, int rating , int watches , string Decription) 
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Add_Video ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("video_name", video_name);
            cmd.Parameters.Add("url", url);
            cmd.Parameters.Add("video_type", video_type);
            cmd.Parameters.Add("age_allowed", age_allowed);
            cmd.Parameters.Add("rating", rating);
            cmd.Parameters.Add("watches", watches);
            cmd.Parameters.Add("description", Decription);
            cmd.ExecuteNonQuery();

        }
        public static void RetrieveAllUsers()
        {   

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllUsers";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add( "user" ,OracleDbType.RefCursor,ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            Shahid.ShowUsersInfo.AllUsers.Clear();
            while(dr.Read())
            {
                Console.WriteLine("im here");
                int id = Convert.ToInt32(dr[0]);
                string first_name = dr[1].ToString();
                string last_name = dr[2].ToString();
                string mail = dr[3].ToString();
                string pass = dr[4].ToString();
                Shahid.UserMainMenu.User user = new User();
                user.user_id = id;
                user.first_name = first_name;
                user.last_name = last_name;
                user.email = mail;
                user.password = pass;
                //Console.WriteLine("im here yarab n5l9 ");
                Shahid.ShowUsersInfo.AllUsers.Add(user);
            }

        }

        public static int GetRate(int user_id, int video_id) 
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetRate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("user_id",user_id);
            cmd.Parameters.Add("video_id", video_id);
            cmd.Parameters.Add("rating", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            int r = Convert.ToInt32(cmd.Parameters["rating"].Value.ToString());
            return r;
        }

        public static void DeleteVideo(int video_id) 
        {
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = " select * from Video Where video_id =: video_id  ";
            checkCmd.CommandType = CommandType.Text;
            checkCmd.Parameters.Add("video_id", video_id);

            OracleDataReader dr = checkCmd.ExecuteReader();
            

            if (!dr.Read())
            {
                MessageBox.Show("video not found");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Delete from Video Where video_id =: video_id  " ;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("video_id", video_id);
            
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Video Has Been Deleted <333");
            }

        }

    }




}

