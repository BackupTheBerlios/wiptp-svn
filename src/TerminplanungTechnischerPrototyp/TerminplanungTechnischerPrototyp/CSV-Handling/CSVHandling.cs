using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TerminplanungTechnischerPrototyp.CSV_Handling
{
    class CSVHandling
    {
        public void loadData(String path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("{0} does not exist.", path);
                return;
            }
            using (StreamReader sr = File.OpenText(path))
            {
                String input;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                sr.Close();
            }
        }
    }
}
