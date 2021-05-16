using System;
using System.Data;
using System.Windows.Forms;
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
  
    }
}
