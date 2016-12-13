namespace Student
{
    partial class FormStudent
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelNstud = new System.Windows.Forms.Label();
            this.labelKurs = new System.Windows.Forms.Label();
            this.labelGruppa = new System.Windows.Forms.Label();
            this.labelBudget = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxNstud = new System.Windows.Forms.TextBox();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.textGruppa = new System.Windows.Forms.TextBox();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.radioButtonCommerce = new System.Windows.Forms.RadioButton();
            this.textBoxStudentInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.groupBoxOzenki = new System.Windows.Forms.GroupBox();
            this.checkBoxEkz5neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz4neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz3neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz2neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz1neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz5 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz4 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz3 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz2 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownEkz5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz1 = new System.Windows.Forms.NumericUpDown();
            this.buttonNaSledKurs = new System.Windows.Forms.Button();
            this.labelStoimost = new System.Windows.Forms.Label();
            this.numericUpDownStoimost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.buttonOplatit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            this.groupBoxOzenki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStoimost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(27, 46);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // labelNstud
            // 
            this.labelNstud.AutoSize = true;
            this.labelNstud.Location = new System.Drawing.Point(27, 80);
            this.labelNstud.Name = "labelNstud";
            this.labelNstud.Size = new System.Drawing.Size(133, 13);
            this.labelNstud.TabIndex = 1;
            this.labelNstud.Text = "№ студенческого билета";
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Location = new System.Drawing.Point(274, 80);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(31, 13);
            this.labelKurs.TabIndex = 2;
            this.labelKurs.Text = "Курс";
            // 
            // labelGruppa
            // 
            this.labelGruppa.AutoSize = true;
            this.labelGruppa.Location = new System.Drawing.Point(370, 80);
            this.labelGruppa.Name = "labelGruppa";
            this.labelGruppa.Size = new System.Drawing.Size(41, 13);
            this.labelGruppa.TabIndex = 3;
            this.labelGruppa.Text = "группа";
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Location = new System.Drawing.Point(30, 144);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(75, 13);
            this.labelBudget.TabIndex = 4;
            this.labelBudget.Text = "Обучается на";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(69, 43);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(380, 20);
            this.textBoxFIO.TabIndex = 5;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // textBoxNstud
            // 
            this.textBoxNstud.Location = new System.Drawing.Point(166, 77);
            this.textBoxNstud.MaxLength = 6;
            this.textBoxNstud.Name = "textBoxNstud";
            this.textBoxNstud.Size = new System.Drawing.Size(59, 20);
            this.textBoxNstud.TabIndex = 6;
            this.textBoxNstud.Text = "000000";
            this.textBoxNstud.TextChanged += new System.EventHandler(this.textBoxNstud_TextChanged);
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Location = new System.Drawing.Point(311, 77);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownKurs.TabIndex = 7;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.ValueChanged += new System.EventHandler(this.numericUpDownKurs_ValueChanged);
            // 
            // textGruppa
            // 
            this.textGruppa.Location = new System.Drawing.Point(417, 80);
            this.textGruppa.Name = "textGruppa";
            this.textGruppa.Size = new System.Drawing.Size(100, 20);
            this.textGruppa.TabIndex = 8;
            this.textGruppa.TextChanged += new System.EventHandler(this.textGruppa_TextChanged);
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Checked = true;
            this.radioButtonBudget.Location = new System.Drawing.Point(166, 144);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(121, 17);
            this.radioButtonBudget.TabIndex = 9;
            this.radioButtonBudget.TabStop = true;
            this.radioButtonBudget.Text = "бюджетной основе";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            this.radioButtonBudget.CheckedChanged += new System.EventHandler(this.radioButtonBudget_CheckedChanged);
            // 
            // radioButtonCommerce
            // 
            this.radioButtonCommerce.AutoSize = true;
            this.radioButtonCommerce.Location = new System.Drawing.Point(166, 168);
            this.radioButtonCommerce.Name = "radioButtonCommerce";
            this.radioButtonCommerce.Size = new System.Drawing.Size(139, 17);
            this.radioButtonCommerce.TabIndex = 10;
            this.radioButtonCommerce.Text = "коммерческой основе";
            this.radioButtonCommerce.UseVisualStyleBackColor = true;
            // 
            // textBoxStudentInfo
            // 
            this.textBoxStudentInfo.Location = new System.Drawing.Point(12, 401);
            this.textBoxStudentInfo.Multiline = true;
            this.textBoxStudentInfo.Name = "textBoxStudentInfo";
            this.textBoxStudentInfo.ReadOnly = true;
            this.textBoxStudentInfo.Size = new System.Drawing.Size(489, 141);
            this.textBoxStudentInfo.TabIndex = 11;
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Items.AddRange(new object[] {
            "1 семестр",
            "2 семестр"});
            this.comboBoxSemestr.Location = new System.Drawing.Point(3, 14);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemestr.TabIndex = 12;
            this.comboBoxSemestr.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemestr_SelectedIndexChanged);
            // 
            // groupBoxOzenki
            // 
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz5neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz4neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz3neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz2neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz1neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz5);
            this.groupBoxOzenki.Controls.Add(this.comboBoxSemestr);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz4);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz3);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz2);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz1);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz5);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz4);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz3);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz2);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz1);
            this.groupBoxOzenki.Location = new System.Drawing.Point(30, 238);
            this.groupBoxOzenki.Name = "groupBoxOzenki";
            this.groupBoxOzenki.Size = new System.Drawing.Size(434, 133);
            this.groupBoxOzenki.TabIndex = 13;
            this.groupBoxOzenki.TabStop = false;
            this.groupBoxOzenki.Text = "Оценки за экзамены";
            // 
            // checkBoxEkz5neyavka
            // 
            this.checkBoxEkz5neyavka.AutoSize = true;
            this.checkBoxEkz5neyavka.Location = new System.Drawing.Point(343, 100);
            this.checkBoxEkz5neyavka.Name = "checkBoxEkz5neyavka";
            this.checkBoxEkz5neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz5neyavka.TabIndex = 19;
            this.checkBoxEkz5neyavka.Text = "неявка";
            this.checkBoxEkz5neyavka.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz4neyavka
            // 
            this.checkBoxEkz4neyavka.AutoSize = true;
            this.checkBoxEkz4neyavka.Location = new System.Drawing.Point(263, 100);
            this.checkBoxEkz4neyavka.Name = "checkBoxEkz4neyavka";
            this.checkBoxEkz4neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz4neyavka.TabIndex = 18;
            this.checkBoxEkz4neyavka.Text = "неявка";
            this.checkBoxEkz4neyavka.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz3neyavka
            // 
            this.checkBoxEkz3neyavka.AutoSize = true;
            this.checkBoxEkz3neyavka.Location = new System.Drawing.Point(177, 100);
            this.checkBoxEkz3neyavka.Name = "checkBoxEkz3neyavka";
            this.checkBoxEkz3neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz3neyavka.TabIndex = 17;
            this.checkBoxEkz3neyavka.Text = "неявка";
            this.checkBoxEkz3neyavka.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz2neyavka
            // 
            this.checkBoxEkz2neyavka.AutoSize = true;
            this.checkBoxEkz2neyavka.Location = new System.Drawing.Point(93, 100);
            this.checkBoxEkz2neyavka.Name = "checkBoxEkz2neyavka";
            this.checkBoxEkz2neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz2neyavka.TabIndex = 16;
            this.checkBoxEkz2neyavka.Text = "неявка";
            this.checkBoxEkz2neyavka.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz1neyavka
            // 
            this.checkBoxEkz1neyavka.AutoSize = true;
            this.checkBoxEkz1neyavka.Location = new System.Drawing.Point(6, 100);
            this.checkBoxEkz1neyavka.Name = "checkBoxEkz1neyavka";
            this.checkBoxEkz1neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz1neyavka.TabIndex = 15;
            this.checkBoxEkz1neyavka.Text = "неявка";
            this.checkBoxEkz1neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz1neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz1neyavka_CheckedChanged);
            // 
            // checkBoxEkz5
            // 
            this.checkBoxEkz5.AutoSize = true;
            this.checkBoxEkz5.Checked = true;
            this.checkBoxEkz5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz5.Location = new System.Drawing.Point(354, 41);
            this.checkBoxEkz5.Name = "checkBoxEkz5";
            this.checkBoxEkz5.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEkz5.TabIndex = 14;
            this.checkBoxEkz5.Text = "Экзамен 5";
            this.checkBoxEkz5.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz4
            // 
            this.checkBoxEkz4.AutoSize = true;
            this.checkBoxEkz4.Checked = true;
            this.checkBoxEkz4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz4.Location = new System.Drawing.Point(263, 41);
            this.checkBoxEkz4.Name = "checkBoxEkz4";
            this.checkBoxEkz4.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEkz4.TabIndex = 13;
            this.checkBoxEkz4.Text = "Экзамен 4";
            this.checkBoxEkz4.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz3
            // 
            this.checkBoxEkz3.AutoSize = true;
            this.checkBoxEkz3.Checked = true;
            this.checkBoxEkz3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz3.Location = new System.Drawing.Point(177, 41);
            this.checkBoxEkz3.Name = "checkBoxEkz3";
            this.checkBoxEkz3.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEkz3.TabIndex = 12;
            this.checkBoxEkz3.Text = "Экзамен 3";
            this.checkBoxEkz3.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz2
            // 
            this.checkBoxEkz2.AutoSize = true;
            this.checkBoxEkz2.Checked = true;
            this.checkBoxEkz2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz2.Location = new System.Drawing.Point(93, 41);
            this.checkBoxEkz2.Name = "checkBoxEkz2";
            this.checkBoxEkz2.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEkz2.TabIndex = 11;
            this.checkBoxEkz2.Text = "Экзамен 2";
            this.checkBoxEkz2.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkz1
            // 
            this.checkBoxEkz1.AutoSize = true;
            this.checkBoxEkz1.Checked = true;
            this.checkBoxEkz1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz1.Location = new System.Drawing.Point(7, 41);
            this.checkBoxEkz1.Name = "checkBoxEkz1";
            this.checkBoxEkz1.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEkz1.TabIndex = 10;
            this.checkBoxEkz1.Text = "Экзамен 1";
            this.checkBoxEkz1.UseVisualStyleBackColor = true;
            this.checkBoxEkz1.CheckedChanged += new System.EventHandler(this.checkBoxEkz1_CheckedChanged);
            // 
            // numericUpDownEkz5
            // 
            this.numericUpDownEkz5.Location = new System.Drawing.Point(348, 64);
            this.numericUpDownEkz5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz5.Name = "numericUpDownEkz5";
            this.numericUpDownEkz5.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownEkz5.TabIndex = 9;
            // 
            // numericUpDownEkz4
            // 
            this.numericUpDownEkz4.Location = new System.Drawing.Point(277, 64);
            this.numericUpDownEkz4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz4.Name = "numericUpDownEkz4";
            this.numericUpDownEkz4.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownEkz4.TabIndex = 8;
            // 
            // numericUpDownEkz3
            // 
            this.numericUpDownEkz3.Location = new System.Drawing.Point(186, 64);
            this.numericUpDownEkz3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz3.Name = "numericUpDownEkz3";
            this.numericUpDownEkz3.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownEkz3.TabIndex = 7;
            // 
            // numericUpDownEkz2
            // 
            this.numericUpDownEkz2.Location = new System.Drawing.Point(105, 64);
            this.numericUpDownEkz2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz2.Name = "numericUpDownEkz2";
            this.numericUpDownEkz2.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownEkz2.TabIndex = 6;
            this.numericUpDownEkz2.ValueChanged += new System.EventHandler(this.numericUpDownEkz2_ValueChanged);
            // 
            // numericUpDownEkz1
            // 
            this.numericUpDownEkz1.Location = new System.Drawing.Point(7, 64);
            this.numericUpDownEkz1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz1.Name = "numericUpDownEkz1";
            this.numericUpDownEkz1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownEkz1.TabIndex = 5;
            this.numericUpDownEkz1.ValueChanged += new System.EventHandler(this.numericUpDownEkz1_ValueChanged);
            // 
            // buttonNaSledKurs
            // 
            this.buttonNaSledKurs.Location = new System.Drawing.Point(13, 557);
            this.buttonNaSledKurs.Name = "buttonNaSledKurs";
            this.buttonNaSledKurs.Size = new System.Drawing.Size(104, 38);
            this.buttonNaSledKurs.TabIndex = 14;
            this.buttonNaSledKurs.Text = "Перевести на след.курс";
            this.buttonNaSledKurs.UseVisualStyleBackColor = true;
            this.buttonNaSledKurs.Click += new System.EventHandler(this.buttonNaSledKurs_Click);
            // 
            // labelStoimost
            // 
            this.labelStoimost.AutoSize = true;
            this.labelStoimost.Location = new System.Drawing.Point(327, 139);
            this.labelStoimost.Name = "labelStoimost";
            this.labelStoimost.Size = new System.Drawing.Size(111, 13);
            this.labelStoimost.TabIndex = 15;
            this.labelStoimost.Text = "Стоимость обучения";
            this.labelStoimost.Visible = false;
            // 
            // numericUpDownStoimost
            // 
            this.numericUpDownStoimost.DecimalPlaces = 2;
            this.numericUpDownStoimost.Location = new System.Drawing.Point(452, 137);
            this.numericUpDownStoimost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStoimost.Name = "numericUpDownStoimost";
            this.numericUpDownStoimost.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownStoimost.TabIndex = 16;
            this.numericUpDownStoimost.Visible = false;
            this.numericUpDownStoimost.ValueChanged += new System.EventHandler(this.numericUpDownStoimost_ValueChanged);
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.DecimalPlaces = 2;
            this.numericUpDownSum.Location = new System.Drawing.Point(452, 171);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownSum.TabIndex = 17;
            this.numericUpDownSum.Visible = false;
            // 
            // buttonOplatit
            // 
            this.buttonOplatit.Location = new System.Drawing.Point(363, 168);
            this.buttonOplatit.Name = "buttonOplatit";
            this.buttonOplatit.Size = new System.Drawing.Size(75, 23);
            this.buttonOplatit.TabIndex = 18;
            this.buttonOplatit.Text = "Оплатить";
            this.buttonOplatit.UseVisualStyleBackColor = true;
            this.buttonOplatit.Visible = false;
            this.buttonOplatit.Click += new System.EventHandler(this.buttonOplatit_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 592);
            this.Controls.Add(this.buttonOplatit);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.numericUpDownStoimost);
            this.Controls.Add(this.labelStoimost);
            this.Controls.Add(this.buttonNaSledKurs);
            this.Controls.Add(this.groupBoxOzenki);
            this.Controls.Add(this.textBoxStudentInfo);
            this.Controls.Add(this.radioButtonCommerce);
            this.Controls.Add(this.radioButtonBudget);
            this.Controls.Add(this.textGruppa);
            this.Controls.Add(this.numericUpDownKurs);
            this.Controls.Add(this.textBoxNstud);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.labelGruppa);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.labelNstud);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormStudent";
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            this.groupBoxOzenki.ResumeLayout(false);
            this.groupBoxOzenki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStoimost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelNstud;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.Label labelGruppa;
        private System.Windows.Forms.Label labelBudget;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxNstud;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.TextBox textGruppa;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.RadioButton radioButtonCommerce;
        private System.Windows.Forms.TextBox textBoxStudentInfo;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.GroupBox groupBoxOzenki;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz5;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz4;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz3;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz2;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz1;
        private System.Windows.Forms.CheckBox checkBoxEkz5neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz4neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz3neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz2neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz1neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz5;
        private System.Windows.Forms.CheckBox checkBoxEkz4;
        private System.Windows.Forms.CheckBox checkBoxEkz3;
        private System.Windows.Forms.CheckBox checkBoxEkz2;
        private System.Windows.Forms.CheckBox checkBoxEkz1;
        private System.Windows.Forms.Button buttonNaSledKurs;
        private System.Windows.Forms.Label labelStoimost;
        private System.Windows.Forms.NumericUpDown numericUpDownStoimost;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.Button buttonOplatit;
    }
}

