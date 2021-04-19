using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public void generateGraph(DataTable table, string at1)
        {
            DataRowCollection rows = table.Rows;
            int numColumns = table.Columns.Count;

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i];

                    for(int j = 0; j < numColumns; j++)
                    {
                        if (info.Count == 0)
                        {
                            info.Add(new Student(row[at1].ToString(),1));
                        }
                        else
                        {
                            bool found = false;
                            for (int k = 0; k < info.Count; k++)
                            {
                                if (info[k].V1 == row[at1].ToString())
                                {
                                    info[k].V2++;
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                info.Add(new Student(row[at1].ToString(), 1));
                            }
                        }
                    }
                }
            }
        }



    }
}
