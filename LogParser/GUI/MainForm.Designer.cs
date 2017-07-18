namespace LogParser
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileBottun = new System.Windows.Forms.Button();
            this.ShowHideBottun = new System.Windows.Forms.Button();
            this.SaveBottun = new System.Windows.Forms.Button();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.InvertCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterCheckBox = new System.Windows.Forms.CheckBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.LabelInputTextBox = new System.Windows.Forms.Label();
            this.ControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileBottun
            // 
            this.OpenFileBottun.Location = new System.Drawing.Point(10, 109);
            this.OpenFileBottun.Name = "OpenFileBottun";
            this.OpenFileBottun.Size = new System.Drawing.Size(100, 30);
            this.OpenFileBottun.TabIndex = 0;
            this.OpenFileBottun.Text = "Открыть файл";
            this.OpenFileBottun.UseVisualStyleBackColor = true;
            this.OpenFileBottun.Click += new System.EventHandler(this.OpenFileBottun_Click);
            // 
            // ShowHideBottun
            // 
            this.ShowHideBottun.Location = new System.Drawing.Point(116, 109);
            this.ShowHideBottun.Name = "ShowHideBottun";
            this.ShowHideBottun.Size = new System.Drawing.Size(100, 30);
            this.ShowHideBottun.TabIndex = 1;
            this.ShowHideBottun.Text = "Спрятать окно";
            this.ShowHideBottun.UseVisualStyleBackColor = true;
            this.ShowHideBottun.Click += new System.EventHandler(this.Bottun_Click);
            // 
            // SaveBottun
            // 
            this.SaveBottun.Location = new System.Drawing.Point(222, 109);
            this.SaveBottun.Name = "SaveBottun";
            this.SaveBottun.Size = new System.Drawing.Size(100, 30);
            this.SaveBottun.TabIndex = 2;
            this.SaveBottun.Text = "Сохранить файл";
            this.SaveBottun.UseVisualStyleBackColor = true;
            this.SaveBottun.Click += new System.EventHandler(this.SaveBottun_Click);
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.InvertCheckBox);
            this.ControlGroupBox.Controls.Add(this.RegisterCheckBox);
            this.ControlGroupBox.Location = new System.Drawing.Point(12, 54);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(310, 45);
            this.ControlGroupBox.TabIndex = 3;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Опции";
            // 
            // InvertCheckBox
            // 
            this.InvertCheckBox.AutoSize = true;
            this.InvertCheckBox.Location = new System.Drawing.Point(206, 20);
            this.InvertCheckBox.Name = "InvertCheckBox";
            this.InvertCheckBox.Size = new System.Drawing.Size(104, 17);
            this.InvertCheckBox.TabIndex = 1;
            this.InvertCheckBox.Text = "Инвертировать";
            this.InvertCheckBox.UseVisualStyleBackColor = true;
            this.InvertCheckBox.CheckedChanged += new System.EventHandler(this.InvertCheckBox_CheckedChanged);
            // 
            // RegisterCheckBox
            // 
            this.RegisterCheckBox.AutoSize = true;
            this.RegisterCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RegisterCheckBox.Name = "RegisterCheckBox";
            this.RegisterCheckBox.Size = new System.Drawing.Size(120, 17);
            this.RegisterCheckBox.TabIndex = 0;
            this.RegisterCheckBox.Text = "С учётом регистра";
            this.RegisterCheckBox.UseVisualStyleBackColor = true;
            this.RegisterCheckBox.CheckedChanged += new System.EventHandler(this.RegisterCheckBox_CheckedChanged);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(12, 28);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(310, 20);
            this.InputTextBox.TabIndex = 4;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // LabelInputTextBox
            // 
            this.LabelInputTextBox.AutoSize = true;
            this.LabelInputTextBox.Location = new System.Drawing.Point(12, 9);
            this.LabelInputTextBox.Name = "LabelInputTextBox";
            this.LabelInputTextBox.Size = new System.Drawing.Size(105, 13);
            this.LabelInputTextBox.TabIndex = 5;
            this.LabelInputTextBox.Text = "Фраза для поиска:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 147);
            this.Controls.Add(this.LabelInputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ControlGroupBox);
            this.Controls.Add(this.SaveBottun);
            this.Controls.Add(this.ShowHideBottun);
            this.Controls.Add(this.OpenFileBottun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парсер логов";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlGroupBox.ResumeLayout(false);
            this.ControlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileBottun;
        private System.Windows.Forms.Button ShowHideBottun;
        private System.Windows.Forms.Button SaveBottun;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.CheckBox InvertCheckBox;
        private System.Windows.Forms.CheckBox RegisterCheckBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label LabelInputTextBox;
    }
}

