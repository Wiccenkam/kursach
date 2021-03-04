using kursach.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{//Определение частичного класса StudentForm
    public partial class StudentForm : Form
    {
        private Student student = new Student();

        public StudentForm(Student student)
        {
            this.student = student;

            InitializeComponent();
            FillFormInput();
        }
        //метод указания полей на оценки/зачета обьекта student
        private void FillFormInput()
        {
          textBoxName.Text = this.student.name;

            numericUpDownProgramming.Value = this.student.ProgrammingExam;
            numericUpDownPhilosophy.Value = this.student.PhilosophyExam;
            numericUpDownPhysics.Value = this.student.PhysicsExam;
            numericUpDownPolitical.Value = this.student.PoliticalExam;
            numericUpDownEconomic.Value = this.student.EconomicExam;


            checkBoxObz.Checked = this.student.ObzCreditation;
            checkBoxEnglish.Checked = this.student.EnglishCreditation;
            checkBoxHistory.Checked = this.student.HistoryCreditation;
            checkBoxMath.Checked = this.student.MathCreditation;
            checkBoxPe.Checked = this.student.PeCreditation;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //метод сохранения измененных оценок 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.student.name = textBoxName.Text;

            this.student.ProgrammingExam = (short)numericUpDownProgramming.Value;
            this.student.PhilosophyExam = (short)numericUpDownPhilosophy.Value;
            this.student.PhysicsExam = (short)numericUpDownPhysics.Value;
            this.student.PoliticalExam = (short)numericUpDownPolitical.Value;
            this.student.EconomicExam = (short)numericUpDownEconomic.Value;


            this.student.ObzCreditation = checkBoxObz.Checked;
            this.student.EnglishCreditation = checkBoxEnglish.Checked;
            this.student.HistoryCreditation = checkBoxHistory.Checked;
            this.student.MathCreditation = checkBoxMath.Checked;
            this.student.PeCreditation = checkBoxPe.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Added");
        }
        //метод отмены изменений
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show("Changes Reverted");
            this.Close();
        }

        private void Programming_Click(object sender, EventArgs e)
        {

        }
    }
}
