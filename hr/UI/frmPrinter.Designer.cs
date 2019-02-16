namespace hr.UI
{
    partial class frmPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinter));
            this.btnSup = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFurnizor = new System.Windows.Forms.TextBox();
            this.txtPracticPreg = new System.Windows.Forms.TextBox();
            this.txtThPreg = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtStudyLevel = new System.Windows.Forms.TextBox();
            this.txtLegalBase = new System.Windows.Forms.TextBox();
            this.txtCalif = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.txtCOR = new System.Windows.Forms.TextBox();
            this.txtCalifications = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(12, 12);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(75, 23);
            this.btnSup.TabIndex = 0;
            this.btnSup.Text = "Suppliments";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(129, 12);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(75, 23);
            this.btnExam.TabIndex = 1;
            this.btnExam.Text = "Exams";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(40, 103);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 21);
            this.cmbBox.TabIndex = 3;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(733, 272);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(165, 272);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(29, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::hr.Properties.Resources.fata;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtFurnizor);
            this.panel1.Controls.Add(this.txtPracticPreg);
            this.panel1.Controls.Add(this.txtThPreg);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.txtStudyLevel);
            this.panel1.Controls.Add(this.txtLegalBase);
            this.panel1.Controls.Add(this.txtCalif);
            this.panel1.Controls.Add(this.txtMarks);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.txtCOD);
            this.panel1.Controls.Add(this.txtCOR);
            this.panel1.Controls.Add(this.txtCalifications);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtSeries);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Location = new System.Drawing.Point(227, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 561);
            this.panel1.TabIndex = 2;
            // 
            // txtFurnizor
            // 
            this.txtFurnizor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFurnizor.Location = new System.Drawing.Point(211, 271);
            this.txtFurnizor.Name = "txtFurnizor";
            this.txtFurnizor.Size = new System.Drawing.Size(80, 13);
            this.txtFurnizor.TabIndex = 16;
            // 
            // txtPracticPreg
            // 
            this.txtPracticPreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPracticPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPracticPreg.Location = new System.Drawing.Point(334, 508);
            this.txtPracticPreg.Name = "txtPracticPreg";
            this.txtPracticPreg.Size = new System.Drawing.Size(25, 13);
            this.txtPracticPreg.TabIndex = 15;
            // 
            // txtThPreg
            // 
            this.txtThPreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtThPreg.Location = new System.Drawing.Point(380, 502);
            this.txtThPreg.Name = "txtThPreg";
            this.txtThPreg.Size = new System.Drawing.Size(20, 13);
            this.txtThPreg.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTotal.Location = new System.Drawing.Point(297, 489);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(32, 13);
            this.txtTotal.TabIndex = 13;
            // 
            // txtDuration
            // 
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDuration.Location = new System.Drawing.Point(99, 502);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(80, 13);
            this.txtDuration.TabIndex = 12;
            // 
            // txtStudyLevel
            // 
            this.txtStudyLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStudyLevel.Location = new System.Drawing.Point(211, 441);
            this.txtStudyLevel.Name = "txtStudyLevel";
            this.txtStudyLevel.Size = new System.Drawing.Size(80, 13);
            this.txtStudyLevel.TabIndex = 11;
            // 
            // txtLegalBase
            // 
            this.txtLegalBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLegalBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLegalBase.Location = new System.Drawing.Point(211, 402);
            this.txtLegalBase.Name = "txtLegalBase";
            this.txtLegalBase.Size = new System.Drawing.Size(80, 13);
            this.txtLegalBase.TabIndex = 10;
            // 
            // txtCalif
            // 
            this.txtCalif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCalif.Location = new System.Drawing.Point(320, 362);
            this.txtCalif.Name = "txtCalif";
            this.txtCalif.Size = new System.Drawing.Size(80, 13);
            this.txtCalif.TabIndex = 9;
            // 
            // txtMarks
            // 
            this.txtMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMarks.Location = new System.Drawing.Point(111, 362);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(80, 13);
            this.txtMarks.TabIndex = 8;
            // 
            // txtLevel
            // 
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLevel.Location = new System.Drawing.Point(211, 320);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(80, 13);
            this.txtLevel.TabIndex = 7;
            // 
            // txtCOD
            // 
            this.txtCOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCOD.Location = new System.Drawing.Point(334, 174);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(104, 13);
            this.txtCOD.TabIndex = 6;
            // 
            // txtCOR
            // 
            this.txtCOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCOR.Location = new System.Drawing.Point(348, 155);
            this.txtCOR.Name = "txtCOR";
            this.txtCOR.Size = new System.Drawing.Size(48, 13);
            this.txtCOR.TabIndex = 4;
            // 
            // txtCalifications
            // 
            this.txtCalifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCalifications.Location = new System.Drawing.Point(161, 155);
            this.txtCalifications.Name = "txtCalifications";
            this.txtCalifications.Size = new System.Drawing.Size(112, 13);
            this.txtCalifications.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumber.Location = new System.Drawing.Point(400, 137);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(38, 12);
            this.txtNumber.TabIndex = 4;
            // 
            // txtSeries
            // 
            this.txtSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeries.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.Location = new System.Drawing.Point(297, 145);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(62, 13);
            this.txtSeries.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtType.Location = new System.Drawing.Point(76, 145);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(79, 13);
            this.txtType.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::hr.Properties.Resources.verso;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(210, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 530);
            this.panel2.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(42, 292);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(413, 20);
            this.textBox10.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(42, 266);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(413, 20);
            this.textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(42, 240);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(413, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(42, 213);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(413, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(42, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(413, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(42, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(413, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(413, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(413, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(413, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 53);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(28, 453);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 53);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 593);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnSup);
            this.Name = "frmPrinter";
            this.Text = "frmPrinter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtCalifications;
        private System.Windows.Forms.TextBox txtCOR;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.TextBox txtPracticPreg;
        private System.Windows.Forms.TextBox txtThPreg;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtStudyLevel;
        private System.Windows.Forms.TextBox txtLegalBase;
        private System.Windows.Forms.TextBox txtCalif;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.TextBox txtFurnizor;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}