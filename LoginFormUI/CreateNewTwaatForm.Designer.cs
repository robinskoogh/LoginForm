namespace LoginFormUI
{
    partial class CreateNewTwaatForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.twaatContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.twaatCharCounterLabel = new System.Windows.Forms.Label();
            this.clearTwaatTextButton = new System.Windows.Forms.Button();
            this.postTwaatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(128, 54);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(288, 47);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Create new twaat";
            // 
            // twaatContentRichTextBox
            // 
            this.twaatContentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twaatContentRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twaatContentRichTextBox.Location = new System.Drawing.Point(85, 142);
            this.twaatContentRichTextBox.Name = "twaatContentRichTextBox";
            this.twaatContentRichTextBox.Size = new System.Drawing.Size(374, 131);
            this.twaatContentRichTextBox.TabIndex = 5;
            this.twaatContentRichTextBox.Text = "";
            this.twaatContentRichTextBox.TextChanged += new System.EventHandler(this.twaatContentRichTextBox_TextChanged);
            // 
            // twaatCharCounterLabel
            // 
            this.twaatCharCounterLabel.AutoSize = true;
            this.twaatCharCounterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twaatCharCounterLabel.Location = new System.Drawing.Point(387, 250);
            this.twaatCharCounterLabel.Name = "twaatCharCounterLabel";
            this.twaatCharCounterLabel.Size = new System.Drawing.Size(70, 21);
            this.twaatCharCounterLabel.TabIndex = 6;
            this.twaatCharCounterLabel.Text = "140/140";
            // 
            // clearTwaatTextButton
            // 
            this.clearTwaatTextButton.Location = new System.Drawing.Point(141, 309);
            this.clearTwaatTextButton.Name = "clearTwaatTextButton";
            this.clearTwaatTextButton.Size = new System.Drawing.Size(92, 40);
            this.clearTwaatTextButton.TabIndex = 7;
            this.clearTwaatTextButton.Text = "Clear";
            this.clearTwaatTextButton.UseVisualStyleBackColor = true;
            this.clearTwaatTextButton.Click += new System.EventHandler(this.clearTwaatTextButton_Click);
            // 
            // postTwaatButton
            // 
            this.postTwaatButton.Location = new System.Drawing.Point(311, 309);
            this.postTwaatButton.Name = "postTwaatButton";
            this.postTwaatButton.Size = new System.Drawing.Size(92, 40);
            this.postTwaatButton.TabIndex = 8;
            this.postTwaatButton.Text = "Post";
            this.postTwaatButton.UseVisualStyleBackColor = true;
            this.postTwaatButton.Click += new System.EventHandler(this.postTwaatButton_Click);
            // 
            // CreateNewTwaatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 405);
            this.Controls.Add(this.postTwaatButton);
            this.Controls.Add(this.clearTwaatTextButton);
            this.Controls.Add(this.twaatCharCounterLabel);
            this.Controls.Add(this.twaatContentRichTextBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateNewTwaatForm";
            this.Text = "Create New Twaat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostTwaatForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RichTextBox twaatContentRichTextBox;
        private System.Windows.Forms.Label twaatCharCounterLabel;
        private System.Windows.Forms.Button clearTwaatTextButton;
        private System.Windows.Forms.Button postTwaatButton;
    }
}