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
{
    public partial class journalForm : Form
    {
        public Journal journal = new Journal();
        private string fileName = " Journal.data";
        public journalForm()
        {
            InitializeComponent();
            listViewGroups.View = View.List;
        }

        private void journalForm_Load(object sender, EventArgs e)
        {
            this.journal = Journal.GetFromLocalFile(this.fileName);
            //this.journal = Journal.GetTestJournal();

            RedRawGroups();
        }

        private void listViewGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RedRawGroups()
        {
            listViewGroups.Items.Clear();

            foreach (Group group in this.journal.groups)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = group.name;
                listViewGroups.Items.Add(listViewItem);


            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewGroups.SelectedItems.Count <= 0)
                return;

            string selectedItemName = listViewGroups.SelectedItems[0].Text;
            for (int i = 0; i < journal.groups.Count; i++)
            {
                if (journal.groups[i].name == selectedItemName)

                {
                    journal.groups.Remove(journal.groups[i]);
                }
            }
            MessageBox.Show("Delete");
            RedRawGroups();
        }   

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewGroups.SelectedItems.Count <= 0)
                return;

            int groupIndex = listViewGroups.SelectedItems[0].Index;
            Group group = this.journal.groups[groupIndex];

            GroupForm groupForm = new GroupForm(group);
            groupForm.ShowDialog();
            RedRawGroups();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newGroupName = textBoxAdd.Text;
            Group newGroup = new Group();
            newGroup.name = newGroupName;
            this.journal.groups.Add(newGroup);
            textBoxAdd.Text = "";
            MessageBox.Show("Successfully");
            RedRawGroups();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Journal.SaveTolocalFile(this.journal, this.fileName);
            MessageBox.Show("Successfully");
        }
    }
}
