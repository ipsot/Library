
namespace Library
{
    partial class FormAdd
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
            this.textBoxNameBook = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPageCount = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonCancelAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNameBook
            // 
            this.textBoxNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameBook.Location = new System.Drawing.Point(231, 29);
            this.textBoxNameBook.Name = "textBoxNameBook";
            this.textBoxNameBook.Size = new System.Drawing.Size(297, 29);
            this.textBoxNameBook.TabIndex = 0;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(231, 94);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(297, 29);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // textBoxPageCount
            // 
            this.textBoxPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPageCount.Location = new System.Drawing.Point(231, 162);
            this.textBoxPageCount.Name = "textBoxPageCount";
            this.textBoxPageCount.Size = new System.Drawing.Size(100, 29);
            this.textBoxPageCount.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(43, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(153, 24);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Название книги";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.Location = new System.Drawing.Point(139, 99);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(66, 24);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Автор";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPage.Location = new System.Drawing.Point(9, 165);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(196, 24);
            this.labelPage.TabIndex = 5;
            this.labelPage.Text = "Количество страниц";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBook.Location = new System.Drawing.Point(47, 341);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(217, 38);
            this.buttonAddBook.TabIndex = 6;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonCancelAddBook
            // 
            this.buttonCancelAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelAddBook.Location = new System.Drawing.Point(315, 341);
            this.buttonCancelAddBook.Name = "buttonCancelAddBook";
            this.buttonCancelAddBook.Size = new System.Drawing.Size(213, 38);
            this.buttonCancelAddBook.TabIndex = 7;
            this.buttonCancelAddBook.Text = "Отмена";
            this.buttonCancelAddBook.UseVisualStyleBackColor = true;
            this.buttonCancelAddBook.Click += new System.EventHandler(this.buttonCancelAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Жанр книги";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(231, 232);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(297, 32);
            this.comboBoxGenre.TabIndex = 9;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 418);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelAddBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPageCount);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxNameBook);
            this.Name = "FormAdd";
            this.Text = "Add Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdd_FormClosed);
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPageCount;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonCancelAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGenre;
    }
}