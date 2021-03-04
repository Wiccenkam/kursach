using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.models
{//Определение частичного класса GroupForm
    public partial class GroupForm : Form
    {
        private Group group = new Group();

        public GroupForm()
        {
            InitializeComponent();
        }

        public GroupForm(Group group)
        {
            this.group = group;
            InitializeComponent();
            RedRawStudents();
        }
        //метод перезаписи стедентов 
        private void RedRawStudents()
        {
            listViewStudents.Items.Clear();

            foreach (Student students in this.group.students)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = students.name;
                listViewStudents.Items.Add(listViewItem);


            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            listViewStudents.View = View.List;
            textBoxName.Text = this.group.name;
        }
        //метод удаления студента из группы
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count <= 0)
                return;

            int studentIndex = listViewStudents.SelectedItems[0].Index;



            this.group.students.RemoveAt(studentIndex);

            MessageBox.Show("Delete");
            RedRawStudents();
        }
        //метод просмотра обьекта student
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewStudents.SelectedItems.Count <= 0)
                return;

            int studentIndex = listViewStudents.SelectedItems[0].Index;

            Debug.WriteLine(studentIndex);
            Debug.WriteLine(this.group.students.Count);

            Student student = this.group.students[studentIndex];
            StudentForm studentForm = new StudentForm(student);
            DialogResult result = studentForm.ShowDialog();

            if (result == DialogResult.OK);
            {
                RedRawStudents();
            }
        }
        //метод добавления студента в группу
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newStudentName = textBoxAdd.Text;

            Student newstudent = new Student();

            newstudent.name = newStudentName;

            this.group.students.Add(newstudent);
            textBoxAdd.Text = "";
            RedRawStudents();
            Message();
       }
        public void Message()
        {
            MessageBox.Show("Added");
               
                
                
        }
        //метод сохранения изменения имени группы
        private void buttonSaweNAme_Click(object sender, EventArgs e)
        {
            this.group.name = textBoxName.Text;
            MessageBox.Show("Name save!");
        }
        //методы сортировки
        private void buttonSortAsk_Click(object sender, EventArgs e)
        {
            sortStudentsAsk(this.group.students);
            RedRawStudents();
        }
        private void sortStudentsAsk(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count - i - 1; j++)
                {
                    if (string.CompareOrdinal(students[j].name, students[j + 1].name) > 0)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        private void buttonSortDesc_Click(object sender, EventArgs e)
        {
            sortStudentsDesk(this.group.students);
            RedRawStudents();
        }
        private void sortStudentsDesk(List<Student> students)
        {
            {
                for (int i = 0; i < students.Count; i++)
                {
                    for (int j = 0; j < students.Count - i - 1; j++)
                    {
                        if (string.CompareOrdinal(students[j].name, students[j + 1].name) < 0)
                        {
                            Student temp = students[j];
                            students[j] = students[j + 1];
                            students[j + 1] = temp;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
