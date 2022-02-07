using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PROGCRAFT_Demo.Utilities
{
    class LoadData
    {
        //public static string LoadTextFromFile(string path)
        //{
        //    return File.ReadAllText(path);
        //}

        public static string LoadTextFromFile(string path) => File.ReadAllText(path);

        public static List<Item> LoadLinesFromFile(string path)
        {
            //temp list of items
            List<Item> items = new List<Item>();

            foreach (string s in File.ReadAllLines(path))
            {
                items.Add(new Item() {Name = s });
            }

            return items;
        }

    }
}
