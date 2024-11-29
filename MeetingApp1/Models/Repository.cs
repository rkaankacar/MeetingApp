using System.Xml.Linq;

namespace MeetingApp1.Models
{
    public class Repository
    {
        private static List<UserInfo> _userInfo = new ();

        static Repository()
        {
            _userInfo.Add(new UserInfo() { Id = 1, Name = "Ali", Email = "ali@gmail.com", Phone = "11111", WillAttend = true });
            _userInfo.Add(new UserInfo() { Id = 2, Name = "Ahmet", Email = "ahmet@gmail.com", Phone = "3333", WillAttend = false });
            _userInfo.Add(new UserInfo() { Id = 3, Name = "Hakan", Email = "hakan@gmail.com", Phone = "2222", WillAttend = true });
        }

        public static List<UserInfo> Users
        { get { return _userInfo; } }


        public static void CreateUser(UserInfo userInfo)
        {
            userInfo.Id = Users.Count + 1;
            _userInfo.Add (userInfo);
        }

        public static UserInfo? GetById(int id)
        {
            return _userInfo.FirstOrDefault(userInfo => userInfo.Id == id); // her userinfoya ulaşır idsine bakar parametre olan id ile eşleniyorsa bulduğu ilk kaydı null değer gönderir
        }
    }
}
