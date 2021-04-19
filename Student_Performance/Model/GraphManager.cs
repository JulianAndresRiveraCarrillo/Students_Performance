using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace Student_Performance.Model
{
    class GraphManager
    {
        List<Student> info;

        public GraphManager()
        {
            info = new List<Student>();
        }

        public List<Student> Info
        {
            get => info;
        }

        public void GenerateGraph(string path, int at)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length > 0)
            { 
                for (int i = 1; i < 50; i++)
                {
                    //This will ignore commas between double quotes in the CSV file
                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        if (info.Count == 0)
                        {
                            info.Add(new Student(dataLine[at].Replace("\"", " ").Trim(), 1));
                        }
                        else
                        {
                            bool found = false;

                            for (int k = 0; k < info.Count && !found; k++)
                            {
                                if (info[k].V1 == dataLine[at].Replace("\"", " ").Trim())
                                {
                                    info[k].V2++;
                                    found = true;
                                }
                            }

                            if (!found)
                            {
                                info.Add(new Student(dataLine[at].Replace("\"", " ").Trim(), 1));
                            }
                        }
                    }
                }
            }
        }
    }
}
