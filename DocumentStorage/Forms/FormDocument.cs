using DocumentStorage.Model.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace DocumentStorage.Forms
{
    public partial class FormDocument : Form
    {
        /// <summary>
        /// Конструктор по-умолчанию. Инициализирует форму.
        /// </summary>
        public FormDocument() => InitializeComponent();

        /// <summary>
        /// При перетаскивании файла в область контрола.
        /// </summary>
        private void DropFile_DragEnter(object sender, DragEventArgs e)
        {
            ListView view = sender as ListView;
            if (view?.Items.Count == 0)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] item = (string[])e.Data.GetData(DataFormats.FileDrop);
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        /// <summary>
        /// Когда файл перетащен.
        /// </summary>
        private void DropFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] item = (string[])e.Data.GetData(DataFormats.FileDrop);
                ListViewItem listViewItem = new ListViewItem(item, 0);
                dropFile.Items.Add(listViewItem);
                tbName.Text = tbName.Text.Length == 0 ? Path.GetFileNameWithoutExtension(dropFile.Items[0].Text) : tbName.Text;
            }
        }

        /// <summary>
        /// Открытие добавленного файла.
        /// </summary>
        private void DropFile_Click(object sender, System.EventArgs e)
        {
            ListViewItem firstSelectedItem = dropFile.SelectedItems[0];
            System.Diagnostics.Process.Start(firstSelectedItem.Text);
        }

        /// <summary>
        /// Добавить файл из ФС.
        /// </summary>
        private void BtAddFile_Click(object sender, EventArgs e)
        {
            if (dropFile.Items.Count == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    FileName = "Выбрать файл",
                    Title = "Добавить вложение",
                    Multiselect = false
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dropFile.Items.Clear();
                    string[] files = openFileDialog.FileNames;
                    dropFile.Items.Add(new ListViewItem(files, 0));
                    tbName.Text = tbName.Text.Length == 0 ? Path.GetFileNameWithoutExtension(dropFile.Items[0].Text) : tbName.Text;
                }
            }
        }

        /// <summary>
        /// Очистить представление.
        /// </summary>
        private void BtDelete_Click(object sender, System.EventArgs e) => dropFile.Items.Clear();

        /// <summary>
        /// Закрыть без сохранения.
        /// </summary>
        private void BtCancel_Click(object sender, System.EventArgs e) => Close();

        /// <summary>
        /// Сохранение документа в базу.
        /// </summary>
        private void BtSaveDoc_Click(object sender, System.EventArgs e)
        {
            int type()
            {
                if (rbInternal.Checked) return rbInternal.TabIndex;
                else return rbExtermal.TabIndex;
            }
            Document document = new Document()
            {
                Author = new User() { UserName = tbAutor?.Text },
                CreateDate = CreateDate.Value,
                DocType = type(),
                DocumentName = tbName?.Text,
                BinaryFile = new DocumentFile(dropFile.Items[0].Text),
                UserID = 1
            };
            document.BinaryFile.DocumentId = 1;
            //подписались на событие загрузки.
            document.DataSaved += Document_DataSaved;
            document.DocumentSaveToSql(document);                      
        }

        /// <summary>
        /// Обработчик события DataSaved
        /// </summary>
        private void Document_DataSaved(object sender, EventArgs e)
        {
            MessageBox.Show("Документ успешно сохранен", "Info message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}