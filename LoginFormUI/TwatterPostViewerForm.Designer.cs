namespace LoginFormUI
{
    partial class TwatterPostViewerForm
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
            this.fullTwatterPostContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.postedByUserLabel = new System.Windows.Forms.Label();
            this.dateOfTwatterPostLabel = new System.Windows.Forms.Label();
            this.twatterPostIdLabel = new System.Windows.Forms.Label();
            this.postedByUserValue = new System.Windows.Forms.Label();
            this.dateOfTwatterPostValue = new System.Windows.Forms.Label();
            this.twatterPostIdValue = new System.Windows.Forms.Label();
            this.closeTwatterPostViewerButton = new System.Windows.Forms.Button();
            this.editTwatterPostButton = new System.Windows.Forms.Button();
            this.postEditedDateTimeValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(111, 48);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(323, 47);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Twatter Post Viewer";
            // 
            // fullTwatterPostContentRichTextBox
            // 
            this.fullTwatterPostContentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullTwatterPostContentRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullTwatterPostContentRichTextBox.Location = new System.Drawing.Point(79, 208);
            this.fullTwatterPostContentRichTextBox.Name = "fullTwatterPostContentRichTextBox";
            this.fullTwatterPostContentRichTextBox.ReadOnly = true;
            this.fullTwatterPostContentRichTextBox.Size = new System.Drawing.Size(374, 131);
            this.fullTwatterPostContentRichTextBox.TabIndex = 7;
            this.fullTwatterPostContentRichTextBox.Text = "";
            // 
            // postedByUserLabel
            // 
            this.postedByUserLabel.AutoSize = true;
            this.postedByUserLabel.Location = new System.Drawing.Point(79, 115);
            this.postedByUserLabel.Name = "postedByUserLabel";
            this.postedByUserLabel.Size = new System.Drawing.Size(114, 30);
            this.postedByUserLabel.TabIndex = 8;
            this.postedByUserLabel.Text = "Posted by: ";
            // 
            // dateOfTwatterPostLabel
            // 
            this.dateOfTwatterPostLabel.AutoSize = true;
            this.dateOfTwatterPostLabel.Location = new System.Drawing.Point(79, 145);
            this.dateOfTwatterPostLabel.Name = "dateOfTwatterPostLabel";
            this.dateOfTwatterPostLabel.Size = new System.Drawing.Size(133, 30);
            this.dateOfTwatterPostLabel.TabIndex = 8;
            this.dateOfTwatterPostLabel.Text = "Date of post:";
            // 
            // twatterPostIdLabel
            // 
            this.twatterPostIdLabel.AutoSize = true;
            this.twatterPostIdLabel.Location = new System.Drawing.Point(79, 175);
            this.twatterPostIdLabel.Name = "twatterPostIdLabel";
            this.twatterPostIdLabel.Size = new System.Drawing.Size(80, 30);
            this.twatterPostIdLabel.TabIndex = 8;
            this.twatterPostIdLabel.Text = "Post id:";
            // 
            // postedByUserValue
            // 
            this.postedByUserValue.AutoSize = true;
            this.postedByUserValue.Location = new System.Drawing.Point(199, 115);
            this.postedByUserValue.Name = "postedByUserValue";
            this.postedByUserValue.Size = new System.Drawing.Size(80, 30);
            this.postedByUserValue.TabIndex = 8;
            this.postedByUserValue.Text = "<user>";
            // 
            // dateOfTwatterPostValue
            // 
            this.dateOfTwatterPostValue.AutoSize = true;
            this.dateOfTwatterPostValue.Location = new System.Drawing.Point(220, 145);
            this.dateOfTwatterPostValue.Name = "dateOfTwatterPostValue";
            this.dateOfTwatterPostValue.Size = new System.Drawing.Size(172, 30);
            this.dateOfTwatterPostValue.TabIndex = 8;
            this.dateOfTwatterPostValue.Text = "2021-01-01 12:00";
            // 
            // twatterPostIdValue
            // 
            this.twatterPostIdValue.AutoSize = true;
            this.twatterPostIdValue.Location = new System.Drawing.Point(165, 175);
            this.twatterPostIdValue.Name = "twatterPostIdValue";
            this.twatterPostIdValue.Size = new System.Drawing.Size(104, 30);
            this.twatterPostIdValue.TabIndex = 8;
            this.twatterPostIdValue.Text = "<post id>";
            // 
            // closeTwatterPostViewerButton
            // 
            this.closeTwatterPostViewerButton.Location = new System.Drawing.Point(106, 388);
            this.closeTwatterPostViewerButton.Name = "closeTwatterPostViewerButton";
            this.closeTwatterPostViewerButton.Size = new System.Drawing.Size(106, 38);
            this.closeTwatterPostViewerButton.TabIndex = 9;
            this.closeTwatterPostViewerButton.Text = "Close";
            this.closeTwatterPostViewerButton.UseVisualStyleBackColor = true;
            this.closeTwatterPostViewerButton.Click += new System.EventHandler(this.closeTwatterPostViewerButton_Click);
            // 
            // editTwatterPostButton
            // 
            this.editTwatterPostButton.Enabled = false;
            this.editTwatterPostButton.Location = new System.Drawing.Point(297, 388);
            this.editTwatterPostButton.Name = "editTwatterPostButton";
            this.editTwatterPostButton.Size = new System.Drawing.Size(126, 38);
            this.editTwatterPostButton.TabIndex = 9;
            this.editTwatterPostButton.Text = "Edit twatt";
            this.editTwatterPostButton.UseVisualStyleBackColor = true;
            this.editTwatterPostButton.Visible = false;
            this.editTwatterPostButton.Click += new System.EventHandler(this.editTwatterPostButton_Click);
            // 
            // postEditedDateTimeValueLabel
            // 
            this.postEditedDateTimeValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.postEditedDateTimeValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postEditedDateTimeValueLabel.Location = new System.Drawing.Point(179, 342);
            this.postEditedDateTimeValueLabel.Name = "postEditedDateTimeValueLabel";
            this.postEditedDateTimeValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.postEditedDateTimeValueLabel.Size = new System.Drawing.Size(274, 15);
            this.postEditedDateTimeValueLabel.TabIndex = 10;
            this.postEditedDateTimeValueLabel.Text = "This post was last edited 2021-01-01 12:00";
            this.postEditedDateTimeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.postEditedDateTimeValueLabel.Visible = false;
            // 
            // TwatterPostViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 464);
            this.Controls.Add(this.postEditedDateTimeValueLabel);
            this.Controls.Add(this.editTwatterPostButton);
            this.Controls.Add(this.closeTwatterPostViewerButton);
            this.Controls.Add(this.twatterPostIdValue);
            this.Controls.Add(this.twatterPostIdLabel);
            this.Controls.Add(this.dateOfTwatterPostValue);
            this.Controls.Add(this.dateOfTwatterPostLabel);
            this.Controls.Add(this.postedByUserValue);
            this.Controls.Add(this.postedByUserLabel);
            this.Controls.Add(this.fullTwatterPostContentRichTextBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TwatterPostViewerForm";
            this.Text = "Twatter Post Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TwatterPostViewerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RichTextBox fullTwatterPostContentRichTextBox;
        private System.Windows.Forms.Label postedByUserLabel;
        private System.Windows.Forms.Label dateOfTwatterPostLabel;
        private System.Windows.Forms.Label twatterPostIdLabel;
        private System.Windows.Forms.Label postedByUserValue;
        private System.Windows.Forms.Label dateOfTwatterPostValue;
        private System.Windows.Forms.Label twatterPostIdValue;
        private System.Windows.Forms.Button closeTwatterPostViewerButton;
        private System.Windows.Forms.Button editTwatterPostButton;
        private System.Windows.Forms.Label postEditedDateTimeValueLabel;
    }
}