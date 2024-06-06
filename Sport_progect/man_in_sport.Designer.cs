
namespace Sport_progect
{
    partial class man_in_sport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(man_in_sport));
            this.Id_sport = new System.Windows.Forms.Label();
            this.DGV_man = new System.Windows.Forms.DataGridView();
            this.DGV_not_man = new System.Windows.Forms.DataGridView();
            this.Add_man = new System.Windows.Forms.Button();
            this.Del_man = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.TextBox();
            this.DGV_ref = new System.Windows.Forms.DataGridView();
            this.DGV_not_ref = new System.Windows.Forms.DataGridView();
            this.ADD_ref = new System.Windows.Forms.Button();
            this.Del_ref = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.find_ref = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_not_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_not_ref)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_sport
            // 
            this.Id_sport.AutoSize = true;
            this.Id_sport.Location = new System.Drawing.Point(9, 6);
            this.Id_sport.Name = "Id_sport";
            this.Id_sport.Size = new System.Drawing.Size(20, 16);
            this.Id_sport.TabIndex = 2;
            this.Id_sport.Text = "ID";
            this.Id_sport.Visible = false;
            // 
            // DGV_man
            // 
            this.DGV_man.AllowUserToAddRows = false;
            this.DGV_man.AllowUserToDeleteRows = false;
            this.DGV_man.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_man.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_man.BackgroundColor = System.Drawing.Color.White;
            this.DGV_man.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_man.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_man.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_man.Location = new System.Drawing.Point(12, 52);
            this.DGV_man.Name = "DGV_man";
            this.DGV_man.ReadOnly = true;
            this.DGV_man.RowHeadersVisible = false;
            this.DGV_man.RowHeadersWidth = 51;
            this.DGV_man.RowTemplate.Height = 24;
            this.DGV_man.Size = new System.Drawing.Size(573, 281);
            this.DGV_man.TabIndex = 3;
            // 
            // DGV_not_man
            // 
            this.DGV_not_man.AllowUserToAddRows = false;
            this.DGV_not_man.AllowUserToDeleteRows = false;
            this.DGV_not_man.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_not_man.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_not_man.BackgroundColor = System.Drawing.Color.White;
            this.DGV_not_man.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_not_man.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_not_man.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_not_man.Location = new System.Drawing.Point(750, 52);
            this.DGV_not_man.Name = "DGV_not_man";
            this.DGV_not_man.ReadOnly = true;
            this.DGV_not_man.RowHeadersVisible = false;
            this.DGV_not_man.RowHeadersWidth = 51;
            this.DGV_not_man.RowTemplate.Height = 24;
            this.DGV_not_man.Size = new System.Drawing.Size(558, 281);
            this.DGV_not_man.TabIndex = 4;
            // 
            // Add_man
            // 
            this.Add_man.BackColor = System.Drawing.Color.Chartreuse;
            this.Add_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_man.Location = new System.Drawing.Point(619, 94);
            this.Add_man.Name = "Add_man";
            this.Add_man.Size = new System.Drawing.Size(93, 61);
            this.Add_man.TabIndex = 5;
            this.Add_man.Text = "<<";
            this.Add_man.UseVisualStyleBackColor = false;
            this.Add_man.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_man
            // 
            this.Del_man.BackColor = System.Drawing.Color.Red;
            this.Del_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_man.Location = new System.Drawing.Point(619, 236);
            this.Del_man.Name = "Del_man";
            this.Del_man.Size = new System.Drawing.Size(93, 61);
            this.Del_man.TabIndex = 6;
            this.Del_man.Text = ">>";
            this.Del_man.UseVisualStyleBackColor = false;
            this.Del_man.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Записанные спортсмены:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(743, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Все спортсмены:";
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(1036, 12);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(254, 34);
            this.find.TabIndex = 9;
            this.find.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGV_ref
            // 
            this.DGV_ref.AllowUserToAddRows = false;
            this.DGV_ref.AllowUserToDeleteRows = false;
            this.DGV_ref.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_ref.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ref.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ref.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ref.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_ref.Location = new System.Drawing.Point(12, 396);
            this.DGV_ref.Name = "DGV_ref";
            this.DGV_ref.ReadOnly = true;
            this.DGV_ref.RowHeadersVisible = false;
            this.DGV_ref.RowHeadersWidth = 51;
            this.DGV_ref.RowTemplate.Height = 24;
            this.DGV_ref.Size = new System.Drawing.Size(573, 281);
            this.DGV_ref.TabIndex = 3;
            // 
            // DGV_not_ref
            // 
            this.DGV_not_ref.AllowUserToAddRows = false;
            this.DGV_not_ref.AllowUserToDeleteRows = false;
            this.DGV_not_ref.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_not_ref.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_not_ref.BackgroundColor = System.Drawing.Color.White;
            this.DGV_not_ref.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_not_ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_not_ref.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_not_ref.Location = new System.Drawing.Point(750, 396);
            this.DGV_not_ref.Name = "DGV_not_ref";
            this.DGV_not_ref.ReadOnly = true;
            this.DGV_not_ref.RowHeadersVisible = false;
            this.DGV_not_ref.RowHeadersWidth = 51;
            this.DGV_not_ref.RowTemplate.Height = 24;
            this.DGV_not_ref.Size = new System.Drawing.Size(558, 281);
            this.DGV_not_ref.TabIndex = 4;
            // 
            // ADD_ref
            // 
            this.ADD_ref.BackColor = System.Drawing.Color.Chartreuse;
            this.ADD_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_ref.Location = new System.Drawing.Point(619, 438);
            this.ADD_ref.Name = "ADD_ref";
            this.ADD_ref.Size = new System.Drawing.Size(93, 61);
            this.ADD_ref.TabIndex = 5;
            this.ADD_ref.Text = "<<";
            this.ADD_ref.UseVisualStyleBackColor = false;
            this.ADD_ref.Click += new System.EventHandler(this.ADD_ref_Click);
            // 
            // Del_ref
            // 
            this.Del_ref.BackColor = System.Drawing.Color.Red;
            this.Del_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_ref.Location = new System.Drawing.Point(619, 580);
            this.Del_ref.Name = "Del_ref";
            this.Del_ref.Size = new System.Drawing.Size(93, 61);
            this.Del_ref.TabIndex = 6;
            this.Del_ref.Text = ">>";
            this.Del_ref.UseVisualStyleBackColor = false;
            this.Del_ref.Click += new System.EventHandler(this.Del_ref_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(743, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Все жюри:";
            // 
            // find_ref
            // 
            this.find_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_ref.Location = new System.Drawing.Point(1036, 360);
            this.find_ref.Name = "find_ref";
            this.find_ref.Size = new System.Drawing.Size(254, 34);
            this.find_ref.TabIndex = 9;
            this.find_ref.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Записанные жюри:\r\n";
            // 
            // man_in_sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 735);
            this.Controls.Add(this.find_ref);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del_ref);
            this.Controls.Add(this.ADD_ref);
            this.Controls.Add(this.Del_man);
            this.Controls.Add(this.Add_man);
            this.Controls.Add(this.DGV_not_ref);
            this.Controls.Add(this.DGV_not_man);
            this.Controls.Add(this.DGV_ref);
            this.Controls.Add(this.DGV_man);
            this.Controls.Add(this.Id_sport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "man_in_sport";
            this.Text = "man_in_sport";
            this.Load += new System.EventHandler(this.man_in_sport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_not_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_not_ref)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Id_sport;
        public System.Windows.Forms.DataGridView DGV_man;
        public System.Windows.Forms.DataGridView DGV_not_man;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox find;
        public System.Windows.Forms.Button Add_man;
        public System.Windows.Forms.Button Del_man;
        public System.Windows.Forms.DataGridView DGV_ref;
        public System.Windows.Forms.DataGridView DGV_not_ref;
        public System.Windows.Forms.Button ADD_ref;
        public System.Windows.Forms.Button Del_ref;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox find_ref;
        private System.Windows.Forms.Label label4;
    }
}