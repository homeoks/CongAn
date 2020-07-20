using CongAn.Data;
using CongAn.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CongAn.Helper
{
    public static class UserRepository
    {
        public static List<User> GetList()
        {
            var reader = AppDbContext.ExcuteSelect($"SELECT * FROM Users");

            var data = new List<User>();
            while (reader.Read()) // Read() returns true if there is still a result line to read
            {
                var id = reader.GetInt16
                    (0);
                var name = reader.GetString(1);
                var image = reader.GetString(2);
                data.Add(new User
                {
                    Id = id,
                    Name = name,
                    Image = image,
                });
            }
            return data;
        }
        
        public static object AddNew(User user)
        {
            var reader = AppDbContext.ExcuteQuery($"Insert into Users(Name,Image) values('{user.Name}','{user.Image}')");

            return reader;
        }
    }
}
