using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FormStudent : Form
    {
        Student student1 = new Student();//обхект класса студент
        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text;//сохраняем фио
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text;//сохраняем номер студ.билета
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void textGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = textGruppa.Text;//сохраняем номер группы
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value;//сохраняем номер группы
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked; //сохраняем Б или К
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }
    }
}
