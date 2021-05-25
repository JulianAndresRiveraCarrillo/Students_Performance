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

        }

        private void btn_arbol_libreria_Click(object sender, EventArgs e)
        {
            /*loadData.ShowDialog();
            string path = loadData.FileName;
            file = path;*/
            string variable1 = comboBoxVariable1.Text;
            string variable2 = comboBoxVariable2.Text;
            string variable3 = comboBoxVariable3.Text;

            if(variable1==""|| variable2=="" || variable3=="")
            {
                MessageBox.Show("Agrega las 3 variables de entrada.", "Lo sentimos");
            }else if (manager.GetDataTable().Rows.Count==0)
            {
                MessageBox.Show("Agrega la base de datos", "Lo sentimos");
            }
            else
            {
                crear_arbol_libreria("path", variable1, variable2,variable3);
            }

        }


        private void crear_arbol_libreria(String path, string variable1, string variable2, String variable3)
        {


            /*DataManager dataTesting = new DataManager();
            dataTesting.createTable("Student_Performance/Data/exams_training.csv");
            DataTable dataset = dataTesting.GetDataTable();*/

            //DataTable dataset = dividir_datatable(0, manager.GetDataTable());
            DataTable dataset = manager.GetDataTable().Copy();
            var codebook = new Codification(dataset);

            // Translate our training data into integer symbols using our codebook:
            DataTable symbols = codebook.Apply(dataset);
            int[][] inputs = symbols.ToArray<int>("race/ethnicity", "lunch", "test preparation course");
            int[] outputs = symbols.ToArray<int>("output");

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
            string answer = codebook.Revert("output", predicted); // Answer will be: "No"

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorTesting_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
