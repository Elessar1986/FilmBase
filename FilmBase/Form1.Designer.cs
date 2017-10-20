namespace FilmBase
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
            this.FilmsView = new System.Windows.Forms.ListView();
            this.FilmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.comboBox_director = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label_filmname = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_rate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmsView
            // 
            this.FilmsView.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FilmsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilmName,
            this.Genre,
            this.Year,
            this.Director,
            this.Rating});
            this.FilmsView.Font = new System.Drawing.Font("HelveticaNeueCyr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsView.FullRowSelect = true;
            this.FilmsView.Location = new System.Drawing.Point(15, 61);
            this.FilmsView.MultiSelect = false;
            this.FilmsView.Name = "FilmsView";
            this.FilmsView.Size = new System.Drawing.Size(676, 274);
            this.FilmsView.TabIndex = 0;
            this.FilmsView.UseCompatibleStateImageBehavior = false;
            this.FilmsView.View = System.Windows.Forms.View.Details;
            this.FilmsView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.FilmsView_ColumnClick);
            this.FilmsView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FilmsView_MouseClick);
            // 
            // FilmName
            // 
            this.FilmName.Text = "Название";
            this.FilmName.Width = 280;
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            this.Genre.Width = 105;
            // 
            // Year
            // 
            this.Year.Text = "Год";
            this.Year.Width = 73;
            // 
            // Director
            // 
            this.Director.Text = "Режиссер";
            this.Director.Width = 145;
            // 
            // Rating
            // 
            this.Rating.Text = "Рейтинг";
            this.Rating.Width = 69;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_genre.Enabled = false;
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(296, 36);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(105, 20);
            this.comboBox_genre.TabIndex = 1;
            this.comboBox_genre.SelectionChangeCommitted += new System.EventHandler(this.comboBox_genre_SelectionChangeCommitted);
            // 
            // comboBox_director
            // 
            this.comboBox_director.Enabled = false;
            this.comboBox_director.FormattingEnabled = true;
            this.comboBox_director.Location = new System.Drawing.Point(476, 36);
            this.comboBox_director.Name = "comboBox_director";
            this.comboBox_director.Size = new System.Drawing.Size(147, 20);
            this.comboBox_director.TabIndex = 3;
            this.comboBox_director.SelectionChangeCommitted += new System.EventHandler(this.comboBox_director_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(402, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(73, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить фильм";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Рейтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Год";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Режисер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Жанр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "по жанру";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сортировать:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(401, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "по году";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(476, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 16);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "по режиссеру";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label_filmname
            // 
            this.label_filmname.AutoSize = true;
            this.label_filmname.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_filmname.Location = new System.Drawing.Point(253, 349);
            this.label_filmname.Name = "label_filmname";
            this.label_filmname.Size = new System.Drawing.Size(44, 17);
            this.label_filmname.TabIndex = 17;
            this.label_filmname.Text = "none";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_genre.Location = new System.Drawing.Point(253, 374);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(44, 17);
            this.label_genre.TabIndex = 17;
            this.label_genre.Text = "none";
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_director.Location = new System.Drawing.Point(254, 397);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(44, 17);
            this.label_director.TabIndex = 17;
            this.label_director.Text = "none";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_year.Location = new System.Drawing.Point(254, 420);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(44, 17);
            this.label_year.TabIndex = 17;
            this.label_year.Text = "none";
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rate.Location = new System.Drawing.Point(253, 445);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(44, 17);
            this.label_rate.TabIndex = 17;
            this.label_rate.Text = "none";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("HelveticaNeueCyr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(256, 472);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(435, 91);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(703, 569);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_filmname);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_director);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.FilmsView);
            this.Font = new System.Drawing.Font("HelveticaNeueCyr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FilmsView;
        private System.Windows.Forms.ColumnHeader FilmName;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.ComboBox comboBox_director;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label_filmname;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.TextBox textBox1;
    }
}

