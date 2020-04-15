namespace DocumentStorage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.Info = new System.Windows.Forms.Label();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Service = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Service});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 624F));
            this.Layout.Controls.Add(this.dgvDocuments, 0, 0);
            this.Layout.Controls.Add(this.Info, 0, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 24);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Layout.Size = new System.Drawing.Size(624, 417);
            this.Layout.TabIndex = 1;
            this.Layout.Visible = false;
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocuments.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocuments.Location = new System.Drawing.Point(3, 3);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.Size = new System.Drawing.Size(618, 369);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellClick);
            this.dgvDocuments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDocuments_CellFormatting);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Location = new System.Drawing.Point(3, 375);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(618, 42);
            this.Info.TabIndex = 1;
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Personal,
            this.Exit});
            this.File.Image = global::DocumentStorage.Properties.Resources.gohome;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(69, 20);
            this.File.Text = "ФАЙЛ";
            // 
            // Create
            // 
            this.Create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйДокументToolStripMenuItem});
            this.Create.Image = global::DocumentStorage.Properties.Resources.folder;
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(158, 22);
            this.Create.Text = "Создать ";
            // 
            // новыйДокументToolStripMenuItem
            // 
            this.новыйДокументToolStripMenuItem.Image = global::DocumentStorage.Properties.Resources.add_new;
            this.новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
            this.новыйДокументToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.новыйДокументToolStripMenuItem.Text = "Новый документ";
            this.новыйДокументToolStripMenuItem.Click += new System.EventHandler(this.НовыйДокументToolStripMenuItem_Click);
            // 
            // Personal
            // 
            this.Personal.Image = global::DocumentStorage.Properties.Resources.personal;
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(158, 22);
            this.Personal.Text = "Учетная запись";
            // 
            // Exit
            // 
            this.Exit.Image = global::DocumentStorage.Properties.Resources.exit;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(158, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Service
            // 
            this.Service.Image = global::DocumentStorage.Properties.Resources.view;
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(159, 20);
            this.Service.Text = "РЕЕСТР ДОКУМЕНТОВ";
            this.Service.Click += new System.EventHandler(this.Service_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хранилище документов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem Personal;
        private System.Windows.Forms.ToolStripMenuItem Service;
        private System.Windows.Forms.ToolStripMenuItem новыйДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        protected System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Label Info;
    }
}

