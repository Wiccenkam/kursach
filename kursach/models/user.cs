using System;
using System.Collections.Generic;
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
        public static void SaveToLocalFile(User newUser)
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