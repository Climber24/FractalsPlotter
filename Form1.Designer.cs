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
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.barIteration = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.barFractalHeight = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.barThickness = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFractalChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFractalHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThickness)).BeginInit();
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(5, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Построить выбранный фрактал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DrawFractal_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 488);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // barIteration
            // 
            this.barIteration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barIteration.Location = new System.Drawing.Point(5, 76);
            this.barIteration.Minimum = 1;
            this.barIteration.Name = "barIteration";
            this.barIteration.Size = new System.Drawing.Size(190, 45);
            this.barIteration.TabIndex = 5;
            this.barIteration.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barIteration.Value = 1;
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
            // barFractalHeight
            // 
            this.barFractalHeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barFractalHeight.Location = new System.Drawing.Point(2, 378);
            this.barFractalHeight.Maximum = 500;
            this.barFractalHeight.Minimum = 1;
            this.barFractalHeight.Name = "barFractalHeight";
            this.barFractalHeight.Size = new System.Drawing.Size(190, 45);
            this.barFractalHeight.TabIndex = 5;
            this.barFractalHeight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barFractalHeight.Value = 500;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 362);
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
            // barSpeed
            // 
            this.barSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barSpeed.Location = new System.Drawing.Point(5, 255);
            this.barSpeed.Maximum = 2000;
            this.barSpeed.Minimum = 1;
            this.barSpeed.Name = "barSpeed";
            this.barSpeed.Size = new System.Drawing.Size(190, 45);
            this.barSpeed.TabIndex = 5;
            this.barSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barSpeed.Value = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скорость построения:";
            // 
            // barThickness
            // 
            this.barThickness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barThickness.Location = new System.Drawing.Point(6, 161);
            this.barThickness.Maximum = 50;
            this.barThickness.Minimum = 1;
            this.barThickness.Name = "barThickness";
            this.barThickness.Size = new System.Drawing.Size(190, 45);
            this.barThickness.TabIndex = 5;
            this.barThickness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barThickness.Value = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 148);
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
            "Снежинка Коха"});
            this.comboBoxFractalChoice.Location = new System.Drawing.Point(10, 26);
            this.comboBoxFractalChoice.Name = "comboBoxFractalChoice";
            this.comboBoxFractalChoice.Size = new System.Drawing.Size(182, 21);
            this.comboBoxFractalChoice.TabIndex = 7;
            this.comboBoxFractalChoice.Text = "Кривая Коха";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 520);
            this.Controls.Add(this.comboBoxFractalChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnCanvas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barIteration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barThickness);
            this.Controls.Add(this.barSpeed);
            this.Controls.Add(this.barFractalHeight);
            this.Name = "Form1";
            this.Text = "FractalsPlotter v.0.2";
            ((System.ComponentModel.ISupportInitialize)(this.barIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFractalHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCanvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar barIteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar barFractalHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar barSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar barThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFractalChoice;
    }
}

