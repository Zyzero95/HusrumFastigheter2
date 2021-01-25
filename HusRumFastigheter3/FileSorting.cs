using System;
using System.Collections.Generic;
using System.Text;

namespace HusRumFastigheter3
{
    class FileSorting
    {

        public static void SortItemFromFile()
        {
            var file = System.IO.File.ReadAllLines("2021-01-02.txt");
            foreach(var item in file)
            {
                var row = item.Split(',');

                if(row.Length == 5)
                {
                    Console.WriteLine($"{row[0]}\t{row[1]}\t{row[2]}\t{row[3]}\t{row[4]}\t");
                }
                else
                {
                    Console.WriteLine($"{row[0]}\t{row[1]}\t");
                }
            }
        }
    }
}
