namespace StoryWriter
{
    partial class StoryWriterForm
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
            this.generateStoryButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generateStoryButton
            // 
            this.generateStoryButton.Location = new System.Drawing.Point(160, 408);
            this.generateStoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateStoryButton.Name = "generateStoryButton";
            this.generateStoryButton.Size = new System.Drawing.Size(168, 40);
            this.generateStoryButton.TabIndex = 0;
            this.generateStoryButton.Text = "Generate Story";
            this.generateStoryButton.UseVisualStyleBackColor = true;
            this.generateStoryButton.Click += new System.EventHandler(this.generateStoryButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(24, 24);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(440, 368);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            // 
            // StoryWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.generateStoryButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StoryWriterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Story Writer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateStoryButton;
        private System.Windows.Forms.RichTextBox outputTextBox;
    }
}

