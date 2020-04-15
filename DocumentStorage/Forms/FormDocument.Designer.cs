namespace DocumentStorage.Forms
{
    partial class FormDocument
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocument));
            this.LayoutFile = new System.Windows.Forms.TableLayoutPanel();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.gbAuthor = new System.Windows.Forms.GroupBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbExtermal = new System.Windows.Forms.RadioButton();
            this.rbInternal = new System.Windows.Forms.RadioButton();
            this.gbDropFile = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddFile = new System.Windows.Forms.Button();
            this.dropFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveDoc = new System.Windows.Forms.Button();
            this.LayoutFile.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.gbAuthor.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbDropFile.SuspendLayout();
            this.btLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutFile
            // 
            this.LayoutFile.ColumnCount = 2;
            this.LayoutFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutFile.Controls.Add(this.gbDate, 1, 1);
            this.LayoutFile.Controls.Add(this.gbAuthor, 0, 1);
            this.LayoutFile.Controls.Add(this.gbName, 0, 0);
            this.LayoutFile.Controls.Add(this.gbType, 0, 2);
            this.LayoutFile.Controls.Add(this.gbDropFile, 1, 2);
            this.LayoutFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutFile.Location = new System.Drawing.Point(0, 0);
            this.LayoutFile.Name = "LayoutFile";
            this.LayoutFile.RowCount = 4;
            this.LayoutFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutFile.Size = new System.Drawing.Size(464, 321);
            this.LayoutFile.TabIndex = 0;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.CreateDate);
            this.gbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDate.Location = new System.Drawing.Point(235, 91);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(226, 82);
            this.gbDate.TabIndex = 3;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Дата создания";
            // 
            // CreateDate
            // 
            this.CreateDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateDate.Location = new System.Drawing.Point(3, 16);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(220, 20);
            this.CreateDate.TabIndex = 0;
            // 
            // gbAuthor
            // 
            this.gbAuthor.Controls.Add(this.tbAutor);
            this.gbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAuthor.Location = new System.Drawing.Point(3, 91);
            this.gbAuthor.Name = "gbAuthor";
            this.gbAuthor.Size = new System.Drawing.Size(226, 82);
            this.gbAuthor.TabIndex = 2;
            this.gbAuthor.TabStop = false;
            this.gbAuthor.Text = "Автор";
            // 
            // tbAutor
            // 
            this.tbAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAutor.Location = new System.Drawing.Point(3, 16);
            this.tbAutor.Multiline = true;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(220, 20);
            this.tbAutor.TabIndex = 0;
            // 
            // gbName
            // 
            this.LayoutFile.SetColumnSpan(this.gbName, 2);
            this.gbName.Controls.Add(this.tbName);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbName.Location = new System.Drawing.Point(3, 3);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(458, 82);
            this.gbName.TabIndex = 1;
            this.gbName.TabStop = false;
            this.gbName.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 16);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(612, 20);
            this.tbName.TabIndex = 0;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbExtermal);
            this.gbType.Controls.Add(this.rbInternal);
            this.gbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbType.Location = new System.Drawing.Point(3, 179);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(226, 100);
            this.gbType.TabIndex = 4;
            this.gbType.TabStop = false;
            this.gbType.Text = "Тип документа";
            // 
            // rbExtermal
            // 
            this.rbExtermal.AutoSize = true;
            this.rbExtermal.Location = new System.Drawing.Point(9, 58);
            this.rbExtermal.Name = "rbExtermal";
            this.rbExtermal.Size = new System.Drawing.Size(70, 17);
            this.rbExtermal.TabIndex = 1;
            this.rbExtermal.TabStop = true;
            this.rbExtermal.Text = "Внешний";
            this.rbExtermal.UseVisualStyleBackColor = true;
            // 
            // rbInternal
            // 
            this.rbInternal.AutoSize = true;
            this.rbInternal.Checked = true;
            this.rbInternal.Location = new System.Drawing.Point(9, 35);
            this.rbInternal.Name = "rbInternal";
            this.rbInternal.Size = new System.Drawing.Size(84, 17);
            this.rbInternal.TabIndex = 0;
            this.rbInternal.TabStop = true;
            this.rbInternal.Text = "Внутренний";
            this.rbInternal.UseVisualStyleBackColor = true;
            // 
            // gbDropFile
            // 
            this.gbDropFile.Controls.Add(this.btDelete);
            this.gbDropFile.Controls.Add(this.btAddFile);
            this.gbDropFile.Controls.Add(this.dropFile);
            this.gbDropFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDropFile.Location = new System.Drawing.Point(235, 179);
            this.gbDropFile.Name = "gbDropFile";
            this.gbDropFile.Size = new System.Drawing.Size(226, 100);
            this.gbDropFile.TabIndex = 5;
            this.gbDropFile.TabStop = false;
            this.gbDropFile.Text = "Основной файл (перетащите файл)";
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelete.Image = global::DocumentStorage.Properties.Resources.view_remove;
            this.btDelete.Location = new System.Drawing.Point(190, 39);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(33, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btAddFile
            // 
            this.btAddFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddFile.Image = global::DocumentStorage.Properties.Resources.download_2;
            this.btAddFile.Location = new System.Drawing.Point(190, 16);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(33, 23);
            this.btAddFile.TabIndex = 1;
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.BtAddFile_Click);
            // 
            // dropFile
            // 
            this.dropFile.AllowDrop = true;
            this.dropFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.dropFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.dropFile.LargeImageList = this.imageList;
            this.dropFile.Location = new System.Drawing.Point(3, 16);
            this.dropFile.MultiSelect = false;
            this.dropFile.Name = "dropFile";
            this.dropFile.Size = new System.Drawing.Size(187, 81);
            this.dropFile.TabIndex = 0;
            this.dropFile.TileSize = new System.Drawing.Size(618, 30);
            this.dropFile.UseCompatibleStateImageBehavior = false;
            this.dropFile.Click += new System.EventHandler(this.DropFile_Click);
            this.dropFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropFile_DragDrop);
            this.dropFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropFile_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "skrepka.png");
            // 
            // btLayout
            // 
            this.btLayout.ColumnCount = 2;
            this.btLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btLayout.Controls.Add(this.btCancel, 1, 0);
            this.btLayout.Controls.Add(this.btSaveDoc, 0, 0);
            this.btLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLayout.Location = new System.Drawing.Point(0, 286);
            this.btLayout.Name = "btLayout";
            this.btLayout.RowCount = 1;
            this.btLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btLayout.Size = new System.Drawing.Size(464, 35);
            this.btLayout.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Location = new System.Drawing.Point(235, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(226, 29);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Отменить";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btSaveDoc
            // 
            this.btSaveDoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSaveDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSaveDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSaveDoc.Location = new System.Drawing.Point(3, 3);
            this.btSaveDoc.Name = "btSaveDoc";
            this.btSaveDoc.Size = new System.Drawing.Size(226, 29);
            this.btSaveDoc.TabIndex = 1;
            this.btSaveDoc.Text = "Сохранить документ";
            this.btSaveDoc.UseVisualStyleBackColor = false;
            this.btSaveDoc.Click += new System.EventHandler(this.BtSaveDoc_Click);
            // 
            // FormDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btLayout);
            this.Controls.Add(this.LayoutFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание документа";
            this.LayoutFile.ResumeLayout(false);
            this.gbDate.ResumeLayout(false);
            this.gbAuthor.ResumeLayout(false);
            this.gbAuthor.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbDropFile.ResumeLayout(false);
            this.btLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutFile;
        private System.Windows.Forms.ListView dropFile;
        private System.Windows.Forms.TableLayoutPanel btLayout;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbAuthor;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker CreateDate;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox gbDropFile;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSaveDoc;
        private System.Windows.Forms.RadioButton rbExtermal;
        private System.Windows.Forms.RadioButton rbInternal;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Button btDelete;
    }
}