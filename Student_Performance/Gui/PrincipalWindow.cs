using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class PrincipalWindow : Form
    {
        private DataManager  manager = new DataManager();
        public static string file;
        private string dataTraining1; //Ruta del conjunto de datos de entrenamiento del arbol de decision propio
        private bool loadData1 = false; //Si el entrenamiento del arbol propio se cargo sera verdadero si no falso

        public bool exit;

        public bool Exit
        {
            get => exit;
            set => exit = value;
        }

        public String File
        {
            get => file;
        }

        public PrincipalWindow()
        {
            InitializeComponent();
            
        }

        private void loadBT_Click(object sender, EventArgs e)
        {
            loadData.ShowDialog();
            string path = loadData.FileName;
            file = path;
            manager.createTable(path);

            if (manager.Table != null)
            {
                dataView.DataSource = manager.Table;
                graphicControl.buttonEnable();
            }
            graphicControl.setFile(file);

            buttonEnabled(true);

            loadBT.Enabled = false;
            refreshBT.Enabled = true;
        }

        private void buttonEnabled(bool v)
        {
            maleButton.Enabled = v;
            femaleButton.Enabled = v;
            etniBox.Enabled = v;
            parentBox.Enabled = v;
            lunchBox.Enabled = v;
            testBox.Enabled = v;
            mathCheck.Enabled = v;
            readingCheck.Enabled = v;
            writingCheck.Enabled = v;
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            manager.Table.Clear();
            manager.Table = manager.Table_Aux.Copy();
            dataView.DataSource = manager.Table;

            maleButton.Checked = false;
            femaleButton.Checked = false;
            mathCheck.Checked = false;
            writingCheck.Checked = false;
            readingCheck.Checked = false;
            minBox.Clear();
            maxBox.Clear();
            etniBox.Text = "Race/ Ethnicity";
            parentBox.Text = "Parent Level";
            lunchBox.Clear();
            testBox.Clear();
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleButton.Checked == true)
            {
                manager.filterBySex(file, "male");
            }
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            if(femaleButton.Checked == true)
            {
                manager.filterBySex(file, "female");
            }
        }

        private void etniBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (etniBox.Text.Equals("Race / Ethnicity")){ 
                //Limpiar Filtro
            }else {
                manager.filterByRace(file, etniBox.Text);
            }
        }

        private void parentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parentBox.Text.Equals("Parent Level"))
            {
                //Limpiar Filtro
            }
            else
            {
                manager.filterByPLevel(file, parentBox.Text);
            }
        }

        private void lunchBox_TextChanged(object sender, EventArgs e)
        {
            lunchBox.AutoCompleteCustomSource = loadLunchData();
            lunchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            lunchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            OK1.Enabled = true;
        }

        private AutoCompleteStringCollection loadLunchData()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.Add("standard");
            data.Add("free/reduced");

            return data;
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            manager.filterByLunch(file, lunchBox.Text);
        }

        private void testBox_TextChanged(object sender, EventArgs e)
        {
            testBox.AutoCompleteCustomSource = loadTestData();
            testBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            testBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            OK2.Enabled = true;
        }

        private AutoCompleteStringCollection loadTestData()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.Add("none");
            data.Add("completed");

            return data;
        }

        private void OK2_Click(object sender, EventArgs e)
        {
            manager.filterByTest(file, testBox.Text);
        }

        private void mathCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (mathCheck.Checked == true)
            {
                OK3.Enabled = true;
                minBox.Enabled = true;
                maxBox.Enabled = true;

                readingCheck.Checked = false;
                writingCheck.Checked = false;
            }
        }

        private void readingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (readingCheck.Checked == true)
            {
                OK3.Enabled = true;
                minBox.Enabled = true;
                maxBox.Enabled = true;

                mathCheck.Checked = false;
                writingCheck.Checked = false;
            }
        }

        private void writingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (writingCheck.Checked == true)
            {
                OK3.Enabled = true;
                minBox.Enabled = true;
                maxBox.Enabled = true;

                mathCheck.Checked = false;
                readingCheck.Checked = false;
            }
        }

        private void OK3_Click(object sender, EventArgs e)
        {
            try
            {
                if (mathCheck.Checked == true)
                {
                    manager.filterByScore(file, long.Parse(minBox.Text), long.Parse(maxBox.Text), 5);
                }
                else if (readingCheck.Checked == true)
                {
                    manager.filterByScore(file, long.Parse(minBox.Text), long.Parse(maxBox.Text), 6);
                }
                else
                {
                    manager.filterByScore(file, long.Parse(minBox.Text), long.Parse(maxBox.Text), 7);
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message + "\n" + "\n" + "*Solo valores numericos*");
            }
        }



        private void btn_arbol_propio_Click(object sender, EventArgs e)
        {
            if (!loadData1)
            {
                loadData.ShowDialog();
                string path = loadData.FileName;
                dataTraining1 = path;
                loadData1 = true;

                if (ImportFromCsvFile(path) != null)
                {
                    DataTable data = ImportFromCsvFile(path);
                    CreateTreeAndHandleUserOperation(data);
                }
            }
            else
            {
                DataTable data = ImportFromCsvFile(dataTraining1);
                CreateTreeAndHandleUserOperation(data);
            }
        }

        private void btn_arbol_libreria_Click(object sender, EventArgs e)
        {

            string variable1 = comboBoxVariable1.Text;
            string variable2 = comboBoxVariable2.Text;
            string variable3 = comboBoxVariable3.Text;

            if (variable1 == "" || variable2 == "" || variable3 == "")
            {
                MessageBox.Show("Agrega las 3 variables de entrada.", "Lo sentimos");
            }
            else
            {
                crear_arbol_libreria("No", variable1, variable2, variable3);
            }

        }

        public static DataTable ImportFromCsvFile(string filePath)
        {
            var rows = 0;
            var data = new DataTable();

            try
            {
                using (var reader = new System.IO.StreamReader(System.IO.File.OpenRead(filePath)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Substring(0, line.Length - 1).Split(',');

                        foreach (var item in values)
                        {
                            if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
                            {
                                throw new Exception("Value can't be empty");
                            }

                            if (rows == 0)
                            {
                                data.Columns.Add(item);
                            }
                        }

                        if (rows > 0)
                        {
                            data.Rows.Add(values);
                        }

                        rows++;

                        if (values.Length != data.Columns.Count)
                        {
                            throw new Exception("Row is shorter or longer than title row");
                        }
                    }
                }
                var differentValuesOfLastColumn = Model.Attribute.GetDifferentAttributeNamesOfColumn(data, data.Columns.Count - 1);

                if (differentValuesOfLastColumn.Count > 2)
                {
                    throw new Exception("The last column is the result column and can contain only 2 different values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data = null;
            }
            // Si no se ingresan filas o data == null retorna null¿
            return data?.Rows.Count > 0 ? data : null;
        }

        private static void CreateTreeAndHandleUserOperation(DataTable data)
        {
            var decisionTree = new Tree();
            decisionTree.Root = Tree.Learn(data, "");
            bool exit = false;

            MessageBox.Show("Arbol de decision creado","INFORMACION",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            do
            {
                var valuesForQuery = new Dictionary<string, string>();

                // Bucle para la entrada de datos para la consulta 
                for (var i = 0; i < data.Columns.Count - 1; i++)
                {
                    string entrada = Microsoft.VisualBasic.Interaction.InputBox("Si quieres ver el arbol escribe: PRINT" + "\nSi quiere salir del Arbol ingrese: END" + "\n" + "\nSi quiere realizar una prediccion:" + "\n" +  $"Ingrese el valor para  {data.Columns[i]}", "CONSULTA", "", 500, 300);
                    var input = entrada.TrimStart().TrimEnd();

                    if (input.ToUpper().Equals("PRINT"))
                    {
                        //MessageBox.Show(Tree.Print(decisionTree.Root, decisionTree.Root.Name.ToUpper()));
                        PrintTree pt = new PrintTree(Tree.Print(decisionTree.Root, decisionTree.Root.Name.ToUpper()));
                        pt.ShowDialog();

                        i--;
                        
                    }else if (input.ToUpper().Equals("END"))
                    {
                        exit = true;
                        i = data.Columns.Count;
                    }
                    else
                    {
                        valuesForQuery.Add(data.Columns[i].ToString(), input);
                    }
                    
                }
                if (!exit)
                {
                    var result = Tree.CalculateResult(decisionTree.Root, valuesForQuery, "");

                    if (result.Contains("Atributo no encontrado"))
                    {
                        MessageBox.Show("No se puede calcular el resultado. No se encontró una ruta válida a través del árbol.", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(Tree.PrintResult(null, result), "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            } while (!exit) ;
        }

        private void crear_arbol_libreria(String path, string variable1, string variable2, String variable3)
        { 
            //DataManager dataTesting = new DataManager();
            //dataTesting.createTable(path);
            //DataTable dataset = dataTesting.GetDataTable();

            //DataTable dataset = dividir_datatable(0, manager.GetDataTable());
            DataTable dataset = manager.GetDataTable().Copy();
            var codebook = new Codification(dataset);

            // Translate our training data into integer symbols using our codebook:
            DataTable symbols = codebook.Apply(dataset);
            int[][] inputs = symbols.ToArray<int>("race/ethnicity", "lunch", "test preparation course");
            int[] outputs = symbols.ToArray<int>("pass exam");

            var id3learning = new ID3Learning()
            {
                new DecisionVariable("race/ethnicity",     5), // 3 possible values (group A, group B, group C, group D, group E)
                new DecisionVariable("lunch", 3), // 3 possible values (free/reduce,standard)  
                new DecisionVariable("test preparation course",    2), // 2 possible values (completed, none)    


            };

            // Learn the training instances!
            DecisionTree tree = id3learning.Learn(inputs, outputs);

            // Compute the training error when predicting training instances
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));
            labelErrorTesting.Text =error + "";
            MessageBox.Show("El árbol ya aprendió con los datos de entrenamiento.", "Training Data");


            // The tree can now be queried for new examples through 
            // its decide method. For example, we can create a query

            int[] query = codebook.Transform(new[,]
            {
                { "race/ethnicity",                variable1  },
                { "lunch",                        variable2  },
                { "test preparation course",    variable3   }
            });

            // And then predict the label using
            int predicted = tree.Decide(query);  // result will be 0

            // We can translate it back to strings using
            string answer = codebook.Revert("pass exam", predicted); // Answer will be: "No"

            MessageBox.Show("La predicción para las variables "+variable1+" - "+variable2+" - "+variable3+" es:\n"+answer, "Predicción");
            //Console.WriteLine(answer);
        }

        private DataTable dividir_datatable(int conjunto, DataTable dataT)
        {
          
            DataTable aRetornar = dataT.Copy();

            if (conjunto == 0) //Testing
            {
                int limit = 300;
                for (int i = dataT.Rows.Count; i>limit; i--)
                {
                    aRetornar.Rows.RemoveAt(i);
                }
            }
            else
            {
                for (int i = 0; (i > 700) && (i<1000); i++)
                {
                    aRetornar.Rows.RemoveAt(i);
                }
            }
            return aRetornar;
        }
    }
}
