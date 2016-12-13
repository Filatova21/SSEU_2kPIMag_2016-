namespace Student
{
    partial class FormStudent
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelNstud = new System.Windows.Forms.Label();
            this.textBoxNstud = new System.Windows.Forms.TextBox();
            this.labelKurs = new System.Windows.Forms.Label();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.labelGruppa = new System.Windows.Forms.Label();
            this.textBoxGruppa = new System.Windows.Forms.TextBox();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.labelBudget = new System.Windows.Forms.Label();
            this.radioButtonCommerce = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(38, 40);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(42, 17);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(105, 40);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(480, 22);
            this.textBoxFIO.TabIndex = 1;
            // 
            // labelNstud
            // 
            this.labelNstud.AutoSize = true;
            this.labelNstud.Location = new System.Drawing.Point(41, 79);
            this.labelNstud.Name = "labelNstud";
            this.labelNstud.Size = new System.Drawing.Size(173, 17);
            this.labelNstud.TabIndex = 2;
            this.labelNstud.Text = "№ студенческого билета";
            // 
            // textBoxNstud
            // 
            this.textBoxNstud.Location = new System.Drawing.Point(220, 76);
            this.textBoxNstud.MaxLength = 6;
            this.textBoxNstud.Name = "textBoxNstud";
            this.textBoxNstud.Size = new System.Drawing.Size(77, 22);
            this.textBoxNstud.TabIndex = 3;
            this.textBoxNstud.Text = "000000";
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Location = new System.Drawing.Point(316, 81);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(39, 17);
            this.labelKurs.TabIndex = 4;
            this.labelKurs.Text = "Курс";
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Location = new System.Drawing.Point(361, 77);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownKurs.TabIndex = 5;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGruppa
            // 
            this.labelGruppa.AutoSize = true;
            this.labelGruppa.Location = new System.Drawing.Point(444, 79);
            this.labelGruppa.Name = "labelGruppa";
            this.labelGruppa.Size = new System.Drawing.Size(55, 17);
            this.labelGruppa.TabIndex = 6;
            this.labelGruppa.Text = "Группа";
            // 
            // textBoxGruppa
            // 
            this.textBoxGruppa.Location = new System.Drawing.Point(502, 78);
            this.textBoxGruppa.Name = "textBoxGruppa";
            this.textBoxGruppa.Size = new System.Drawing.Size(100, 22);
            this.textBoxGruppa.TabIndex = 7;
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Checked = true;
            this.radioButtonBudget.Location = new System.Drawing.Point(189, 139);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(166, 21);
            this.radioButtonBudget.TabIndex = 8;
            this.radioButtonBudget.TabStop = true;
            this.radioButtonBudget.Text = "набюджетной основе";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Location = new System.Drawing.Point(44, 142);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(100, 17);
            this.labelBudget.TabIndex = 9;
            this.labelBudget.Text = "Обучается на";
            // 
            // radioButtonCommerce
            // 
            this.radioButtonCommerce.AutoSize = true;
            this.radioButtonCommerce.Location = new System.Drawing.Point(189, 167);
            this.radioButtonCommerce.Name = "radioButtonCommerce";
            this.radioButtonCommerce.Size = new System.Drawing.Size(171, 21);
            this.radioButtonCommerce.TabIndex = 10;
            this.radioButtonCommerce.Text = "коммерческой основе";
            this.radioButtonCommerce.UseVisualStyleBackColor = true;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 430);
            this.Controls.Add(this.radioButtonCommerce);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.radioButtonBudget);
            this.Controls.Add(this.textBoxGruppa);
            this.Controls.Add(this.labelGruppa);
            this.Controls.Add(this.numericUpDownKurs);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.textBoxNstud);
            this.Controls.Add(this.labelNstud);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormStudent";
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelNstud;
        private System.Windows.Forms.TextBox textBoxNstud;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.Label labelGruppa;
        private System.Windows.Forms.TextBox textBoxGruppa;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.Label labelBudget;
        private System.Windows.Forms.RadioButton radioButtonCommerce;

    }
}

