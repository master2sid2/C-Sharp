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
            this.PreviewWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LabelCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.PreviewWindowStatusStrip.SuspendLayout();
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
            // PreviewWindowStatusStrip
            // 
            this.PreviewWindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelCaption,
            this.LabelNumber});
            this.PreviewWindowStatusStrip.Location = new System.Drawing.Point(0, 339);
            this.PreviewWindowStatusStrip.Name = "PreviewWindowStatusStrip";
            this.PreviewWindowStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.PreviewWindowStatusStrip.TabIndex = 1;
            this.PreviewWindowStatusStrip.Text = "statusStrip1";
            // 
            // LabelCaption
            // 
            this.LabelCaption.Name = "LabelCaption";
            this.LabelCaption.Size = new System.Drawing.Size(109, 17);
            this.LabelCaption.Text = "Количество строк:";
            // 
            // LabelNumber
            // 
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(13, 17);
            this.LabelNumber.Text = "0";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.PreviewWindowStatusStrip);
            this.Controls.Add(this.PreviewTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreviewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File preview";
            this.PreviewWindowStatusStrip.ResumeLayout(false);
            this.PreviewWindowStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PreviewTextBox;
        private System.Windows.Forms.StatusStrip PreviewWindowStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LabelCaption;
        private System.Windows.Forms.ToolStripStatusLabel LabelNumber;
    }
}