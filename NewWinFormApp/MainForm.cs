using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWinFormApp
{
    public partial class MainForm : Form
    {
        private List<string[]> rows;
        private List<string[]> fileredList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBase.ActivateConnection();
            DataBase.OpenConnection();

            ResetList();
        }

        private void RefreshList(List<string[]> rows)
        {
            listView1.Items.Clear();

            foreach (var row in rows)
                listView1.Items.Add(new ListViewItem(row));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Все";
            fileredList = rows.Where(x => x[0].ToLower().Substring(0, textBox1.Text.Length).Equals(textBox1.Text.ToLower()))
                              .ToList();

            RefreshList(fileredList);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    fileredList = rows.Where(x => x[4] == "Директор").ToList();
                    RefreshList(fileredList);
                    break;
                case 1:
                    fileredList = rows.Where(x => x[4] == "Руководитель подразделения").ToList();
                    RefreshList(fileredList);
                    break;
                case 2:
                    fileredList = rows.Where(x => x[4] == "Контролер").ToList();
                    RefreshList(fileredList);
                    break;
                case 3:
                    fileredList = rows.Where(x => x[4] == "Рабочий").ToList();
                    RefreshList(fileredList);
                    break;
                case 4:
                    fileredList = rows;
                    RefreshList(rows);
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var addPerson = new AddPerson(this);
            addPerson.Show();
        }

        public void ResetList()
        {
            SqlDataReader dataReader = null;

            rows = new List<string[]>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Surname, Name, Middle_Name, Birthday, Post FROM Workers", DataBase.sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    var row = new string[] {
                        Convert.ToString(dataReader["Surname"]),
                        Convert.ToString(dataReader["Name"]),
                        Convert.ToString(dataReader["Middle_Name"]),
                        Convert.ToString(dataReader["Birthday"]).Substring(0, 10),
                        Convert.ToString(dataReader["Post"])
                    };

                    rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }

            RefreshList(rows);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (listView1.SelectedItems.Count != 0)
            {
                var addPerson = new AddPerson(this, listView1.SelectedItems[0].SubItems[0].Text,
                                                    listView1.SelectedItems[0].SubItems[1].Text,
                                                    listView1.SelectedItems[0].SubItems[2].Text,
                                                    listView1.SelectedItems[0].SubItems[3].Text,
                                                    listView1.SelectedItems[0].SubItems[4].Text, listView1.SelectedItems[0].Index);
                addPerson.Show();
            }
            else
            {
                var addPerson = new AddPerson(this);
                addPerson.Show();
            }
        }

        public void DeleteSelected(int index)
        {
            listView1.Items[index].Remove();
        }

        private void listView1_SelectedIndexChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                foreach (ListViewItem r in listView1.SelectedItems)
                    r.Remove();

        }
    }
}
