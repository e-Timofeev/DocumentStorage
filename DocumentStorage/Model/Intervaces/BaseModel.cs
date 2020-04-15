using System;
using System.Threading.Tasks;

namespace DocumentStorage.Model
{
    /// <summary>
    /// Интерфейс для объекта документ.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Успешное сохранение документа.
        /// </summary>
        event EventHandler DataSaved;

        /// <summary>
        /// Внешний ключ на пользователя.
        /// </summary>
        int UserID { get; set; }

        /// <summary>
        /// Название документа.
        /// </summary>
        string DocumentName { get; set; }

        /// <summary>
        /// Дата создания документа.
        /// </summary>
        DateTime CreateDate { get; set; }

        /// <summary>
        /// Автор документа.
        /// </summary>
        IUser Author { get; set; }

        /// <summary>
        /// Расширяемый тип документа.
        /// </summary>
        int DocType { get; set; }

        /// <summary>
        /// Бинарный файл.
        /// </summary>
        IFile BinaryFile { get; set; }

        /// <summary>
        /// Сохранить документ в базу.
        /// </summary>
        void DocumentSaveToSql(IDocument document);

        /// <summary>
        /// Получить документ.
        /// </summary>
        void GetDocument();
    }

    /// <summary>
    /// Интерфейс для объекта пользователь.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Дата регистрации пользователя.
        /// </summary>
        DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Получение данных пользователя.
        /// </summary>
        void GetUser();
    }

    /// <summary>
    /// Интерфейс для объекта файл.
    /// </summary>
    public interface IFile
    {
        /// <summary>
        /// Внешний ключ на документ.
        /// </summary>
        int DocumentId { get; set; }

        /// <summary>
        /// Идентификатор файла.
        /// </summary>       
        Guid FileGuid { get; set; }

        /// <summary>
        /// Бинарный файл из ФС.
        /// </summary>
        byte[] Data { get; set; }

        /// <summary>
        /// Получить бинарный файл из ФС.
        /// </summary>
        /// <param name="patch"></param>
        byte[] GetBinary(string patch);

        /// <summary>
        /// Расширение.
        /// </summary>
        string FileExtension { get; set; }

        /// <summary>
        /// Получить расширение.
        /// </summary>
        string GetExtension(string path);
    }

    /// <summary>
    /// Интерфейс для работы с базой данных.
    /// </summary>
    public interface IDb
    {
        /// <summary>
        /// Успешная загрузка данных.
        /// </summary>
        event EventHandler DataDownloaded;

        /// <summary>
        /// Строка соединения для подключения к БД.
        /// </summary>
        string stringConnection { get; set; }

        /// <summary>
        /// Получение реестра документов.
        /// </summary>
        System.Data.DataTable GetData();

        /// <summary>
        /// Статус соединения.
        /// </summary>
        /// <returns>Возвращает состояние подключения.</returns>
        bool GetStatusConnection();

        /// <summary>
        /// Название текущей базы.
        /// </summary>
        /// <returns>Возвращает название базы.</returns>
        string GetBaseName();
    }
}
