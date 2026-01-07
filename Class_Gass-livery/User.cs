using MySql.Data.MySqlClient;
namespace Class_Gass_livery
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private string fullName;
        private short gender;
        private string phoneNumber;
        private string address;
        private DateOnly birthDay;
        private Driver driver;
        private List<Shop> shops;
        private string photo;

        public User(int iD, string username, string password, string email, string fullName, short gender, string phoneNumber, string address, DateOnly birthDay, string photo)
        {
            ID = iD;
            Username = username;
            Password = password;
            Email = email;
            FullName = fullName;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Address = address;
            BirthDay = birthDay;
            Photo = photo;
        }

        public int ID { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { set => password = value; }
        public string Email { get => email; set => email = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public short Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public DateOnly BirthDay { get => birthDay; set => birthDay = value; }
        public Driver Driver { get => driver; }
        public List<Shop> Shops { get => shops; }
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
                    (string)data["password"],
                    (string)data["email"],
                    (string)data["full_name"],
                    (short)data["geder"],
                    (string)data["phone"],
                    (string)data["address"],
                    (DateOnly)data["birthday"],
                    (string)data["profile_pic_path"]);
                list.Add(temp);
            }
            return list;
        }
    }
}
