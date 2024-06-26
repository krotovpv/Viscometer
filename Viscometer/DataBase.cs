﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Viscometer
{
    public static class DataBase
    {
        public static DataTable GetData(string commandText)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.DbName};Initial Catalog=Viscosimeters;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                {
                    DbDataAdapter adapter = new SqlDataAdapter(commandText, connection);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка запроса в БД");
                //Console.WriteLine(ex.Message);
            }

            return dt;
        }
    }
}
