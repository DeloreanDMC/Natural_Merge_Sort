namespace Super_Natural_Merge_Sort
{
    partial class MainForm
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
            this.InputLable = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // InputLable
            // 
            this.InputLable.AutoSize = true;
            this.InputLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputLable.Location = new System.Drawing.Point(24, 16);
            this.InputLable.Name = "InputLable";
            this.InputLable.Size = new System.Drawing.Size(502, 27);
            this.InputLable.TabIndex = 0;
            this.InputLable.Text = "Введите числовую последовательность";
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.InputTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.InputTextBox.Location = new System.Drawing.Point(29, 46);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(393, 34);
            this.InputTextBox.TabIndex = 1;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(437, 45);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(255, 32);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Инициализировать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(437, 262);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(255, 32);
            this.Sort.TabIndex = 5;
            this.Sort.Text = "Отсортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(29, 262);
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(370, 56);
            this.trackBar.TabIndex = 6;
            this.trackBar.Value = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(725, 336);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLable);
            this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Natural Merge Sort";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLable;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

