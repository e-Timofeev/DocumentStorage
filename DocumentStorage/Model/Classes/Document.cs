using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DocumentStorage.Model.Classes
{
    /// <summary>
    /// Работа с документом.
    /// </summary>
    public class Document : IDocument
    {
        /// <summary>
        /// Конструктор по-умолчанию. Создает объект для подключения к базе.
        /// </summary>
        public Document()
        {
            dB = new DB();
        }

        /// <summary>
        /// Конструктор построения документа из базы.
        /// </summary>
        /// <param name="Data"></param>
        public Document(byte[] Data, Guid guid)
        {
            BinaryFile.FileGuid = guid;
            BinaryFile.Data = Data;
        }

        public int UserID { get; set; }
        public string DocumentName { get; set; }
        public DateTime CreateDate { get; set; }
        public IUser Author { get; set; }
        public int DocType { get; set; }
        public IFile BinaryFile { get; set; }
        private DB dB { get; set; }

        /// <summary>
        /// Данные сохранены.
        /// </summary>
        public event EventHandler DataSaved;

        /// <summary>
        /// Сохранение файла в базу.
        /// </summary>
        public void DocumentSaveToSql(IDocument doc)
        {
            using (dB.Connection = new SqlConnection(dB.stringConnection))
            {
                try
                {
                    dB.Connection.Open();
                    SqlCommand command = new SqlCommand("InsertDocument", dB.Connection)
                    {
                        // вызываем хп
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.Add(new SqlParameter("@docname", doc.DocumentName));
                    command.Parameters.Add(new SqlParameter("@date", doc.CreateDate));
                    command.Parameters.Add(new SqlParameter("@type", doc.DocType));
                    command.Parameters.Add(new SqlParameter("@UserID", doc.UserID));
                    //файл
                    command.Parameters.Add(new SqlParameter("@FileID", doc.BinaryFile.FileGuid));
                    command.Parameters.Add(new SqlParameter("@Binary", doc.BinaryFile.Data));
                    command.Parameters.Add(new SqlParameter("@DocID", doc.BinaryFile.DocumentId));
                    command.Parameters.Add(new SqlParameter("@FileExtension", doc.BinaryFile.FileExtension));
                    var result = command.ExecuteNonQuery();
                    // кидаем событие об успешной записи в базу.
                    DataSaved?.Invoke(this, EventArgs.Empty);
                }
                catch (SqlException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                finally
                {
                    dB.Connection.Close();
                } // Подключаемся к базе             
            }
        }

        /// <summary>
        /// Получить бинарный файл.
        /// </summary>
        public void GetDocument()
        {
            List<DocumentFile> list = new List<DocumentFile>();
            using (dB.Connection = new SqlConnection(dB.stringConnection))
            {
                dB.Connection.Open();
                SqlCommand command = new SqlCommand("GetFiles", dB.Connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Guid guid = (Guid)reader["FileGuid"];
                    byte[] data = (byte[])reader["Data"];
                    int docid = (int)reader["DocID"];
                    string ext = (string)reader["FileExtension"];
                    list.Add(new DocumentFile() { FileGuid = guid, Data = data, DocumentId = docid, FileExtension = ext });
                }
                string patch = Application.StartupPath + @"\Binary files from db\";
                if (!Directory.Exists(patch))
                {
                    Directory.CreateDirectory(patch);
                }
                foreach (DocumentFile item in list)
                {
                    File.WriteAllBytes($"{patch}{item.FileGuid}{item.FileExtension}", item.Data);
                }

            }
        }
    }
}