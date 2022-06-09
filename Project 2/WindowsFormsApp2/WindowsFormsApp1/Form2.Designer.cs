namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnfile = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(391, 100);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(82, 24);
            this.btnfile.TabIndex = 29;
            this.btnfile.Text = "Create File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(391, 25);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(82, 24);
            this.btnfolder.TabIndex = 28;
            this.btnfolder.Text = "Create Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(294, 263);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(82, 24);
            this.btnread.TabIndex = 27;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(135, 263);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(82, 24);
            this.btnwrite.TabIndex = 26;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(175, 184);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(131, 20);
            this.txtlocation.TabIndex = 25;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(175, 100);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(131, 20);
            this.txtname.TabIndex = 24;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(175, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 20);
            this.txtId.TabIndex = 23;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(33, 181);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 13);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Dept Location";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(33, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Dept Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(33, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Enter Dept Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnfile;
        internal System.Windows.Forms.Button btnfolder;
        internal System.Windows.Forms.Button btnread;
        internal System.Windows.Forms.Button btnwrite;
        internal System.Windows.Forms.TextBox txtlocation;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}