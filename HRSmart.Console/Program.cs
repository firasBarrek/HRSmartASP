using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSmart.data.Models;

namespace HRSmart.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***********Hello*************");
            mysqlpiContext ctx = new mysqlpiContext();
            question q = new question {body = "question1"};
            ctx.questions.Add(q);
            ctx.SaveChanges();
        }
    }
}
