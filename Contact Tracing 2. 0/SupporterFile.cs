using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Contact_Tracing_2._0
{
    internal class SupporterFile
    {
        private static DataTable Contact_Tracing_Monitory(string location, char delimiter = ',')
        {
            DataTable result;
            string[] linearray = File.ReadAllLines(location);
            result = FromDataTable(linearray, delimiter);
            return result;
        }

        private static DataTable FromDataTable(string[] linearray, char delimiter)
        {
            DataTable dt = new DataTable();
            AddColumnToTable(linearray, delimiter, ref dt);
            AddRowToTable(linearray, delimiter, ref dt);
            return dt;
        }

        private static void AddRowToTable(string[] valueCollection, char delimiter, ref DataTable dt)
        {
            for (int i = 0; 1 < valueCollection.Length; i++)
            {
                string[] values = valueCollection[i].Split(delimiter);
                DataRow row = dt.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j];
                }
            }
        }
        private static void AddColumnToTable(string[] columnCollection, char delimiter, ref DataTable dt)
        {
            string[] columns = columnCollection[0].Split(delimiter);
            foreach (string columnName in columns)
            {
                DataColumn dc = new DataColumn(columnName, typeof(string));
                dt.Columns.Add(dc);
            }
        }
    }
}
