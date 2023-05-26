using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_05gg.Classes
{
    public class ClassSports
    {
        string fio;
        int nambers;
        double result1;
        double result2;
        double result3;
        double result4;
        double result5;
        string sports;
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }
        public int Nambers
        {
            get { return nambers; }
            set { nambers = value; }
        }
        public double Result1
        {
            get { return result1; }
            set { result1 = value; }
        }
        public double Result2
        {
            get { return result2; }
            set { result2 = value; }
        }
        public double Result3
        {
            get { return result3; }
            set { result3 = value; }
        }
        public double Result4
        {
            get { return result4; }
            set { result4 = value; }
        }
        public double Result5
        {
            get { return result5; }
            set { result5 = value; }
        }
        public string Sports
        {
            get { return sports; }
            set { sports = value; }
        }
        public ClassSports()
        {
            fio = string.Empty;
            nambers = 0;
            result1 = 0.00;
            result2 = 0.00;
            result3 = 0.00;
            result4 = 0.00;
            result5 = 0.00;
            sports = string.Empty;
        }
        public ClassSports(string f, int n, double r1, double r2, double r3, double r4, double r5, string s)
        {
            fio = f;
            nambers = n;
            result1 = r1;
            result2 = r2;
            result3 = r3;
            result4 = r4;
            result5 = r5;
            sports = s;
        }
    }
}
