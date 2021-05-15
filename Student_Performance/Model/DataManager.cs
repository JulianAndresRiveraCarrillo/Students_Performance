using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Student_Performance.Model
{
    class DataManager
    {
        private DataTable table = new DataTable();
        private DataTable table_aux = new DataTable();

        public DataTable Table
        {
            get => table;
        }

        public void createTable(string file)
        {
            string[] data = System.IO.File.ReadAllLines(file);

            if (data.Length > 0)
            {
                string first = data[0].ToString().Replace("\"", " ").Trim();

                string[] text = Regex.Split(first, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                foreach (string header in text)
                {
                    table.Columns.Add(new DataColumn(header));
                }

                for (int i = 1; i < data.Length; i++)
                {
                    string[] line = Regex.Split(data[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    DataRow row = table.NewRow();

                    for (int j = 0; j < line.Length; j++)
                    {
                        try
                        {
                            row[j] = line[j].ToString().Replace("\"", " ").Trim();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("WARNING");
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            table_aux = table.Copy();
        }
        public void filterBySex(string path, string filter)
        {
            table.Clear();
            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[0].ToString().Replace("\"", " ").Trim().Equals(filter))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j].ToString().Replace("\"", " ").Trim();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void filterByRace(string path, string filter)
        {
            table.Clear();
            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {
                for (int i = 1; i < text.Length; i++)
                { 
                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[1].ToString().Replace("\"", " ").Trim().Equals(filter))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j].ToString().Replace("\"", " ").Trim();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void filterByPLevel(string path, string filter)
        {
            table.Clear();
            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[2].ToString().Replace("\"", " ").Trim().Equals(filter))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j].ToString().Replace("\"", " ").Trim();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void filterByLunch(string path, string filter)
        {
            table.Clear();
            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[3].ToString().Replace("\"", " ").Trim().Equals(filter))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j].ToString().Replace("\"", " ").Trim();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void filterByTest(string path, string filter)
        {
            table.Clear();
            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[4].ToString().Replace("\"", " ").Trim().Equals(filter))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j].ToString().Replace("\"", " ").Trim();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void filterByScore(string path, long min, long max, int filter)
        {
            table.Clear();
            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        string temp = data[filter].ToString().Replace("\"", " ").Trim();
                        long aux = 0;
                        long.TryParse(temp, out aux);

                        if (aux > min && aux < max)
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j].ToString().Replace("\"", " ").Trim();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

    }
}
