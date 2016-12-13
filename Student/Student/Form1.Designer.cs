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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
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
            this.textBoxStudentInfo.Location = new System.Drawing.Point(12, 256);
            this.textBoxStudentInfo.Multiline = true;
            this.textBoxStudentInfo.Name = "textBoxStudentInfo";
            this.textBoxStudentInfo.ReadOnly = true;
            this.textBoxStudentInfo.Size = new System.Drawing.Size(489, 179);
            this.textBoxStudentInfo.TabIndex = 11;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 447);
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
    }
}

