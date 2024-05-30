namespace WinFormsTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.MyText = new System.Windows.Forms.TextBox();
            this.AnalyseButton = new System.Windows.Forms.Button();
            this.ProgressAnalyse = new System.Windows.Forms.ProgressBar();
            this.OutputButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input text";
            // 
            // MyText
            // 
            this.MyText.Location = new System.Drawing.Point(147, 24);
            this.MyText.MaximumSize = new System.Drawing.Size(500, 200);
            this.MyText.MinimumSize = new System.Drawing.Size(500, 200);
            this.MyText.Multiline = true;
            this.MyText.Name = "MyText";
            this.MyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MyText.Size = new System.Drawing.Size(500, 200);
            this.MyText.TabIndex = 1;
            // 
            // AnalyseButton
            // 
            this.AnalyseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AnalyseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyseButton.Location = new System.Drawing.Point(43, 304);
            this.AnalyseButton.Name = "AnalyseButton";
            this.AnalyseButton.Size = new System.Drawing.Size(89, 36);
            this.AnalyseButton.TabIndex = 2;
            this.AnalyseButton.Text = "Analyse";
            this.AnalyseButton.UseMnemonic = false;
            this.AnalyseButton.UseVisualStyleBackColor = false;
            this.AnalyseButton.Click += new System.EventHandler(this.Analyse_Click);
            // 
            // ProgressAnalyse
            // 
            this.ProgressAnalyse.Location = new System.Drawing.Point(147, 304);
            this.ProgressAnalyse.Name = "ProgressAnalyse";
            this.ProgressAnalyse.Size = new System.Drawing.Size(500, 36);
            this.ProgressAnalyse.TabIndex = 3;
            this.ProgressAnalyse.Visible = false;
            // 
            // OutputButton
            // 
            this.OutputButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputButton.Location = new System.Drawing.Point(249, 296);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(115, 53);
            this.OutputButton.TabIndex = 4;
            this.OutputButton.Text = "Output the result";
            this.OutputButton.UseMnemonic = false;
            this.OutputButton.UseVisualStyleBackColor = false;
            this.OutputButton.Visible = false;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(410, 296);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 53);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save to a file";
            this.SaveButton.UseMnemonic = false;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TryButton
            // 
            this.TryButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TryButton.Location = new System.Drawing.Point(657, 373);
            this.TryButton.Name = "TryButton";
            this.TryButton.Size = new System.Drawing.Size(115, 53);
            this.TryButton.TabIndex = 6;
            this.TryButton.Text = "Try again";
            this.TryButton.UseMnemonic = false;
            this.TryButton.UseVisualStyleBackColor = false;
            this.TryButton.Visible = false;
            this.TryButton.Click += new System.EventHandler(this.TryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TryButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.ProgressAnalyse);
            this.Controls.Add(this.AnalyseButton);
            this.Controls.Add(this.MyText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Text Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MyText;
        private System.Windows.Forms.Button AnalyseButton;
        private System.Windows.Forms.ProgressBar ProgressAnalyse;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button TryButton;
    }
}

