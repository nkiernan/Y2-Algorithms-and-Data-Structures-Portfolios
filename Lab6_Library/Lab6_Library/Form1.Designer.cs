namespace Lab6_Library
{
    partial class Form1
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
            this.addBookButton = new System.Windows.Forms.Button();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.bookDetailsLabel = new System.Windows.Forms.Label();
            this.displayIsbn = new System.Windows.Forms.Label();
            this.displayTitle = new System.Windows.Forms.Label();
            this.loanLabel = new System.Windows.Forms.Label();
            this.searchIsbnButton = new System.Windows.Forms.Button();
            this.changeLoanButton = new System.Windows.Forms.Button();
            this.searchTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(148, 5);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(87, 23);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(6, 10);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(35, 13);
            this.isbnLabel.TabIndex = 1;
            this.isbnLabel.Text = "ISBN:";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(42, 7);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(100, 20);
            this.isbnTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(6, 38);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(42, 35);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(148, 34);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(87, 23);
            this.removeBookButton.TabIndex = 5;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.UseVisualStyleBackColor = true;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // bookDetailsLabel
            // 
            this.bookDetailsLabel.AutoSize = true;
            this.bookDetailsLabel.Location = new System.Drawing.Point(266, 5);
            this.bookDetailsLabel.Name = "bookDetailsLabel";
            this.bookDetailsLabel.Size = new System.Drawing.Size(70, 13);
            this.bookDetailsLabel.TabIndex = 6;
            this.bookDetailsLabel.Text = "Book Details:";
            // 
            // displayIsbn
            // 
            this.displayIsbn.AutoSize = true;
            this.displayIsbn.Location = new System.Drawing.Point(266, 34);
            this.displayIsbn.Name = "displayIsbn";
            this.displayIsbn.Size = new System.Drawing.Size(38, 13);
            this.displayIsbn.TabIndex = 7;
            this.displayIsbn.Text = "ISBN: ";
            // 
            // displayTitle
            // 
            this.displayTitle.AutoSize = true;
            this.displayTitle.Location = new System.Drawing.Point(266, 63);
            this.displayTitle.Name = "displayTitle";
            this.displayTitle.Size = new System.Drawing.Size(33, 13);
            this.displayTitle.TabIndex = 8;
            this.displayTitle.Text = "Title: ";
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Location = new System.Drawing.Point(266, 92);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(51, 13);
            this.loanLabel.TabIndex = 9;
            this.loanLabel.Text = "On Loan:";
            // 
            // searchIsbnButton
            // 
            this.searchIsbnButton.Location = new System.Drawing.Point(148, 63);
            this.searchIsbnButton.Name = "searchIsbnButton";
            this.searchIsbnButton.Size = new System.Drawing.Size(87, 23);
            this.searchIsbnButton.TabIndex = 10;
            this.searchIsbnButton.Text = "Search ISBN";
            this.searchIsbnButton.UseVisualStyleBackColor = true;
            this.searchIsbnButton.Click += new System.EventHandler(this.searchIsbnButton_Click);
            // 
            // changeLoanButton
            // 
            this.changeLoanButton.Location = new System.Drawing.Point(148, 122);
            this.changeLoanButton.Name = "changeLoanButton";
            this.changeLoanButton.Size = new System.Drawing.Size(87, 23);
            this.changeLoanButton.TabIndex = 11;
            this.changeLoanButton.Text = "Change Loan";
            this.changeLoanButton.UseVisualStyleBackColor = true;
            this.changeLoanButton.Click += new System.EventHandler(this.changeLoanButton_Click);
            // 
            // searchTitleButton
            // 
            this.searchTitleButton.Location = new System.Drawing.Point(148, 93);
            this.searchTitleButton.Name = "searchTitleButton";
            this.searchTitleButton.Size = new System.Drawing.Size(87, 23);
            this.searchTitleButton.TabIndex = 12;
            this.searchTitleButton.Text = "Search Title";
            this.searchTitleButton.UseVisualStyleBackColor = true;
            this.searchTitleButton.Click += new System.EventHandler(this.searchTitleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 151);
            this.Controls.Add(this.searchTitleButton);
            this.Controls.Add(this.changeLoanButton);
            this.Controls.Add(this.searchIsbnButton);
            this.Controls.Add(this.loanLabel);
            this.Controls.Add(this.displayTitle);
            this.Controls.Add(this.displayIsbn);
            this.Controls.Add(this.bookDetailsLabel);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.addBookButton);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Label bookDetailsLabel;
        private System.Windows.Forms.Label displayIsbn;
        private System.Windows.Forms.Label displayTitle;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Button searchIsbnButton;
        private System.Windows.Forms.Button changeLoanButton;
        private System.Windows.Forms.Button searchTitleButton;
    }
}

