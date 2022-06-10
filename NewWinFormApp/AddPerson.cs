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
    public partial class AddPerson : Form
    {
        private MainForm Parent;
        private bool Update = false;
        private int Index;

        public AddPerson(MainForm parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        public AddPerson(MainForm parent, string surname, string name, string middleName, string birthday, string post, int index)
        {
            InitializeComponent();
            Parent = parent;
            Surname.Text = surname;
            PersonName.Text = name;
            MiddleName.Text = middleName;
            Birthday.Text = birthday.Replace('/', '.');
            Post.Text = post;
            Index = index;
            Update = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand("INSERT INTO [Workers] (Surname, Name, Middle_Name, Birthday, Post) " +
                               "VALUES (@Surname, @Name, @Middle_Name, @Birthday, @Post)", DataBase.sqlConnection);

            DateTime birthday = DateTime.Parse(Birthday.Text);

            command.Parameters.AddWithValue("Surname", Surname.Text);
            command.Parameters.AddWithValue("Name", PersonName.Text);
            command.Parameters.AddWithValue("Middle_Name", MiddleName.Text);
            command.Parameters.AddWithValue("Birthday", $"{birthday.Month}/{birthday.Day}/{birthday.Year}");
            command.Parameters.AddWithValue("Post", Post.Text);

            if (Update)
                Parent.DeleteSelected(Index);
            Parent.ResetList();
            Parent.Show();
            
        }

       
    }
}
