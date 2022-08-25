
namespace Library
{
    partial class Records
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerOfIssue = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOfReleas = new System.Windows.Forms.DateTimePicker();
            this.textBoxNameReader = new System.Windows.Forms.TextBox();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReaderBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRelise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAuth = new System.Windows.Forms.TextBox();
            this.textBoxSearchBook = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchGanre = new System.Windows.Forms.TextBox();
            this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(732, 510);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(431, 42);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(169, 432);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(994, 42);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 47);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(773, 801);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата выдачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(756, 846);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата возврата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(795, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Читатель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(826, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Книга";
            // 
            // dateTimePickerOfIssue
            // 
            this.dateTimePickerOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerOfIssue.Location = new System.Drawing.Point(912, 797);
            this.dateTimePickerOfIssue.Name = "dateTimePickerOfIssue";
            this.dateTimePickerOfIssue.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerOfIssue.TabIndex = 7;
            // 
            // dateTimePickerOfReleas
            // 
            this.dateTimePickerOfReleas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerOfReleas.Location = new System.Drawing.Point(912, 846);
            this.dateTimePickerOfReleas.Name = "dateTimePickerOfReleas";
            this.dateTimePickerOfReleas.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerOfReleas.TabIndex = 8;
            // 
            // textBoxNameReader
            // 
            this.textBoxNameReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameReader.Location = new System.Drawing.Point(912, 579);
            this.textBoxNameReader.Name = "textBoxNameReader";
            this.textBoxNameReader.ReadOnly = true;
            this.textBoxNameReader.Size = new System.Drawing.Size(251, 29);
            this.textBoxNameReader.TabIndex = 9;
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idReaderBook,
            this.Book,
            this.Author,
            this.reader,
            this.dateOfIssue,
            this.DateRelise});
            this.dataGridViewRecords.Location = new System.Drawing.Point(169, 63);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.Size = new System.Drawing.Size(994, 339);
            this.dataGridViewRecords.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idReaderBook
            // 
            this.idReaderBook.HeaderText = "idBook";
            this.idReaderBook.Name = "idReaderBook";
            this.idReaderBook.ReadOnly = true;
            this.idReaderBook.Visible = false;
            this.idReaderBook.Width = 10;
            // 
            // Book
            // 
            this.Book.HeaderText = "Книга";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Width = 200;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 200;
            // 
            // reader
            // 
            this.reader.HeaderText = "Читатель";
            this.reader.Name = "reader";
            this.reader.ReadOnly = true;
            this.reader.Width = 150;
            // 
            // dateOfIssue
            // 
            this.dateOfIssue.HeaderText = "Дата выдычи";
            this.dateOfIssue.Name = "dateOfIssue";
            this.dateOfIssue.ReadOnly = true;
            this.dateOfIssue.Width = 200;
            // 
            // DateRelise
            // 
            this.DateRelise.HeaderText = "Дата возврата";
            this.DateRelise.Name = "DateRelise";
            this.DateRelise.ReadOnly = true;
            this.DateRelise.Width = 200;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBook,
            this.SelectBook,
            this.Genre,
            this.SelectAuthor});
            this.dataGridViewSearch.Location = new System.Drawing.Point(36, 673);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.Size = new System.Drawing.Size(594, 288);
            this.dataGridViewSearch.TabIndex = 12;
            this.dataGridViewSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearch_CellClick);
            this.dataGridViewSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearch_CellContentClick);
            // 
            // textBoxBook
            // 
            this.textBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBook.Location = new System.Drawing.Point(912, 635);
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.ReadOnly = true;
            this.textBoxBook.Size = new System.Drawing.Size(251, 29);
            this.textBoxBook.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(764, 749);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Автор Книги";
            // 
            // textBoxAuth
            // 
            this.textBoxAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuth.Location = new System.Drawing.Point(912, 749);
            this.textBoxAuth.Name = "textBoxAuth";
            this.textBoxAuth.ReadOnly = true;
            this.textBoxAuth.Size = new System.Drawing.Size(251, 29);
            this.textBoxAuth.TabIndex = 15;
            // 
            // textBoxSearchBook
            // 
            this.textBoxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchBook.Location = new System.Drawing.Point(93, 507);
            this.textBoxSearchBook.Name = "textBoxSearchBook";
            this.textBoxSearchBook.Size = new System.Drawing.Size(353, 29);
            this.textBoxSearchBook.TabIndex = 17;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(472, 622);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(158, 29);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(912, 691);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(251, 29);
            this.textBoxGenre.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(826, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Жанр";
            // 
            // textBoxSearchGanre
            // 
            this.textBoxSearchGanre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchGanre.Location = new System.Drawing.Point(93, 564);
            this.textBoxSearchGanre.Name = "textBoxSearchGanre";
            this.textBoxSearchGanre.Size = new System.Drawing.Size(353, 29);
            this.textBoxSearchGanre.TabIndex = 21;
            // 
            // textBoxSearchAuthor
            // 
            this.textBoxSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchAuthor.Location = new System.Drawing.Point(93, 622);
            this.textBoxSearchAuthor.Name = "textBoxSearchAuthor";
            this.textBoxSearchAuthor.Size = new System.Drawing.Size(353, 29);
            this.textBoxSearchAuthor.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Автор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Жанр";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Книга";
            // 
            // idBook
            // 
            this.idBook.HeaderText = "id";
            this.idBook.Name = "idBook";
            this.idBook.ReadOnly = true;
            this.idBook.Visible = false;
            // 
            // SelectBook
            // 
            this.SelectBook.HeaderText = "Книга";
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.ReadOnly = true;
            this.SelectBook.Width = 200;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 150;
            // 
            // SelectAuthor
            // 
            this.SelectAuthor.HeaderText = "Автор";
            this.SelectAuthor.Name = "SelectAuthor";
            this.SelectAuthor.ReadOnly = true;
            this.SelectAuthor.Width = 200;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(573, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Таблица записей ";
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 973);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSearchAuthor);
            this.Controls.Add(this.textBoxSearchGanre);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchBook);
            this.Controls.Add(this.textBoxAuth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBook);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(this.textBoxNameReader);
            this.Controls.Add(this.dateTimePickerOfReleas);
            this.Controls.Add(this.dateTimePickerOfIssue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Records_FormClosed);
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfReleas;
        private System.Windows.Forms.TextBox textBoxNameReader;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAuth;
        private System.Windows.Forms.TextBox textBoxSearchBook;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReaderBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRelise;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectAuthor;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchGanre;
        private System.Windows.Forms.TextBox textBoxSearchAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}