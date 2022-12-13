using Student.Entity;
using Student.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainManager.Instance.Init();
        }

        private void Init_Click(object sender, EventArgs e)
        {
            MainManager.Instance.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox4.Text);
            Student.Model.Student s = (Student.Model.Student)MainManager.Instance.studentsList[key];
            textBox1.Text = s.Name;
            textBox2.Text = s.Address;
            textBox3.Text = s.Age.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Student.Model.Student s = new Student.Model.Student(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text));
            MainManager.Instance.studentsList.Add(Convert.ToInt32(textBox4.Text), s);
            MainManager.Instance.addStudentToDB(s);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
    }
}
