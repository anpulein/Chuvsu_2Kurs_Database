namespace WindowsFormsDataBase
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.client_list = new System.Windows.Forms.DataGridView();
            this.code_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series_passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_del = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.TextBox();
            this.button_find = new System.Windows.Forms.Button();
            this.MessgaeInformation = new System.Windows.Forms.GroupBox();
            this.Inforamtion1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.MessgaeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuExit });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuExit
            // 
            this.menuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(54, 20);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // client_list
            // 
            this.client_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.code_client, this.first_name, this.surname, this.last_name, this.phone, this.address, this.series_passport, this.number_passport, this.address_passport, this.inn, this.bank_book });
            this.client_list.Location = new System.Drawing.Point(0, 56);
            this.client_list.Name = "client_list";
            this.client_list.Size = new System.Drawing.Size(645, 198);
            this.client_list.TabIndex = 1;
            // 
            // code_client
            // 
            this.code_client.HeaderText = "Код клиента";
            this.code_client.Name = "code_client";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "Фамилия";
            this.first_name.Name = "first_name";
            // 
            // surname
            // 
            this.surname.HeaderText = "Имя";
            this.surname.Name = "surname";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Отчество";
            this.last_name.Name = "last_name";
            // 
            // phone
            // 
            this.phone.HeaderText = "Номер телефона";
            this.phone.MaxInputLength = 10;
            this.phone.Name = "phone";
            // 
            // address
            // 
            this.address.HeaderText = "Адрес проживания";
            this.address.Name = "address";
            // 
            // series_passport
            // 
            this.series_passport.HeaderText = "Серия паспорта";
            this.series_passport.MaxInputLength = 6;
            this.series_passport.Name = "series_passport";
            // 
            // number_passport
            // 
            this.number_passport.HeaderText = "Номер паспорта";
            this.number_passport.MaxInputLength = 4;
            this.number_passport.Name = "number_passport";
            // 
            // address_passport
            // 
            this.address_passport.HeaderText = "Адрес регистрации";
            this.address_passport.Name = "address_passport";
            // 
            // inn
            // 
            this.inn.HeaderText = "ИНН";
            this.inn.MaxInputLength = 12;
            this.inn.Name = "inn";
            // 
            // bank_book
            // 
            this.bank_book.HeaderText = "Лицевой счет";
            this.bank_book.MaxInputLength = 12;
            this.bank_book.Name = "bank_book";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_del);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Location = new System.Drawing.Point(663, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Навигация";
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(33, 154);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(105, 29);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(33, 119);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(105, 29);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(33, 54);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(105, 29);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(33, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(105, 29);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // FullName
            // 
            this.FullName.AccessibleDescription = "";
            this.FullName.AccessibleName = "";
            this.FullName.Location = new System.Drawing.Point(12, 27);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(193, 20);
            this.FullName.TabIndex = 3;
            this.FullName.Tag = "";
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(211, 27);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(102, 20);
            this.button_find.TabIndex = 4;
            this.button_find.Text = "Поиск по ФИО";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // MessgaeInformation
            // 
            this.MessgaeInformation.Controls.Add(this.Inforamtion1);
            this.MessgaeInformation.Location = new System.Drawing.Point(29, 268);
            this.MessgaeInformation.Name = "MessgaeInformation";
            this.MessgaeInformation.Size = new System.Drawing.Size(468, 75);
            this.MessgaeInformation.TabIndex = 5;
            this.MessgaeInformation.TabStop = false;
            this.MessgaeInformation.Text = "Дополнительная информация";
            // 
            // Inforamtion1
            // 
            this.Inforamtion1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Inforamtion1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Inforamtion1.Location = new System.Drawing.Point(6, 19);
            this.Inforamtion1.Name = "Inforamtion1";
            this.Inforamtion1.ReadOnly = true;
            this.Inforamtion1.Size = new System.Drawing.Size(396, 20);
            this.Inforamtion1.TabIndex = 0;
            this.Inforamtion1.Text = "- При добавлении новых клиентов, поле \"Код клиента\" заполнять не нужно.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 355);
            this.Controls.Add(this.MessgaeInformation);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.client_list);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Список клиентов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.MessgaeInformation.ResumeLayout(false);
            this.MessgaeInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox Inforamtion1;
        private System.Windows.Forms.GroupBox MessgaeInformation;

        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Button button_find;

        private System.Windows.Forms.DataGridViewTextBoxColumn code_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn series_passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_del;

        private System.Windows.Forms.DataGridView client_list;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;

        #endregion
    }
}