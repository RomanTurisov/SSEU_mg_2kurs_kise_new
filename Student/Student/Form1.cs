using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FormStudent : Form
    {
        Student student1 = new Student();   //объект класса Студент
        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text; //сохранить ФИО
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text;   //сохранить № студбилета
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value;   //сохранить курс
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked;    //сохранить буджет/коммерческое
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        private void textBoxGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = textBoxGruppa.Text; //сохранить группу
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        //содержимое полей в виде текста
        public string ToString()
        {
            return "ФИО: " + student1.FIO + "\r\n" +
                "№ студбилета: " + student1.Nstud + "\r\n" +
                "Курс: " + student1.kurs + "\r\n" +
                "Группа: " + student1.gruppa + "\r\n" +
                (student1.budget ? "На бюджетной основе" : "На коммерческой основе");
        }
    }
}