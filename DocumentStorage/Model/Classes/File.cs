using System;
using System.IO;

namespace DocumentStorage.Model.Classes
{
    class DocumentFile : IFile
    {
        public int DocumentId { get; set; }
        public Guid FileGuid { get; set; }
        public byte[] Data { get; set; }
        public string FileExtension { get; set; }

        public DocumentFile()
        {

        }
        public DocumentFile(string fullname)
        {
            FileGuid = Guid.NewGuid();
            Data = GetBinary(fullname);
            FileExtension = GetExtension(fullname);
        }

        /// <summary>
        /// Перевод в массив байт.
        /// </summary>
        /// <param name="path">Полный путь до файла</param>
        public byte[] GetBinary(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                Data = new byte[fs.Length];
                using (BinaryReader binReader = new BinaryReader(fs))
                {
                    Data = binReader.ReadBytes((int)fs.Length);
                }
            }
            return Data;           
        }

        /// <summary>
        /// Получить расширение вложения документа.
        /// </summary>
        /// <param name="path">Полный путь до файла</param>
        public string GetExtension(string path) =>  Path.GetExtension(path);
    }
}
