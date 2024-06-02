
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(man_in_sport));
            this.Id_sport = new System.Windows.Forms.Label();
            this.Table_man_sport = new System.Windows.Forms.DataGridView();
            this.Table_man = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table_man_sport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_man)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_sport
            // 
            this.Id_sport.AutoSize = true;
            this.Id_sport.Location = new System.Drawing.Point(9, 6);
            this.Id_sport.Name = "Id_sport";
            this.Id_sport.Size = new System.Drawing.Size(21, 17);
            this.Id_sport.TabIndex = 2;
            this.Id_sport.Text = "ID";
            this.Id_sport.Visible = false;
            // 
            // Table_man_sport
            // 
            this.Table_man_sport.AllowUserToAddRows = false;
            this.Table_man_sport.AllowUserToDeleteRows = false;
            this.Table_man_sport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Table_man_sport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_man_sport.BackgroundColor = System.Drawing.Color.White;
            this.Table_man_sport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table_man_sport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_man_sport.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table_man_sport.Location = new System.Drawing.Point(12, 51);
            this.Table_man_sport.Name = "Table_man_sport";
            this.Table_man_sport.ReadOnly = true;
            this.Table_man_sport.RowHeadersVisible = false;
            this.Table_man_sport.RowHeadersWidth = 51;
            this.Table_man_sport.RowTemplate.Height = 24;
            this.Table_man_sport.Size = new System.Drawing.Size(546, 387);
            this.Table_man_sport.TabIndex = 3;
            // 
            // Table_man
            // 
            this.Table_man.AllowUserToAddRows = false;
            this.Table_man.AllowUserToDeleteRows = false;
            this.Table_man.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Table_man.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_man.BackgroundColor = System.Drawing.Color.White;
            this.Table_man.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table_man.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_man.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table_man.Location = new System.Drawing.Point(712, 51);
            this.Table_man.Name = "Table_man";
            this.Table_man.ReadOnly = true;
            this.Table_man.RowHeadersVisible = false;
            this.Table_man.RowHeadersWidth = 51;
            this.Table_man.RowTemplate.Height = 24;
            this.Table_man.Size = new System.Drawing.Size(558, 387);
            this.Table_man.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(585, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(585, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Участники мероприятия:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(705, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Все спортсмены:";
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(998, 14);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(254, 34);
            this.find.TabIndex = 9;
            this.find.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // man_in_sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 464);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table_man);
            this.Controls.Add(this.Table_man_sport);
            this.Controls.Add(this.Id_sport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "man_in_sport";
            this.Text = "man_in_sport";
            this.Load += new System.EventHandler(this.man_in_sport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_man_sport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_man)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Id_sport;
        public System.Windows.Forms.DataGridView Table_man_sport;
        public System.Windows.Forms.DataGridView Table_man;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox find;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}