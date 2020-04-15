using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DocumentStorage.Model.Classes
{
    /// <summary>
    /// Работа с базой.
    /// </summary>
    public class DB : IDb
    {
        /// <summary>
        /// Строка соединения с базой.
        /// </summary>
        public string stringConnection { get; set; }

        /// <summary>
        /// Подключение к базе.
        /// </summary>
        public SqlConnection Connection { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public DB()
        {
            stringConnection = ConfigurationManager.ConnectionStrings["DocumentStorage.Properties.Settings.StorageConnectionString"]?.ConnectionString;
        }

        /// <summary>
        /// Данные загружены.
        /// </summary>
        public event EventHandler DataDownloaded;

        /// <summary>
        /// Получение реестра документов.
        /// </summary>
        public DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            using (Connection = new SqlConnection(stringConnection))
            {
                try
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand("GetDocuments", Connection)
                    {
                        // вызываем хп
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    // кидаем событие об успешной загрузке данных.          
                    DataDownloaded?.Invoke(this, EventArgs.Empty);                  
                }
                catch (SqlException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
                return dataTable;
            }
        }

        /// <summary>
        /// Получить статус соединения с базой.
        /// </summary>
        public bool GetStatusConnection()
        {
            if (Connection?.State == ConnectionState.Open)
                return true;
            else return false;
        }

        /// <summary>
        /// Получить имя базы.
        /// </summary>
        /// <returns></returns>
        public string GetBaseName()
        {
            if (GetStatusConnection())
                return Connection.Database;
            else return "";
        }
    }
}
