namespace FormFilm
{
    partial class FormNewActor
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbDateOfBirth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 114);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "FirstName";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(27, 174);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(56, 13);
            this.labelNationality.TabIndex = 2;
            this.labelNationality.Text = "Nationality";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(27, 241);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.labelDateOfBirth.TabIndex = 3;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(138, 55);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(209, 20);
            this.txtbName.TabIndex = 4;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(138, 114);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(209, 20);
            this.txtbFirstName.TabIndex = 5;
            // 
            // cmbNationality
            // 
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Location = new System.Drawing.Point(139, 171);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(209, 21);
            this.cmbNationality.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbDateOfBirth
            // 
            this.txtbDateOfBirth.Location = new System.Drawing.Point(139, 238);
            this.txtbDateOfBirth.Name = "txtbDateOfBirth";
            this.txtbDateOfBirth.Size = new System.Drawing.Size(209, 20);
            this.txtbDateOfBirth.TabIndex = 8;
            this.txtbDateOfBirth.Text = "dd/mm/yyyy";
            // 
            // FormNewActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 430);
            this.Controls.Add(this.txtbDateOfBirth);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbNationality);
            this.Controls.Add(this.txtbFirstName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelName);
            this.Name = "FormNewActor";
            this.Text = "NewActor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbDateOfBirth;
    }
}