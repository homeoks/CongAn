using CongAn.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CongAn.Helper
{
    public static class DbHelper
    {
        public static List<T> GetList<T>()
        {
            var reader = AppDbContext.ExcuteSelect($"SELECT * FROM {typeof(T)}");

            var data = new List<T>();
            while (reader.Read()) // Read() returns true if there is still a result line to read
            {
                string myreader = reader.GetString(1);
                string myreader2 = reader.GetString(0);
                LogHelper.DebugLog(myreader);
            }
            return data;
        } 
        
        public static List<T> Create<T>()
        {
            var reader = AppDbContext.ExcuteSelect($"SELECT * FROM {typeof(T)}");

            var data = new List<T>();
            while (reader.Read()) // Read() returns true if there is still a result line to read
            {
                string myreader = reader.GetString(1);
                string myreader2 = reader.GetString(0);
                LogHelper.DebugLog(myreader);
            }
            return data;
        }
    }
}
