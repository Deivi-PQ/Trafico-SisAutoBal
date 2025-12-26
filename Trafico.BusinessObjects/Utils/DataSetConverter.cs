using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Linq;

namespace Trafico.BusinessObjects.Utils
{
    /// <summary>
    /// Utilidad para convertir objetos y listas a DataSet/DataTable
    /// </summary>
    public static class DataSetConverter
    {
        /// <summary>
        /// Convierte una lista de objetos a DataTable
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="data">Lista de objetos</param>
        /// <param name="tableName">Nombre de la tabla (opcional)</param>
        /// <returns>DataTable con los datos</returns>
        public static DataTable ToDataTable<T>(IList<T> data, string? tableName = null)
        {
            DataTable dataTable = new DataTable(tableName ?? typeof(T).Name);

            if (data == null || data.Count == 0)
            {
                return dataTable;
            }

            // Obtener propiedades del tipo T
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Crear columnas en el DataTable
            foreach (PropertyInfo property in properties)
            {
                Type propertyType = property.PropertyType;

                // Manejar tipos nullable
                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    propertyType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;
                }

                dataTable.Columns.Add(property.Name, propertyType);
            }

            // Llenar datos
            foreach (T item in data)
            {
                DataRow row = dataTable.NewRow();

                foreach (PropertyInfo property in properties)
                {
                    object? value = property.GetValue(item, null);
                    row[property.Name] = value ?? DBNull.Value;
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        /// <summary>
        /// Convierte una lista de objetos a DataSet
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="data">Lista de objetos</param>
        /// <param name="dataSetName">Nombre del DataSet</param>
        /// <param name="tableName">Nombre de la tabla</param>
        /// <returns>DataSet con los datos</returns>
        public static DataSet ToDataSet<T>(IList<T> data, string dataSetName = "DataSet", string? tableName = null)
        {
            DataSet dataSet = new DataSet(dataSetName);
            DataTable dataTable = ToDataTable(data, tableName);
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        /// <summary>
        /// Convierte múltiples listas de objetos a un DataSet con múltiples tablas
        /// </summary>
        /// <param name="dataSetName">Nombre del DataSet</param>
        /// <param name="tables">Diccionario con nombre de tabla y datos</param>
        /// <returns>DataSet con múltiples tablas</returns>
        public static DataSet ToDataSetMultiTable(string dataSetName, Dictionary<string, object> tables)
        {
            DataSet dataSet = new DataSet(dataSetName);

            foreach (var table in tables)
            {
                string tableName = table.Key;
                object data = table.Value;

                if (data == null) continue;

                DataTable? dataTable = ConvertToDataTable(data, tableName);
                if (dataTable != null)
                {
                    dataSet.Tables.Add(dataTable);
                }
            }

            return dataSet;
        }

        /// <summary>
        /// Convierte un objeto individual a DataTable con una sola fila
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="obj">Objeto a convertir</param>
        /// <param name="tableName">Nombre de la tabla</param>
        /// <returns>DataTable con una fila</returns>
        public static DataTable ObjectToDataTable<T>(T obj, string? tableName = null)
        {
            if (obj == null) return new DataTable(tableName ?? typeof(T).Name);

            return ToDataTable(new List<T> { obj }, tableName);
        }

        /// <summary>
        /// Convierte dinámicamente cualquier tipo de lista a DataTable
        /// </summary>
        /// <param name="data">Datos a convertir</param>
        /// <param name="tableName">Nombre de la tabla</param>
        /// <returns>DataTable</returns>
        public static DataTable? ConvertToDataTable(object data, string tableName)
        {
            if (data == null) return null;

            Type dataType = data.GetType();

            // Si es IEnumerable (lista)
            if (dataType.IsGenericType && typeof(IEnumerable<>).IsAssignableFrom(dataType.GetGenericTypeDefinition()))
            {
                Type itemType = dataType.GetGenericArguments()[0];
                MethodInfo? method = typeof(DataSetConverter).GetMethod("ToDataTable");
                if (method != null)
                {
                    MethodInfo generic = method.MakeGenericMethod(itemType);
                    return (DataTable?)generic.Invoke(null, new object[] { data, tableName });
                }
            }
            // Si es un objeto individual
            else
            {
                MethodInfo? method = typeof(DataSetConverter).GetMethod("ObjectToDataTable");
                if (method != null)
                {
                    MethodInfo generic = method.MakeGenericMethod(dataType);
                    return (DataTable?)generic.Invoke(null, new object[] { data, tableName });
                }
            }

            return null;
        }

        /// <summary>
        /// Convierte un DataTable existente agregando metadatos útiles
        /// </summary>
        /// <param name="dataTable">DataTable existente</param>
        /// <param name="metadata">Metadatos adicionales</param>
        /// <returns>DataSet con tabla de datos y tabla de metadatos</returns>
        public static DataSet EnhanceWithMetadata(DataTable dataTable, Dictionary<string, object>? metadata = null)
        {
            DataSet dataSet = new DataSet();

            // Agregar tabla principal
            dataSet.Tables.Add(dataTable.Copy());

            // Agregar tabla de metadatos si se proporcionan
            if (metadata != null && metadata.Count > 0)
            {
                DataTable metaTable = new DataTable("Metadata");
                metaTable.Columns.Add("Key", typeof(string));
                metaTable.Columns.Add("Value", typeof(string));

                foreach (var meta in metadata)
                {
                    DataRow row = metaTable.NewRow();
                    row["Key"] = meta.Key;
                    row["Value"] = meta.Value?.ToString() ?? "";
                    metaTable.Rows.Add(row);
                }

                dataSet.Tables.Add(metaTable);
            }

            return dataSet;
        }

        /// <summary>
        /// Crear DataSet para reportes con estructura estándar
        /// </summary>
        /// <typeparam name="T">Tipo de datos principales</typeparam>
        /// <param name="mainData">Datos principales</param>
        /// <param name="reportParameters">Parámetros del reporte</param>
        /// <param name="additionalTables">Tablas adicionales</param>
        /// <returns>DataSet estructurado para reportes</returns>
        public static DataSet CreateReportDataSet<T>(
            IList<T> mainData,
            Dictionary<string, string>? reportParameters = null,
            Dictionary<string, object>? additionalTables = null)
        {
            DataSet dataSet = new DataSet("ReportDataSet");

            // Tabla principal de datos
            DataTable mainTable = ToDataTable(mainData, "MainData");
            dataSet.Tables.Add(mainTable);

            // Tabla de parámetros del reporte
            if (reportParameters != null && reportParameters.Count > 0)
            {
                DataTable paramTable = new DataTable("Parameters");
                paramTable.Columns.Add("ParameterName", typeof(string));
                paramTable.Columns.Add("ParameterValue", typeof(string));

                foreach (var param in reportParameters)
                {
                    DataRow row = paramTable.NewRow();
                    row["ParameterName"] = param.Key;
                    row["ParameterValue"] = param.Value;
                    paramTable.Rows.Add(row);
                }

                dataSet.Tables.Add(paramTable);
            }

            // Tablas adicionales
            if (additionalTables != null)
            {
                foreach (var table in additionalTables)
                {
                    DataTable? additionalTable = ConvertToDataTable(table.Value, table.Key);
                    if (additionalTable != null)
                    {
                        dataSet.Tables.Add(additionalTable);
                    }
                }
            }

            return dataSet;
        }

        /// <summary>
        /// Validar y limpiar nombres de tablas/columnas para compatibilidad
        /// </summary>
        /// <param name="name">Nombre a validar</param>
        /// <returns>Nombre válido</returns>
        public static string SanitizeName(string name)
        {
            if (string.IsNullOrEmpty(name)) return "DefaultName";

            // Remover caracteres especiales y espacios
            string sanitized = System.Text.RegularExpressions.Regex.Replace(name, @"[^a-zA-Z0-9_]", "_");

            // Asegurar que no comience con número
            if (char.IsDigit(sanitized[0]))
            {
                sanitized = "_" + sanitized;
            }

            return sanitized;
        }
    }
}