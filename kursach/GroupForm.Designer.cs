namespace kursach.models
{
    partial class GroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaweName = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSortDesc = new System.Windows.Forms.Button();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.buttonSortAsk = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewStudents
            // 
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(12, 59);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(627, 361);
            this.listViewStudents.TabIndex = 0;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.SelectedIndexChanged += new System.EventHandler(this.listViewStudents_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(645, 59);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(143, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(627, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonSaweName
            // 
            this.buttonSaweName.Location = new System.Drawing.Point(645, 27);
            this.buttonSaweName.Name = "buttonSaweName";
            this.buttonSaweName.Size = new System.Drawing.Size(143, 23);
            this.buttonSaweName.TabIndex = 3;
            this.buttonSaweName.Text = "Save name";
            this.buttonSaweName.UseVisualStyleBackColor = true;
            this.buttonSaweName.Click += new System.EventHandler(this.buttonSaweNAme_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(645, 89);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(143, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxAdd);
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Location = new System.Drawing.Point(654, 158);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(134, 100);
            this.groupBoxAdd.TabIndex = 5;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "groupBoxAdd";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(11, 19);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd.TabIndex = 1;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 61);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSortDesc
            // 
            this.buttonSortDesc.Location = new System.Drawing.Point(4, 71);
            this.buttonSortDesc.Name = "buttonSortDesc";
            this.buttonSortDesc.Size = new System.Drawing.Size(134, 23);
            this.buttonSortDesc.TabIndex = 6;
            this.buttonSortDesc.Text = "Sort Name Desk";
            this.buttonSortDesc.UseVisualStyleBackColor = true;
            this.buttonSortDesc.Click += new System.EventHandler(this.buttonSortDesc_Click);
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.buttonSortAsk);
            this.groupBoxSort.Controls.Add(this.buttonSortDesc);
            this.groupBoxSort.Location = new System.Drawing.Point(654, 276);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(144, 100);
            this.groupBoxSort.TabIndex = 7;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "groupBoxSort";
            // 
            // buttonSortAsk
            // 
            this.buttonSortAsk.Location = new System.Drawing.Point(6, 33);
            this.buttonSortAsk.Name = "buttonSortAsk";
            this.buttonSortAsk.Size = new System.Drawing.Size(132, 23);
            this.buttonSortAsk.TabIndex = 7;
            this.buttonSortAsk.Text = "Sort Name Ask";
            this.buttonSortAsk.UseVisualStyleBackColor = true;
            this.buttonSortAsk.Click += new System.EventHandler(this.buttonSortAsk_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSaweName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewStudents);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSaweName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSortDesc;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button buttonSortAsk;
    }
}