using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
namespace Class_Gass_livery
{
    public class User
    {
        private int id_user;
        private string username;
        private string password;
        private string email;
        private string fullName;
        private sbyte gender; 
        private string phoneNumber;
        private string address;
        private DateOnly birthDay;
        private string photo;

        public User(int iD, string username, string email, string fullName, sbyte gender, string phoneNumber, string address, DateTime birthDay, string photo)
        {
            ID_user = iD;
            Username = username;
            Email = email;
            FullName = fullName;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Address = address;
            BirthDay =DateOnly.FromDateTime(birthDay);
            Photo = photo;
        }

        public User (User objUser)
        {
            ID_user = objUser.ID_user;
            Username = objUser.Username;
            Email = objUser.Email;
            this.password = objUser.Password;
            FullName = objUser.FullName;
            Gender = objUser.Gender;
            PhoneNumber = objUser.PhoneNumber;
            Address = objUser.Address;
            BirthDay = objUser.BirthDay;
            Photo = objUser.Photo;
        }

        public int ID_user { get => id_user; set => id_user = value; }
        public string Username { get => username; set => username = value; }
        public string Password { 
            get => password; 
            set {
                password = PasswdMaker(value);
            } 
        }
        public string Email { get => email; set => email = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public sbyte Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public DateOnly BirthDay { get => birthDay; set => birthDay = value; }
        public string Photo { get => photo; set => photo = value; }

        public static List<User> Bacadata()
        {
            string select = "select * from users;";
            MySqlDataReader data = ConnectDB.Select(select);
            List<User> list = new List<User>();

            while (data.Read() == true)
            {
                User temp = new User(
                    (int)data["id_users"],
                    (string)data["username"],
                    (string)data["email"],
                    (string)data["full_name"],
                    (sbyte)data["gender"],
                    data["phone"].ToString(),
                    (string)data["address"],
                    (DateTime)data["birthday"],
                    (string)data["profile_pic_path"]);
                temp.password = (string)data["password"];
                list.Add(temp);
            }
            return list;
        }

        public static List<User> Bacadata(string perintah)
        {
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<User> list = new List<User>();

            while (data.Read() == true)
            {
                User temp = new User(
                    (int)data["id_users"],
                    (string)data["username"],
                    (string)data["email"],
                    (string)data["full_name"],
                    (sbyte)data["gender"],
                    data["phone"].ToString(),
                    (string)data["address"],
                    (DateTime)data["birthday"],
                    (string)data["profile_pic_path"]);
                temp.password = (string)data["password"];
                list.Add(temp);
            }
            return list;
        }

        public static void MasukData(User data) 
        {
            string perintah = $"INSERT INTO `users` " +
                              $"(`id_users`, `username`, `password`, `email`, `full_name`, `gender`, `profile_pic_path`, `phone`, `birthday`, `address`) " +
                              $"VALUES ('{data.ID_user}', '{data.Username}', '{data.Password}', '{data.Email}', '{data.FullName}', '{data.Gender}', '{data.Photo}', '{data.PhoneNumber}', '{data.BirthDay.ToString("yyyy-MM-dd")}', '{data.Address}');";
            ConnectDB.InputData(perintah);
        }

        public static int CreateID()
        {
            int noID = 0;
            string select = $"SELECT id_users FROM users WHERE id_users LIKE '{DateTime.Now.ToString("yyMMdd")}%' ORDER BY id_users DESC LIMIT 1; ";
            MySqlDataReader read = ConnectDB.Select(select);
            
            if (read.Read()) {
                string lastID = read.GetValue(0).ToString().Substring(6);
                noID = int.Parse(lastID) + 1;
            }
            int id = int.Parse($"{DateTime.Now.ToString("yyMMdd")}{noID.ToString().PadLeft(3,'0')}");
            return id;
        }

        public static string PasswdMaker (string password)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return password = builder.ToString();
        }
    }
}
