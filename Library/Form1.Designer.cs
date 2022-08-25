
namespace Library
{
    partial class FormBook
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonGoToReaders = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewReader = new System.Windows.Forms.DataGridView();
            this.IdReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 602);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(494, 42);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить книгу";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonGoToReaders
            // 
            this.buttonGoToReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToReaders.Location = new System.Drawing.Point(1135, 498);
            this.buttonGoToReaders.Name = "buttonGoToReaders";
            this.buttonGoToReaders.Size = new System.Drawing.Size(519, 80);
            this.buttonGoToReaders.TabIndex = 1;
            this.buttonGoToReaders.Text = "Перейти к читателям";
            this.buttonGoToReaders.UseVisualStyleBackColor = true;
            this.buttonGoToReaders.Click += new System.EventHandler(this.buttonGoToReaders_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(598, 602);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(494, 42);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить книгу";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameBook,
            this.Author,
            this.Page,
            this.Genre,
            this.OnHand});
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1080, 497);
            this.dataGridViewBooks.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "Название Книги";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            this.NameBook.Width = 350;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 250;
            // 
            // Page
            // 
            this.Page.HeaderText = "Количество страниц";
            this.Page.Name = "Page";
            this.Page.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр книги";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 205;
            // 
            // OnHand
            // 
            this.OnHand.HeaderText = "В наличии";
            this.OnHand.Name = "OnHand";
            this.OnHand.ReadOnly = true;
            this.OnHand.Width = 130;
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.AllowUserToAddRows = false;
            this.dataGridViewReader.AllowUserToDeleteRows = false;
            this.dataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReader,
            this.BookOnHand,
            this.NameReader,
            this.Ticket,
            this.ReleaseDate,
            this.DateNow});
            this.dataGridViewReader.Location = new System.Drawing.Point(1135, 111);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.ReadOnly = true;
            this.dataGridViewReader.Size = new System.Drawing.Size(519, 341);
            this.dataGridViewReader.TabIndex = 4;
            this.dataGridViewReader.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewReader_RowPrePaint);
            // 
            // IdReader
            // 
            this.IdReader.HeaderText = "id";
            this.IdReader.Name = "IdReader";
            this.IdReader.ReadOnly = true;
            this.IdReader.Visible = false;
            // 
            // BookOnHand
            // 
            this.BookOnHand.HeaderText = "Книга";
            this.BookOnHand.Name = "BookOnHand";
            this.BookOnHand.ReadOnly = true;
            this.BookOnHand.Width = 140;
            // 
            // NameReader
            // 
            this.NameReader.HeaderText = "Имя читателя";
            this.NameReader.Name = "NameReader";
            this.NameReader.ReadOnly = true;
            this.NameReader.Width = 136;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Читательский билет";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Дата возврата книги";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // DateNow
            // 
            this.DateNow.HeaderText = "Сейчас";
            this.DateNow.Name = "DateNow";
            this.DateNow.ReadOnly = true;
            this.DateNow.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1328, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список взятых книг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(470, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список книг";
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewReader);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonGoToReaders);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormBook";
            this.Text = "Книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBook_FormClosed);
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonGoToReaders;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnHand;
        private System.Windows.Forms.DataGridView dataGridViewReader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNow;
    }
}

