
namespace Sport_progect
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Insert_sport = new System.Windows.Forms.Button();
            this.Table_sport = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Delete_refery = new System.Windows.Forms.Button();
            this.Delete_people = new System.Windows.Forms.Button();
            this.Insert_refery = new System.Windows.Forms.Button();
            this.Delete_man = new System.Windows.Forms.Button();
            this.Update_people = new System.Windows.Forms.Button();
            this.Update_man = new System.Windows.Forms.Button();
            this.Insert_people = new System.Windows.Forms.Button();
            this.Insert_man = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete_sport = new System.Windows.Forms.Button();
            this.l_sport_all = new System.Windows.Forms.Label();
            this.Update_sport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.otchet = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p_people = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idUr = new System.Windows.Forms.Label();
            this.acces = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p_refery = new System.Windows.Forms.Panel();
            this.p_man = new System.Windows.Forms.Panel();
            this.p_sport = new System.Windows.Forms.Panel();
            this.l_refery = new System.Windows.Forms.Label();
            this.l_sport_man = new System.Windows.Forms.Label();
            this.l_people = new System.Windows.Forms.Label();
            this.l_sport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Table_sport)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert_sport
            // 
            this.Insert_sport.BackColor = System.Drawing.Color.PaleGreen;
            this.Insert_sport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_sport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_sport.Location = new System.Drawing.Point(3, 3);
            this.Insert_sport.Name = "Insert_sport";
            this.Insert_sport.Size = new System.Drawing.Size(154, 41);
            this.Insert_sport.TabIndex = 1;
            this.Insert_sport.Text = "ДОБАВИТЬ";
            this.Insert_sport.UseVisualStyleBackColor = false;
            this.Insert_sport.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table_sport
            // 
            this.Table_sport.AllowUserToAddRows = false;
            this.Table_sport.AllowUserToDeleteRows = false;
            this.Table_sport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Table_sport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_sport.BackgroundColor = System.Drawing.Color.White;
            this.Table_sport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table_sport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_sport.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table_sport.Location = new System.Drawing.Point(19, 47);
            this.Table_sport.Name = "Table_sport";
            this.Table_sport.ReadOnly = true;
            this.Table_sport.RowHeadersVisible = false;
            this.Table_sport.RowHeadersWidth = 51;
            this.Table_sport.RowTemplate.Height = 24;
            this.Table_sport.Size = new System.Drawing.Size(886, 430);
            this.Table_sport.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Delete_refery);
            this.panel3.Controls.Add(this.Delete_people);
            this.panel3.Controls.Add(this.Insert_refery);
            this.panel3.Controls.Add(this.Delete_man);
            this.panel3.Controls.Add(this.Update_people);
            this.panel3.Controls.Add(this.Update_man);
            this.panel3.Controls.Add(this.Insert_people);
            this.panel3.Controls.Add(this.Insert_man);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Delete_sport);
            this.panel3.Controls.Add(this.l_sport_all);
            this.panel3.Controls.Add(this.Update_sport);
            this.panel3.Controls.Add(this.Insert_sport);
            this.panel3.Controls.Add(this.Table_sport);
            this.panel3.Location = new System.Drawing.Point(307, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 488);
            this.panel3.TabIndex = 5;
            // 
            // Delete_refery
            // 
            this.Delete_refery.BackColor = System.Drawing.Color.Red;
            this.Delete_refery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_refery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_refery.ForeColor = System.Drawing.Color.White;
            this.Delete_refery.Location = new System.Drawing.Point(758, 3);
            this.Delete_refery.Name = "Delete_refery";
            this.Delete_refery.Size = new System.Drawing.Size(132, 41);
            this.Delete_refery.TabIndex = 10;
            this.Delete_refery.Text = "УДАЛИТЬ";
            this.Delete_refery.UseVisualStyleBackColor = false;
            this.Delete_refery.Visible = false;
            this.Delete_refery.Click += new System.EventHandler(this.Delete_refery_Click);
            // 
            // Delete_people
            // 
            this.Delete_people.BackColor = System.Drawing.Color.Red;
            this.Delete_people.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_people.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_people.ForeColor = System.Drawing.Color.White;
            this.Delete_people.Location = new System.Drawing.Point(758, 3);
            this.Delete_people.Name = "Delete_people";
            this.Delete_people.Size = new System.Drawing.Size(132, 41);
            this.Delete_people.TabIndex = 10;
            this.Delete_people.Text = "УДАЛИТЬ";
            this.Delete_people.UseVisualStyleBackColor = false;
            this.Delete_people.Visible = false;
            this.Delete_people.Click += new System.EventHandler(this.Delete_people_Click);
            // 
            // Insert_refery
            // 
            this.Insert_refery.BackColor = System.Drawing.Color.PaleGreen;
            this.Insert_refery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_refery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_refery.Location = new System.Drawing.Point(3, 3);
            this.Insert_refery.Name = "Insert_refery";
            this.Insert_refery.Size = new System.Drawing.Size(154, 41);
            this.Insert_refery.TabIndex = 8;
            this.Insert_refery.Text = "ДОБАВИТЬ";
            this.Insert_refery.UseVisualStyleBackColor = false;
            this.Insert_refery.Visible = false;
            this.Insert_refery.Click += new System.EventHandler(this.Insert_refery_Click);
            // 
            // Delete_man
            // 
            this.Delete_man.BackColor = System.Drawing.Color.Red;
            this.Delete_man.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_man.ForeColor = System.Drawing.Color.White;
            this.Delete_man.Location = new System.Drawing.Point(758, 3);
            this.Delete_man.Name = "Delete_man";
            this.Delete_man.Size = new System.Drawing.Size(132, 41);
            this.Delete_man.TabIndex = 10;
            this.Delete_man.Text = "УДАЛИТЬ";
            this.Delete_man.UseVisualStyleBackColor = false;
            this.Delete_man.Visible = false;
            this.Delete_man.Click += new System.EventHandler(this.Delete_man_Click);
            // 
            // Update_people
            // 
            this.Update_people.BackColor = System.Drawing.Color.PaleGreen;
            this.Update_people.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_people.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_people.Location = new System.Drawing.Point(202, 3);
            this.Update_people.Name = "Update_people";
            this.Update_people.Size = new System.Drawing.Size(154, 41);
            this.Update_people.TabIndex = 9;
            this.Update_people.Text = "ИЗМЕНИТЬ";
            this.Update_people.UseVisualStyleBackColor = false;
            this.Update_people.Visible = false;
            this.Update_people.Click += new System.EventHandler(this.Update_people_Click);
            // 
            // Update_man
            // 
            this.Update_man.BackColor = System.Drawing.Color.PaleGreen;
            this.Update_man.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_man.Location = new System.Drawing.Point(202, 3);
            this.Update_man.Name = "Update_man";
            this.Update_man.Size = new System.Drawing.Size(154, 41);
            this.Update_man.TabIndex = 9;
            this.Update_man.Text = "ИЗМЕНИТЬ";
            this.Update_man.UseVisualStyleBackColor = false;
            this.Update_man.Visible = false;
            this.Update_man.Click += new System.EventHandler(this.Update_man_Click);
            // 
            // Insert_people
            // 
            this.Insert_people.BackColor = System.Drawing.Color.PaleGreen;
            this.Insert_people.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_people.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_people.Location = new System.Drawing.Point(3, 3);
            this.Insert_people.Name = "Insert_people";
            this.Insert_people.Size = new System.Drawing.Size(154, 41);
            this.Insert_people.TabIndex = 8;
            this.Insert_people.Text = "ДОБАВИТЬ";
            this.Insert_people.UseVisualStyleBackColor = false;
            this.Insert_people.Visible = false;
            this.Insert_people.Click += new System.EventHandler(this.Insert_people_Click);
            // 
            // Insert_man
            // 
            this.Insert_man.BackColor = System.Drawing.Color.PaleGreen;
            this.Insert_man.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_man.Location = new System.Drawing.Point(3, 3);
            this.Insert_man.Name = "Insert_man";
            this.Insert_man.Size = new System.Drawing.Size(154, 41);
            this.Insert_man.TabIndex = 8;
            this.Insert_man.Text = "ДОБАВИТЬ";
            this.Insert_man.UseVisualStyleBackColor = false;
            this.Insert_man.Visible = false;
            this.Insert_man.Click += new System.EventHandler(this.Insert_man_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Delete_sport
            // 
            this.Delete_sport.BackColor = System.Drawing.Color.Red;
            this.Delete_sport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_sport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_sport.ForeColor = System.Drawing.Color.White;
            this.Delete_sport.Location = new System.Drawing.Point(758, 3);
            this.Delete_sport.Name = "Delete_sport";
            this.Delete_sport.Size = new System.Drawing.Size(132, 41);
            this.Delete_sport.TabIndex = 5;
            this.Delete_sport.Text = "УДАЛИТЬ";
            this.Delete_sport.UseVisualStyleBackColor = false;
            this.Delete_sport.Click += new System.EventHandler(this.button3_Click);
            // 
            // l_sport_all
            // 
            this.l_sport_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_sport_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_sport_all.ForeColor = System.Drawing.Color.Black;
            this.l_sport_all.Location = new System.Drawing.Point(377, 12);
            this.l_sport_all.Name = "l_sport_all";
            this.l_sport_all.Size = new System.Drawing.Size(262, 32);
            this.l_sport_all.TabIndex = 6;
            this.l_sport_all.Text = "См. Участников";
            this.l_sport_all.Click += new System.EventHandler(this.l_sport_all_Click);
            // 
            // Update_sport
            // 
            this.Update_sport.BackColor = System.Drawing.Color.PaleGreen;
            this.Update_sport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_sport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_sport.Location = new System.Drawing.Point(202, 3);
            this.Update_sport.Name = "Update_sport";
            this.Update_sport.Size = new System.Drawing.Size(154, 41);
            this.Update_sport.TabIndex = 4;
            this.Update_sport.Text = "ИЗМЕНИТЬ";
            this.Update_sport.UseVisualStyleBackColor = false;
            this.Update_sport.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1179, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Спортивные мероприятия на територии ВУЗа";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.otchet);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 99);
            this.panel1.TabIndex = 3;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1144, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // otchet
            // 
            this.otchet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.otchet.FlatAppearance.BorderSize = 0;
            this.otchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchet.ForeColor = System.Drawing.Color.Cyan;
            this.otchet.Location = new System.Drawing.Point(840, 60);
            this.otchet.Name = "otchet";
            this.otchet.Size = new System.Drawing.Size(373, 36);
            this.otchet.TabIndex = 9;
            this.otchet.Text = "Вывести отчёт за период";
            this.otchet.UseVisualStyleBackColor = false;
            this.otchet.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(34)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.p_people);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.p_refery);
            this.panel2.Controls.Add(this.p_man);
            this.panel2.Controls.Add(this.p_sport);
            this.panel2.Controls.Add(this.l_refery);
            this.panel2.Controls.Add(this.l_sport_man);
            this.panel2.Controls.Add(this.l_people);
            this.panel2.Controls.Add(this.l_sport);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 566);
            this.panel2.TabIndex = 4;
            // 
            // p_people
            // 
            this.p_people.BackColor = System.Drawing.Color.White;
            this.p_people.Location = new System.Drawing.Point(20, 141);
            this.p_people.Name = "p_people";
            this.p_people.Size = new System.Drawing.Size(205, 3);
            this.p_people.TabIndex = 5;
            this.p_people.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.idUr);
            this.panel4.Controls.Add(this.acces);
            this.panel4.Controls.Add(this.NameUser);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 68);
            this.panel4.TabIndex = 8;
            // 
            // idUr
            // 
            this.idUr.AutoSize = true;
            this.idUr.Location = new System.Drawing.Point(221, 3);
            this.idUr.Name = "idUr";
            this.idUr.Size = new System.Drawing.Size(20, 16);
            this.idUr.TabIndex = 1;
            this.idUr.Text = "ID";
            this.idUr.Visible = false;
            // 
            // acces
            // 
            this.acces.AutoSize = true;
            this.acces.Location = new System.Drawing.Point(3, 0);
            this.acces.Name = "acces";
            this.acces.Size = new System.Drawing.Size(45, 16);
            this.acces.TabIndex = 3;
            this.acces.Text = "Acces";
            this.acces.Visible = false;
            // 
            // NameUser
            // 
            this.NameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameUser.Location = new System.Drawing.Point(0, 0);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(248, 68);
            this.NameUser.TabIndex = 6;
            this.NameUser.Text = "Hello [User]";
            this.NameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // p_refery
            // 
            this.p_refery.BackColor = System.Drawing.Color.White;
            this.p_refery.Location = new System.Drawing.Point(20, 339);
            this.p_refery.Name = "p_refery";
            this.p_refery.Size = new System.Drawing.Size(205, 3);
            this.p_refery.TabIndex = 5;
            this.p_refery.Visible = false;
            // 
            // p_man
            // 
            this.p_man.BackColor = System.Drawing.Color.White;
            this.p_man.Location = new System.Drawing.Point(20, 275);
            this.p_man.Name = "p_man";
            this.p_man.Size = new System.Drawing.Size(205, 3);
            this.p_man.TabIndex = 5;
            this.p_man.Visible = false;
            // 
            // p_sport
            // 
            this.p_sport.BackColor = System.Drawing.Color.White;
            this.p_sport.Location = new System.Drawing.Point(20, 208);
            this.p_sport.Name = "p_sport";
            this.p_sport.Size = new System.Drawing.Size(205, 3);
            this.p_sport.TabIndex = 4;
            // 
            // l_refery
            // 
            this.l_refery.Cursor = System.Windows.Forms.Cursors.Default;
            this.l_refery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_refery.ForeColor = System.Drawing.Color.White;
            this.l_refery.Location = new System.Drawing.Point(20, 304);
            this.l_refery.Name = "l_refery";
            this.l_refery.Size = new System.Drawing.Size(205, 32);
            this.l_refery.TabIndex = 3;
            this.l_refery.Text = "Жюри";
            this.l_refery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_refery.Click += new System.EventHandler(this.l_refery_Click);
            // 
            // l_sport_man
            // 
            this.l_sport_man.Cursor = System.Windows.Forms.Cursors.Default;
            this.l_sport_man.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_sport_man.ForeColor = System.Drawing.Color.White;
            this.l_sport_man.Location = new System.Drawing.Point(20, 243);
            this.l_sport_man.Name = "l_sport_man";
            this.l_sport_man.Size = new System.Drawing.Size(221, 32);
            this.l_sport_man.TabIndex = 3;
            this.l_sport_man.Text = "СПОРТСМЕНЫ";
            this.l_sport_man.Click += new System.EventHandler(this.l_sport_man_Click);
            // 
            // l_people
            // 
            this.l_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_people.ForeColor = System.Drawing.Color.White;
            this.l_people.Location = new System.Drawing.Point(20, 102);
            this.l_people.Name = "l_people";
            this.l_people.Size = new System.Drawing.Size(205, 36);
            this.l_people.TabIndex = 2;
            this.l_people.Text = "УЧАСТНИКИ";
            this.l_people.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_people.Click += new System.EventHandler(this.I_people_Click);
            // 
            // l_sport
            // 
            this.l_sport.Enabled = false;
            this.l_sport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_sport.ForeColor = System.Drawing.Color.White;
            this.l_sport.Location = new System.Drawing.Point(12, 175);
            this.l_sport.Name = "l_sport";
            this.l_sport.Size = new System.Drawing.Size(239, 36);
            this.l_sport.TabIndex = 2;
            this.l_sport.Text = "МЕРОПРИЯТИЯ";
            this.l_sport.Click += new System.EventHandler(this.l_sport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(3, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выход из учётной записи";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.panel1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Table_sport)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Insert_sport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Update_sport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView Table_sport;
        private System.Windows.Forms.Button Delete_sport;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label idUr;
        private System.Windows.Forms.Label l_sport_all;
        private System.Windows.Forms.Panel p_man;
        private System.Windows.Forms.Panel p_sport;
        private System.Windows.Forms.Label l_sport_man;
        private System.Windows.Forms.Label l_sport;
        public System.Windows.Forms.Label NameUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete_man;
        private System.Windows.Forms.Button Update_man;
        private System.Windows.Forms.Button Insert_man;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label acces;
        private System.Windows.Forms.Button otchet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label l_people;
        private System.Windows.Forms.Panel p_people;
        private System.Windows.Forms.Button Delete_people;
        private System.Windows.Forms.Button Update_people;
        private System.Windows.Forms.Button Insert_people;
        private System.Windows.Forms.Panel p_refery;
        private System.Windows.Forms.Label l_refery;
        private System.Windows.Forms.Button Insert_refery;
        private System.Windows.Forms.Button Delete_refery;
    }
}

