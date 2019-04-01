namespace Lab_2_OOTP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSwear = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBuilding = new System.Windows.Forms.TextBox();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.comboBoxProfession = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonBinary = new System.Windows.Forms.RadioButton();
            this.radioButtonXml = new System.Windows.Forms.RadioButton();
            this.radioButtonFree = new System.Windows.Forms.RadioButton();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnDateOfBirth,
            this.ColumnAddress});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(420, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Фамилия";
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.ReadOnly = true;
            // 
            // ColumnDateOfBirth
            // 
            this.ColumnDateOfBirth.HeaderText = "Дата";
            this.ColumnDateOfBirth.Name = "ColumnDateOfBirth";
            this.ColumnDateOfBirth.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(206, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить работника";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(447, 165);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(206, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить работника";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(228, 362);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(206, 30);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Подтвердить изменения";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя:*";
            // 
            // checkBoxSwear
            // 
            this.checkBoxSwear.AutoSize = true;
            this.checkBoxSwear.Location = new System.Drawing.Point(283, 287);
            this.checkBoxSwear.Name = "checkBoxSwear";
            this.checkBoxSwear.Size = new System.Drawing.Size(144, 17);
            this.checkBoxSwear.TabIndex = 5;
            this.checkBoxSwear.Text = "Матерится как Рамзи?";
            this.checkBoxSwear.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 180);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(115, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 219);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(115, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия:*";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 297);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(115, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата рождения:*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Телефон:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Зарплата:*";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(12, 336);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(115, 20);
            this.textBoxSalary.TabIndex = 14;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Улица:*";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(148, 219);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(115, 20);
            this.textBoxStreet.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Город:*";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(148, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(115, 20);
            this.textBoxCity.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Квартира:";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(148, 297);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(115, 20);
            this.textBoxFlat.TabIndex = 22;
            this.textBoxFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuilding_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дом:*";
            // 
            // textBoxBuilding
            // 
            this.textBoxBuilding.Location = new System.Drawing.Point(148, 258);
            this.textBoxBuilding.Name = "textBoxBuilding";
            this.textBoxBuilding.Size = new System.Drawing.Size(115, 20);
            this.textBoxBuilding.TabIndex = 20;
            this.textBoxBuilding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuilding_KeyPress);
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(278, 242);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(102, 13);
            this.labelSecond.TabIndex = 27;
            this.labelSecond.Text = "Обслужено людей:";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(278, 203);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(50, 13);
            this.labelFirst.TabIndex = 25;
            this.labelFirst.Text = "Чаевые:";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(281, 258);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(153, 20);
            this.textBoxSecond.TabIndex = 24;
            // 
            // comboBoxProfession
            // 
            this.comboBoxProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfession.FormattingEnabled = true;
            this.comboBoxProfession.Items.AddRange(new object[] {
            "Не уточнено",
            "Официант",
            "Менеджер",
            "Повар",
            "Шеф-повар"});
            this.comboBoxProfession.Location = new System.Drawing.Point(281, 179);
            this.comboBoxProfession.Name = "comboBoxProfession";
            this.comboBoxProfession.Size = new System.Drawing.Size(151, 21);
            this.comboBoxProfession.TabIndex = 28;
            this.comboBoxProfession.Tag = "";
            this.comboBoxProfession.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfession_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Должность:";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(447, 12);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(206, 147);
            this.listBoxInfo.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuilding_KeyPress);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(447, 201);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(206, 30);
            this.buttonClear.TabIndex = 32;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonBinary
            // 
            this.radioButtonBinary.AutoSize = true;
            this.radioButtonBinary.Checked = true;
            this.radioButtonBinary.Location = new System.Drawing.Point(447, 259);
            this.radioButtonBinary.Name = "radioButtonBinary";
            this.radioButtonBinary.Size = new System.Drawing.Size(73, 17);
            this.radioButtonBinary.TabIndex = 33;
            this.radioButtonBinary.TabStop = true;
            this.radioButtonBinary.Text = "бинарная";
            this.radioButtonBinary.UseVisualStyleBackColor = true;
            // 
            // radioButtonXml
            // 
            this.radioButtonXml.AutoSize = true;
            this.radioButtonXml.Location = new System.Drawing.Point(447, 281);
            this.radioButtonXml.Name = "radioButtonXml";
            this.radioButtonXml.Size = new System.Drawing.Size(47, 17);
            this.radioButtonXml.TabIndex = 34;
            this.radioButtonXml.Text = "XML";
            this.radioButtonXml.UseVisualStyleBackColor = true;
            // 
            // radioButtonFree
            // 
            this.radioButtonFree.AutoSize = true;
            this.radioButtonFree.Location = new System.Drawing.Point(447, 303);
            this.radioButtonFree.Name = "radioButtonFree";
            this.radioButtonFree.Size = new System.Drawing.Size(97, 17);
            this.radioButtonFree.TabIndex = 35;
            this.radioButtonFree.Text = "произвольная";
            this.radioButtonFree.UseVisualStyleBackColor = true;
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(447, 326);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(206, 30);
            this.buttonSerialize.TabIndex = 36;
            this.buttonSerialize.Text = "Сериализовать";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Вид сериализации:";
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(447, 362);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(206, 30);
            this.buttonDeserialize.TabIndex = 38;
            this.buttonDeserialize.Text = "Загрузить";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 404);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.radioButtonFree);
            this.Controls.Add(this.radioButtonXml);
            this.Controls.Add(this.radioButtonBinary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxProfession);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxBuilding);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.checkBoxSwear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSwear;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBuilding;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.ComboBox comboBoxProfession;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonBinary;
        private System.Windows.Forms.RadioButton radioButtonXml;
        private System.Windows.Forms.RadioButton radioButtonFree;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDeserialize;
    }
}

