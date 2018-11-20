﻿//using LiteDB;
//using LiteDB.Engine;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace LiteDB.Demo
//{
//    public class TestDataPage
//    {
//        static string PATH = @"D:\memory-file.db";
//        static BsonDocument doc = new BsonDocument
//        {
//            ["_id"] = 1,
//            ["name"] = "NoSQL Database",
//            ["birthday"] = new DateTime(1977, 10, 30),
//            ["phones"] = new BsonArray { "000000", "12345678" },
//            ["active"] = true
//        }; // 109b

//        public static void Run(Stopwatch sw)
//        {
//            File.Delete(PATH);

//            using (var s = new DataService(PATH))
//            {
//                // save on PageID: 0000:0
//                var b0 = s.Insert(doc);

//                doc["novo"] = new byte[100];

//                // save on PageID: 0000:1
//                var b1 = s.Insert(doc);

//                doc["novo"] = new byte[22000];

//                // save on PageID: 0001:0, 0002:0, 0000:3
//                var b2 = s.Insert(doc);

//                // update b
//                doc["novo"] = new byte[33000];

//                s.Update(b2.Position, doc);

//            }

//            using (var s = new DataService(PATH))
//            {
//                var doc0 = s.Read(new PageAddress(0, 0));
//                var doc1 = s.Read(new PageAddress(0, 1));
//                var doc2 = s.Read(new PageAddress(1, 0));
//            }


//        }
//    }
//}
