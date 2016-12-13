namespace FractalsPlotter
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
            this.pnCanvas = new System.Windows.Forms.Panel();
            this.buttonDrawFractal = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBarIteration = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarFractalHeight = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFractalChoice = new System.Windows.Forms.ComboBox();
            this.trackBarSidesCount = new System.Windows.Forms.TrackBar();
            this.labelSidesCount = new System.Windows.Forms.Label();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonInterruptDrawing = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFractalHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSidesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCanvas
            // 
            this.pnCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCanvas.Location = new System.Drawing.Point(207, 12);
            this.pnCanvas.Name = "pnCanvas";
            this.pnCanvas.Size = new System.Drawing.Size(500, 500);
            this.pnCanvas.TabIndex = 1;
            // 
            // buttonDrawFractal
            // 
            this.buttonDrawFractal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDrawFractal.Location = new System.Drawing.Point(5, 412);
            this.buttonDrawFractal.Name = "buttonDrawFractal";
            this.buttonDrawFractal.Size = new System.Drawing.Size(191, 34);
            this.buttonDrawFractal.TabIndex = 2;
            this.buttonDrawFractal.Text = "Построить выбранный фрактал";
            this.buttonDrawFractal.UseVisualStyleBackColor = true;
            this.buttonDrawFractal.Click += new System.EventHandler(this.DrawFractal_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 488);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // trackBarIteration
            // 
            this.trackBarIteration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarIteration.Location = new System.Drawing.Point(5, 76);
            this.trackBarIteration.Minimum = 1;
            this.trackBarIteration.Name = "trackBarIteration";
            this.trackBarIteration.Size = new System.Drawing.Size(190, 45);
            this.trackBarIteration.TabIndex = 5;
            this.trackBarIteration.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarIteration.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите количество итераций:";
            // 
            // trackBarFractalHeight
            // 
            this.trackBarFractalHeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarFractalHeight.Location = new System.Drawing.Point(6, 253);
            this.trackBarFractalHeight.Maximum = 500;
            this.trackBarFractalHeight.Minimum = 1;
            this.trackBarFractalHeight.Name = "trackBarFractalHeight";
            this.trackBarFractalHeight.Size = new System.Drawing.Size(190, 45);
            this.trackBarFractalHeight.TabIndex = 5;
            this.trackBarFractalHeight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarFractalHeight.Value = 500;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Длина фрактала (в пикселях):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите фрактал для построения";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 190);
            this.trackBarSpeed.Maximum = 2000;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(190, 45);
            this.trackBarSpeed.TabIndex = 5;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpeed.Value = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скорость построения:";
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarThickness.Location = new System.Drawing.Point(6, 130);
            this.trackBarThickness.Maximum = 50;
            this.trackBarThickness.Minimum = 1;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(190, 45);
            this.trackBarThickness.TabIndex = 5;
            this.trackBarThickness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarThickness.Value = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Толщина линии:";
            // 
            // comboBoxFractalChoice
            // 
            this.comboBoxFractalChoice.FormattingEnabled = true;
            this.comboBoxFractalChoice.Items.AddRange(new object[] {
            "Кривая Коха",
            "Снежинка Коха",
            "Треугольник Серпинского",
            "Ковёр Серпинского"});
            this.comboBoxFractalChoice.Location = new System.Drawing.Point(10, 26);
            this.comboBoxFractalChoice.Name = "comboBoxFractalChoice";
            this.comboBoxFractalChoice.Size = new System.Drawing.Size(182, 21);
            this.comboBoxFractalChoice.TabIndex = 7;
            this.comboBoxFractalChoice.Text = "Кривая Коха";
            this.comboBoxFractalChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFractalChoice_SelectedIndexChanged);
            // 
            // trackBarSidesCount
            // 
            this.trackBarSidesCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSidesCount.Location = new System.Drawing.Point(10, 318);
            this.trackBarSidesCount.Minimum = 2;
            this.trackBarSidesCount.Name = "trackBarSidesCount";
            this.trackBarSidesCount.Size = new System.Drawing.Size(190, 45);
            this.trackBarSidesCount.TabIndex = 5;
            this.trackBarSidesCount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSidesCount.Value = 4;
            this.trackBarSidesCount.Visible = false;
            // 
            // labelSidesCount
            // 
            this.labelSidesCount.AutoSize = true;
            this.labelSidesCount.Location = new System.Drawing.Point(21, 302);
            this.labelSidesCount.Name = "labelSidesCount";
            this.labelSidesCount.Size = new System.Drawing.Size(160, 13);
            this.labelSidesCount.TabIndex = 6;
            this.labelSidesCount.Text = "Количество сторон снежинки:";
            this.labelSidesCount.Visible = false;
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.Location = new System.Drawing.Point(207, 12);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(500, 500);
            this.FractalPictureBox.TabIndex = 8;
            this.FractalPictureBox.TabStop = false;
            this.FractalPictureBox.Visible = false;
            // 
            // buttonInterruptDrawing
            // 
            this.buttonInterruptDrawing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInterruptDrawing.Location = new System.Drawing.Point(5, 450);
            this.buttonInterruptDrawing.Name = "buttonInterruptDrawing";
            this.buttonInterruptDrawing.Size = new System.Drawing.Size(191, 34);
            this.buttonInterruptDrawing.TabIndex = 2;
            this.buttonInterruptDrawing.Text = "Прервать построение";
            this.buttonInterruptDrawing.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.Location = new System.Drawing.Point(5, 374);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(191, 34);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 520);
            this.Controls.Add(this.FractalPictureBox);
            this.Controls.Add(this.comboBoxFractalChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSidesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnCanvas);
            this.Controls.Add(this.buttonInterruptDrawing);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonDrawFractal);
            this.Controls.Add(this.trackBarIteration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.trackBarSidesCount);
            this.Controls.Add(this.trackBarFractalHeight);
            this.Name = "Form1";
            this.Text = "FractalsPlotter v.0.2.6";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFractalHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSidesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCanvas;
        private System.Windows.Forms.Button buttonDrawFractal;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBarIteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarFractalHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFractalChoice;
        private System.Windows.Forms.TrackBar trackBarSidesCount;
        private System.Windows.Forms.Label labelSidesCount;
        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.Button buttonInterruptDrawing;
        private System.Windows.Forms.Button buttonAbout;
    }
}

