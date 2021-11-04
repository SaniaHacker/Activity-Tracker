using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.TypeField.AutoSize = false;
            this.TypeField.Size = new Size(this.TypeField.Size.Width, 38);
            textBox1.Text = "Start time";
            textBox2.Text = "Finish time";
            DisField.Text = "Distance";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closelabel_MouseEnter(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.Yellow;
        }

        private void closelabel_MouseLeave(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.White;
        }
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }



        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void runlabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Start time")
            {
                MessageBox.Show("Add start time");
                return;
            }
            if (textBox2.Text == "Finish time")
            {
                MessageBox.Show("Add finish time");
                return;
            }
            if (DisField.Text == "Distance")
            {
                MessageBox.Show("Add distance");
                return;
            }
            if (TypeField.Text == "Select activity type")
            {
                MessageBox.Show("Please, select activity type");
                return;
            }


            ActivityDB db = new ActivityDB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `activity` (`Start time`, `Finish time`, `Distance`, `Type activity`) VALUES (@St, @Ft, @Dis, @Ta)", db.getConnection());

            command.Parameters.Add("@St", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Ft", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@Dis", MySqlDbType.VarChar).Value = DisField.Text;
            command.Parameters.Add("@Ta", MySqlDbType.VarChar).Value = TypeField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Activity was add");
            else
                MessageBox.Show("Activity was not add");

            db.closeConnection();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void DisField_Enter(object sender, EventArgs e)
        {
            DisField.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Start time";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Finish time";
            }
        }

        private void DisField_Leave(object sender, EventArgs e)
        {
            if (DisField.Text == "")
            {
                DisField.Text = "Distance";
            }
        }
    }
}
