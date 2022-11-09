using System;
using System.Data;
using System.Linq;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace  BMS.Models
{
    public static class DataAccessModel
    {
        internal const string DbConnection = @"Data Source=.\AppData\BMSData.db;Version=3; FailIfMissing=True; Foreign Keys=True;";
        //public static SQLiteConnection DbConnection = new SQLiteConnection("Data Source=D:\\Projects\\MVCTestProject\\BMS\\AppData\\BMSData.db;Version=3;");
        //GetHash Byte array.. 
        //It's private method which call in this class only.
        private static byte[] getHash(string inputData)
        {
             using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputData));
        }
        //Get Hash string convert normal string to Hash string.
        //It's public so convert data from the normal string to hash string and return it.
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in getHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
        public static async Task<BMS.Models.Login> SingInProcess(string userEmailId,string password)
        {
            BMS.Models.Login userInfo = new Login();
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(DbConnection))
                {
                    await conn.OpenAsync();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText="SELECT * FROM UseerLogin WHERE User_EmailId = @User_EmailId AND Password=@Password";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@User_EmailId",userEmailId);
                        cmd.Parameters.AddWithValue("@Password",password);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userInfo = new BMS.Models.Login(reader["User_EmailId"].ToString(),
                                reader["Password"].ToString(),
                                reader["CreateDate"].ToString(),
                                reader["IsEdit"].ToString()=="1"?true:false,
                                reader["IsView"].ToString()=="1"?true:false,
                                reader["IsAdmin"].ToString()=="1"?true:false,
                                reader["IsDelete"].ToString()=="1"?true:false);
                            }
                        }
                    }
                    await conn.CloseAsync();
                }    
            }
            catch{} 
            //(System.Exception)
            //{
               // throw;
           // }
            return userInfo;
        }
        public static async Task<bool> CheckUserExists(string userEmailId)
        {
            bool rtnUsertExists=false;
            DataTable dtForUserIngo = new DataTable();
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(DbConnection))
                {
                    await conn.OpenAsync();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText="SELECT * FROM UseerLogin WHERE User_EmailId = @User_EmailId";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@User_EmailId",userEmailId);
                        SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                        adp.Fill(dtForUserIngo);
                        if(dtForUserIngo.AsEnumerable().Count()>0)
                        {
                            rtnUsertExists=true;
                        } 
                    }
                    await conn.CloseAsync();
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                dtForUserIngo.Dispose();
                dtForUserIngo=null;
            }
            return rtnUsertExists;
        }
        public static async Task<bool> createNewUser(BMS.Models.Login lginData)
        {
            bool returnValues = true;
            using(SQLiteConnection conn = new SQLiteConnection(DbConnection) )
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO UseerLogin(User_EmailId,Password,IsEdit,IsView,IsDelete,IsAdmin,CreateDate) "
                                    +"VALUES (@User_EmailId,@Password,@IsEdit,@IsView,@IsDelete,@IsAdmin,@CreateDate)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@User_EmailId", lginData.UserEmailId);
                    cmd.Parameters.AddWithValue("@Password", lginData.Password);
                    cmd.Parameters.AddWithValue("@IsEdit", lginData.IsEdit==true?1:0);
                    cmd.Parameters.AddWithValue("@IsView", lginData.IsView==true?1:0);
                    cmd.Parameters.AddWithValue("@IsDelete", lginData.IsDelete==true?1:0);
                    cmd.Parameters.AddWithValue("@IsAdmin", lginData.IsAdmin==true?1:0);
                    cmd.Parameters.AddWithValue("@CreateDate", lginData.createDateTime);
                    try
                    {
                       await cmd.ExecuteNonQueryAsync();
                    }
                    catch (SQLiteException)
                    {
                        returnValues= false;
                    }
                }
                conn.Close();
            }

            return returnValues;   
        }
    }
}