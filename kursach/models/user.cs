using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace kursach.models
{ 
    //Создаем класс User.Делаем его серилизуемым.
    [Serializable]
    public class User
    {
        public string login;
        public string password;
        //метод сохранения данныз в локальный файл с именем user.data
        public static void SaveToLocalFile(User newUser, string login)
        {
            List<User> users = GetUsersFromLocalFile();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            users.Add(newUser);
            using (FileStream fs = new FileStream("user.data", FileMode.OpenOrCreate))
            {
                try
                {


                    binaryFormatter.Serialize(fs, users);
                }
                catch
                {

                }
            }
            /*DataBaseModel database = new DataBaseModel();
            SqlCommand command = new SqlCommand("INSERT INTO users  UserData VALUE @UserData WHERE Login=@Login", database.getConnection());
            database.OpenConnection();
           
            // путь к файлу для загрузки
            string filename = @"C:\Users\andru\Desktop\Никита\Repos\kursach\kursach\bin\Debug\user.data";                                                                    
            byte[] imageData;
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }
            command.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@UserData", SqlDbType.VarBinary).Value = imageData;
            command.ExecuteNonQuery();
            database.CloseConnection();*/
        }
        //метод считывания имеющихся user с файла, и последующая десирилизация 
        public static List<User> GetUsersFromLocalFile()
        {
            List<User> users = new List<User>();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("user.data", FileMode.OpenOrCreate))
            {
                try
                {
                    users = (List<User>)binaryFormatter.Deserialize(fs);
                }
                catch
                {
                    users = new List<User>();
                }
            }

            return users;
        }
    }
}