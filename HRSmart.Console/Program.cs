﻿using HRSmart.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSmart.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("here1");
            mysqlpiContext mc = new mysqlpiContext();
            buisness b = new buisness();
            b.name = "test2";
            mc.buisnesses.Add(b);
            mc.SaveChanges();
            System.Console.WriteLine("here2");
            System.Console.Read();
        }
    }
}
