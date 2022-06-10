
namespace NewWinFormApp
{
    partial class AddPerson
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
            this.AddLabel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.PersonName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AddLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddLabel
            // 
            this.AddLabel.Controls.Add(this.label5);
            this.AddLabel.Controls.Add(this.label4);
            this.AddLabel.Controls.Add(this.label3);
            this.AddLabel.Controls.Add(this.label2);
            this.AddLabel.Controls.Add(this.label1);
            this.AddLabel.Controls.Add(this.Add);
            this.AddLabel.Controls.Add(this.Post);
            this.AddLabel.Controls.Add(this.MiddleName);
            this.AddLabel.Controls.Add(this.Birthday);
            this.AddLabel.Controls.Add(this.PersonName);
            this.AddLabel.Controls.Add(this.Surname);
            this.AddLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddLabel.Location = new System.Drawing.Point(0, 0);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(416, 450);
            this.AddLabel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(116, 329);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(202, 83);
            this.Add.TabIndex = 5;
            this.Add.Text = "Сохранить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(185, 256);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(202, 26);
            this.Post.TabIndex = 4;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(185, 147);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(202, 26);
            this.MiddleName.TabIndex = 3;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(185, 201);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(202, 26);
            this.Birthday.TabIndex = 2;
            // 
            // PersonName
            // 
            this.PersonName.Location = new System.Drawing.Point(185, 86);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(202, 26);
            this.PersonName.TabIndex = 1;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(185, 27);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(202, 26);
            this.Surname.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.AddLabel);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.AddLabel.ResumeLayout(false);
            this.AddLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddLabel;
        private System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox Birthday;
        private System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Button Add;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}