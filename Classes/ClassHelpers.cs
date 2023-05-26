using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _31_05gg.Classes
{
    class ClassHelpers
    {
        public static List<ClassSports> resultsing = new List<ClassSports>();
        public static List<string> Bestys = new List<string>();
        public static string fileName;
        public static void ReadListFromFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    ClassSports resultse = new ClassSports()
                    {
                        Fio = items[0].Trim(),
                        Nambers = int.Parse(items[1].Trim()),
                        Result1 = double.Parse(items[2].Trim()),
                        Result2 = double.Parse(items[3].Trim()),
                        Result3 = double.Parse(items[4].Trim()),
                        Result4 = double.Parse(items[5].Trim()),
                        Result5 = double.Parse(items[6].Trim())
                    };
                    resultsing.Add(resultse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", "Неверный формат данных!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        public static void SaveListToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, false, Encoding.UTF8);
            foreach (var item in resultsing)
            {
                streamWriter.WriteLine($"{item.Fio}; {item.Nambers}; {item.Result1}; {item.Result2}; {item.Result3}; {item.Result4}; {item.Result5}; ");
            }
            streamWriter.Close();
        }
        public static List<int> namberses = new List<int>()
        {
            
        };
    }
}

