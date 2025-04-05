using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace StudentDiary
{
    public enum UserRole
    {
        Student,
        Teacher
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    public class UserService
    {
        private const string UsersFile = "users.json";

        public static void SaveUsers(List<User> users)
        {
            string jsonData = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(UsersFile, jsonData);
        }

        public static List<User> LoadUsers()
        {
            if (File.Exists(UsersFile))
            {
                string jsonData = File.ReadAllText(UsersFile);
                return JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
            return new List<User>();
        }

        public static void RegisterUser(string username, string password, UserRole role)
        {
            var users = LoadUsers();
            if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Пользователь с таким именем уже существует.");
            users.Add(new User { Username = username, Password = password, Role = role });
            SaveUsers(users);
        }

        public static User Authenticate(string username, string password)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                           && u.Password == password);
        }
    }
}
