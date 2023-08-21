using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Helpers
{
    public static class ConvertHelper
    {
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> resultList = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                resultList.Add(item);
            }
            return resultList;
        }

        private static T GetItem<T>(DataRow dataRow)
        {
            Type temp = typeof(T);
            T record = Activator.CreateInstance<T>();

            foreach (DataColumn column in dataRow.Table.Columns)
            {
                foreach (PropertyInfo propertyInfo in temp.GetProperties())
                {
                    if (propertyInfo.Name == column.ColumnName)
                    {
                        if (dataRow[column.ColumnName] is DBNull)
                            propertyInfo.SetValue(record, null, null);
                        else
                            propertyInfo.SetValue(record, dataRow[column.ColumnName], null);
                    }
                    else
                        continue;
                }
            }
            return record;
        }
    }
}

