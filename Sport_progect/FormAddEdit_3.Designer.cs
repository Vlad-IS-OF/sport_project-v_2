namespace Sport_progect
{
    partial class FormAddEdit_3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Box_Dname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Lname = new System.Windows.Forms.TextBox();
            this.Box_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Box_Fname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 107);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Box_Dname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Box_Lname);
            this.panel2.Controls.Add(this.Box_id);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Box_Fname);
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 205);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Отчество:";
            // 
            // Box_Dname
            // 
            this.Box_Dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_Dname.Location = new System.Drawing.Point(206, 97);
            this.Box_Dname.Name = "Box_Dname";
            this.Box_Dname.Size = new System.Drawing.Size(455, 30);
            this.Box_Dname.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фамилия:";
            // 
            // Box_Lname
            // 
            this.Box_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_Lname.Location = new System.Drawing.Point(206, 61);
            this.Box_Lname.Name = "Box_Lname";
            this.Box_Lname.Size = new System.Drawing.Size(455, 30);
            this.Box_Lname.TabIndex = 22;
            // 
            // Box_id
            // 
            this.Box_id.Location = new System.Drawing.Point(3, 0);
            this.Box_id.Name = "Box_id";
            this.Box_id.Size = new System.Drawing.Size(100, 22);
            this.Box_id.TabIndex = 20;
            this.Box_id.Text = "ID";
            this.Box_id.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(365, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(166, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "ДОБАВИТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя:";
            // 
            // Box_Fname
            // 
            this.Box_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_Fname.Location = new System.Drawing.Point(206, 25);
            this.Box_Fname.Name = "Box_Fname";
            this.Box_Fname.Size = new System.Drawing.Size(455, 30);
            this.Box_Fname.TabIndex = 5;
            // 
            // FormAddEdit_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAddEdit_3";
            this.Text = "FormAddEdit_3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Box_Dname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Box_Lname;
        public System.Windows.Forms.TextBox Box_id;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Box_Fname;
    }
}