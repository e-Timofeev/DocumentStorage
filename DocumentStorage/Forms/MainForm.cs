using DocumentStorage.Forms;
using DocumentStorage.Model.Classes;

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DocumentStorage
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор по-умолчанию. Инициализирует форму.
        /// </summary>
        public MainForm() => InitializeComponent();

        /// <summary>
        /// Создает объект для работы с базой.
        /// </summary>
        public DB dB = new DB();

        /// <summary>
        /// Действия после загрузки данных.
        /// </summary>
        private void DB_DataDownloaded(object sender, EventArgs e)
        {          
            Document document = new Document();
            document.GetDocument();           
            Layout.Visible = true;
            Info.Text = $"Подключена база {dB.GetBaseName()}";
        }

        /// <summary>
        /// Создание нового документа.
        /// </summary>
        private void НовыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocument formDocument = new FormDocument();
            formDocument.Show();
        }

        /// <summary>
        /// Форматирование данных в ячейках.
        /// </summary>
        private void dgvDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString().Length > 30 ? e.Value.ToString().Substring(0, 30) + "..." : e.Value.ToString();
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() == "0" ? "Внутренний" : "Внешний";
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null)
                {
                    e.CellStyle.ForeColor = Color.DarkBlue;                  
                }
            }
        }

        /// <summary>
        /// Открыть файл, полученный из базы, в подкаталоге приложения.
        /// </summary>
        private void dgvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string patch = Application.StartupPath + @"\Binary files from db\";
            string[] getFiles = Directory.GetFiles(patch);
            string openFile = "";
            DataGridViewCell cell = dgvDocuments[e.ColumnIndex, e.RowIndex];
            string File = patch + cell.Value.ToString();

            if (e.ColumnIndex == 4)
            {                
                foreach (string name in getFiles)
                {
                    if (name.Contains(File))
                       openFile = name;                   
                }        
               System.Diagnostics.Process.Start(openFile);
            }
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        private void Exit_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Загрузить из базы реестр.
        /// </summary>
        private void Service_Click(object sender, EventArgs e)
        {
            dB.DataDownloaded += DB_DataDownloaded;
            dgvDocuments.DataSource = dB.GetData().DefaultView;
            //dgvDocuments.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        /// <summary>
        /// Стандартный выход.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
