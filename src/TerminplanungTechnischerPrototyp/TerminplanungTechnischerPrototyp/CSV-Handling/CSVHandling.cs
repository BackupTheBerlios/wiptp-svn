using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TerminplanungTechnischerPrototyp.CSV_Handling
{
    class CSVHandling
    {
        private List<CSVStructure> Data = new List<CSVStructure>();
        public void loadData(String path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("{0} does not exist.", path);
                return;
            }
            using (StreamReader sr = File.OpenText(path))
            {
                String input = sr.ReadLine();
                while ((input = sr.ReadLine()) != null)
                {
                    String[] token = input.Split(';');
                    CSVStructure line = new CSVStructure();
                    //Nachname;Vorname;Klasse;GegenstandLangbezeichnung;GegenstandKurzbezeichnung;
                    //PrueferNachname;PrueferVorname;Klausel;Muendlich;Schriftlich;Praktisch;
                    //ZweitprueferNachname;ZweitprueferVorname;Datum;Zeitmuendlich;Zeitschriftlich;
                    //Zeitpraktisch;Raummuendlich;Raumschriftlich;Raumpraktisch;Bemerkung

                    line.Surname = token[0];
                    line.FirstName = token[1];
                    line.Class = token[2];
                    line.SubjectLongName = token[3];
                    line.SubjectShortName = token[4];
                    line.ExaminerSurName = token[5];
                    line.ExaminerFirstName = token[6];
                    line.Clause = token[7].ToUpper().Equals("Nein") ? false : true;
                    line.OralExam = token[8].ToUpper().Equals("J") ? true : false;
                    line.WrittenExam = token[9].ToUpper().Equals("J") ? true : false;
                    line.PracticalExam = token[10].ToUpper().Equals("J") ? true : false;
                    line.AssessorSurname = token[11];
                    line.AssessorFirstName = token[12];
                    line.Date = new DateTime(Convert.ToInt32(token[13].Split('.')[2]), Convert.ToInt32(token[13].Split('.')[1]), Convert.ToInt32(token[13].Split('.')[0]));
                    if (line.OralExam)
                        line.OralTime = new Time(Convert.ToByte(token[14].Split(':')[0]), Convert.ToByte(token[14].Split(':')[1]));
                    if (line.WrittenExam)
                        line.WrittenTime = new Time(Convert.ToByte(token[15].Split(':')[0]), Convert.ToByte(token[15].Split(':')[1]));
                    if (line.PracticalExam)
                        line.PracticalTime = new Time(Convert.ToByte(token[16].Split(':')[0]), Convert.ToByte(token[16].Split(':')[1]));
                    line.OralRoom = token[17];
                    line.WrittenRoom = token[18];
                    line.PracticalRoom = token[19];
                    line.Comment = token[20];
                    Data.Add(line);
                }
                sr.Close();
            }
        }
    }
}
