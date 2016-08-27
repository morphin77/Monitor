using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace KIP_Monitor
{
    
    static class Sql
    {
        public static SqlConnection Connection;
        public static SqlCommand Request;
        public static SqlDataAdapter SqlDataAdapter;
        public static DataSet DataSet;

        public static void ConnectDb(string Query)
        {
            //задаем параметры подключения к серверу
            Connection =
                new SqlConnection("Data Source=WIN-69V9K3A7J6U\\SQLEXPRESS;Initial Catalog=Monitor;Integrated Security=True");

            Connection.Open();
            //Создаем новый SQL запрос
            Request = new SqlCommand(Query, Connection);
            //Создаем адаптер для подключения к БД
            SqlDataAdapter = new SqlDataAdapter(Request);
            //создаем таблицу для получения данных
            DataSet = new DataSet();
            //заполняем таблицу
            SqlDataAdapter.Fill(DataSet);
            Connection.Close();
        }
    }
}
