using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filedemo
{
    public class Class2
    {
        public static void filemethods()
        {
            string p = @"C:\Users\saivignesh\source\repos\Aug24Exercises\demo1.txt";
            File.Create(p);
        }
    }
}
