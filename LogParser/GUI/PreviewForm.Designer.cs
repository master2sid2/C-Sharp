namespace LogParser.GUI
{
    partial class PreviewForm
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
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewTextBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreviewTextBox.Size = new System.Drawing.Size(784, 361);
            this.PreviewTextBox.TabIndex = 0;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.PreviewTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreviewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PreviewTextBox;
    }
}