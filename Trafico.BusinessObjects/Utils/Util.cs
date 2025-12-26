using System.Data;
using System.Globalization;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using Trafico.BusinessObjects.Seguridad;
namespace Trafico.BusinessObjects.Utils
{
    public class Util
    {
        public static string[] decrypt(string token)
        {
            try
            {
                string key = "PRUEBA"; //System.Configuration.ConfigurationManager.AppSettings["SECRET_KEY"];
                byte[] keyArray;
                byte[] arrayEncrypted = Convert.FromBase64String(token);
                string decrypted = String.Empty;

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(arrayEncrypted, 0, arrayEncrypted.Length);

                tdes.Clear();

                decrypted = UTF8Encoding.UTF8.GetString(resultArray);
                string[] arrayDecrypted = decrypted.Split('-');
                return arrayDecrypted;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string encrypt(string usr, string ide, string est)
        {
            string result = string.Empty;
            try
            {
                string parameters = usr + '-' + ide + '-' + est;
                string key = "PRUEBA"; //System.Configuration.ConfigurationManager.AppSettings["SECRET_KEY"];
                byte[] keyArray;
                byte[] arrayEncrypted = UTF8Encoding.UTF8.GetBytes(parameters);
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(arrayEncrypted, 0, arrayEncrypted.Length);

                tdes.Clear();

                result = Convert.ToBase64String(resultArray, 0, resultArray.Length);

            }
            catch (Exception ex)
            {
                result = String.Empty;
            }

            return result;
        }

        public static void EscribeLog(string mensaje)
        {
            try
            {
                var dir = "D:\\Logs\\SNP";
                string archivo = dir + "\\snp_" + DateTime.Today.ToString("yyyyMMdd") + ".log";
                Directory.CreateDirectory(dir);

                using (System.IO.FileStream stream = new System.IO.FileStream(archivo, System.IO.FileMode.Append, System.IO.FileAccess.Write))
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(stream);
                    writer.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " > " + mensaje);
                    writer.Close();
                }

                #region Old
                //string path = AppDomain.CurrentDomain.BaseDirectory;
                //String dir = Path.GetDirectoryName(path);
                //dir += "\\errores";
                //string archivo = dir + "\\cacl_" + DateTime.Today.ToString("yyyyMMdd") + ".log";
                //Directory.CreateDirectory(dir); // inside the if statement

                ////if (System.IO.File.Exists(archivo))
                ////{
                //using (System.IO.FileStream stream = new System.IO.FileStream(archivo, System.IO.FileMode.Append, System.IO.FileAccess.Write))
                //{
                //    System.IO.StreamWriter writer = new System.IO.StreamWriter(stream);
                //    writer.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " > " + mensaje);
                //    writer.Close();
                //}
                ////}
                ////else
                ////{
                ////    using (System.IO.StreamWriter writer = System.IO.File.CreateText(archivo))
                ////    {
                ////        writer.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " > " + mensaje);
                ////        writer.Close();
                ////    }
                ////}
                #endregion
            }
            catch (Exception) { }
        }

        public static bool TryParseDate(string fechatexto, string format, out DateTime fecha)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            // Parse date-only value with invariant culture.
            //fechatexto = "06/15/2008";
            //format = "dd/MM/yyyy";
            return DateTime.TryParseExact(fechatexto, format, provider, DateTimeStyles.None, out fecha);
        }

        public static DateTime ParseDate(string fechatexto, string format)
        {
            DateTime fecha;
            CultureInfo provider = CultureInfo.InvariantCulture;

            // Parse date-only value with invariant culture.
            //fechatexto = "06/15/2008";
            //format = "dd/MM/yyyy";
            fecha = DateTime.ParseExact(fechatexto, format, provider, DateTimeStyles.None);
            return fecha;
        }

        public static string DecCad(object _valor, int decimales, int total)
        {
            decimal valor;
            if (_valor == DBNull.Value)
            {
                _valor = 0;
            }
            valor = Convert.ToDecimal(_valor);
            string valorstring, formato;
            if (decimales > 0)
            {
                formato = "0.";
                formato = formato.PadRight(formato.Length + decimales, '0');
            }
            else
            {
                formato = "0";
            }
            valorstring = valor.ToString(formato, System.Globalization.CultureInfo.InvariantCulture);
            valorstring = valorstring.Replace(".", "");
            valorstring = valorstring.PadLeft(total, '0');
            return valorstring;
        }

        public static decimal DecValConDec(string valcad, int dec)
        {
            decimal valor = 0;
            decimal factor;
            factor = Convert.ToDecimal(Math.Pow(10, dec));
            if (decimal.TryParse(valcad, out valor))
            {
                valor = valor / factor;
            }
            return valor;
        }

        public static string CadEsp(object _valor, int total)
        {
            string valorstring;
            valorstring = Convert.ToString(_valor).Trim();
            valorstring = valorstring.PadRight(total).Substring(0, total);
            return valorstring;
        }

        public static bool TablaVacia(DataTable tabla)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Serialize<T>(T value)
        {
            if (value == null)
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
            settings.Indent = false;
            settings.OmitXmlDeclaration = false;

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, value);
                }
                return textWriter.ToString();
            }
        }

        public static T Deserialize<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
            {
                return default(T);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            XmlReaderSettings settings = new XmlReaderSettings();
            // No settings need modifying here

            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (T)serializer.Deserialize(xmlReader);
                }
            }
        }

        public static List<T> ParseDataTable<T>(DataTable data)
        {
            List<T> lista = new List<T>();

            String[] columnas = new String[data.Columns.Count];
            int i = 0;
            foreach (DataColumn c in data.Columns)
            {
                columnas[i] = c.ColumnName;
                i++;
            }


            // iterando por cada fila de registro
            foreach (DataRow r in data.Rows)
            {
                Object ubig = Activator.CreateInstance(typeof(T));

                foreach (string col in columnas)
                {
                    Object obj = null;
                    obj = r[col];
                    Type t = ubig.GetType();
                    PropertyInfo prop = GetPropertyObject(t, col);
                    if (prop != null) //20151130 parche por si existen campos que no estan en la clase
                    {
                        prop.SetValue(ubig, ParseObject(obj, prop.PropertyType), null);
                    }
                    else
                    {
                        //mlr 20151223
                        //throw new Exception("No se encuentra la propiedad: " + col + " en la entidad: " + t.FullName);
                    }
                }

                lista.Add((T)ubig);
            }

            return lista;
        }

        /// <summary>
        /// Funcion utilitaria para el parseo
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="tDestino"></param>
        /// <returns></returns>
        private static Object ParseObject(Object obj, Type tDestino)
        {
            Object resp = null;
            resp = obj;

            if (resp is System.DBNull)
            {
                if (tDestino == typeof(System.Decimal))
                {
                    resp = Convert.ToDecimal(0);
                }
                else if (tDestino == typeof(System.Int32))
                {
                    resp = Convert.ToInt32(0);
                }
                else if (tDestino == typeof(System.Int64))
                {
                    resp = Convert.ToInt64(0);
                }
                else if (tDestino == typeof(System.Double))
                {
                    resp = Convert.ToDouble(0);
                }
                else if (tDestino == typeof(System.DateTime))
                {
                    resp = null;
                }
                else if (tDestino == typeof(System.Nullable<DateTime>))
                {
                    resp = null;
                }
                else if (tDestino == typeof(System.Char))
                {
                    resp = ' ';
                }
                else if (tDestino == typeof(System.Nullable<Char>))
                {
                    resp = null;
                }
                else if (tDestino == typeof(System.String))
                {
                    resp = null;
                }
                else if (tDestino == typeof(System.Boolean))
                {
                    resp = false;
                }
                else if (tDestino == typeof(System.Nullable<Int32>))
                {
                    resp = null;
                }
                else if (tDestino == typeof(System.Nullable<Double>))
                {
                    resp = null;
                }
                else
                {
                    resp = null;
                }

            }

            if (obj is System.Decimal)
            {
                if (tDestino == typeof(System.Int32))
                {
                    resp = Convert.ToInt32(obj);
                }

                if (tDestino == typeof(System.Int64))
                {
                    resp = Convert.ToInt64(obj);
                }

                if (tDestino == typeof(System.Double))
                {
                    resp = Convert.ToDouble(obj);
                }

                if (tDestino == typeof(System.Nullable<Double>))
                {
                    resp = Convert.ToDouble(obj);
                }
            }

            if (obj is System.String)
            {
                if (tDestino == typeof(System.String))
                {
                    resp = Convert.ToString(obj).Trim();
                }

                if (tDestino == typeof(System.Char))
                {
                    resp = Convert.ToChar(obj);
                }
                if (tDestino == typeof(System.Char?))
                {
                    if (string.IsNullOrEmpty(Convert.ToString(obj)))
                    {
                        resp = null;
                    }
                    else
                    {
                        resp = Convert.ToChar(obj);
                    }
                }
            }


            return resp;

        }

        /// <summary>
        /// Funcion utilitaria para el parseo de tipos obtenidos desde el dataset y transformarlos 
        /// a objetos usados en las propiedades de la clase
        /// </summary>
        /// <param name="t"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private static PropertyInfo GetPropertyObject(Type t, String column)
        {

            PropertyInfo propInfo = null;

            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo p in properties)
            {
                if (p.Name.ToUpper().Equals(column.ToUpper().Trim()))
                {
                    propInfo = p;
                    break;
                }
            }

            return propInfo;
        }

        public static bool IsOneOf(string value, params string[] items)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                if (items[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsOneOf2<T>(T value, params T[] items)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                if (items[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public static Object FormatDate(DateTime? date)
        {
            if (date != null)
            {
                DateTime newDate = date ?? DateTime.MinValue;
                string formatDate = newDate.Year.ToString("0000") + "-" + newDate.Month.ToString("00") + "-" + newDate.Day.ToString("00") +
                "T" + newDate.Hour.ToString("00") + ":" + newDate.Minute.ToString("00") + ":" + newDate.Second.ToString("00");
                return formatDate;
            }
            else
            {
                return DBNull.Value;
            }
        }


        public static DataTable DecompressDataTable(byte[] compressedData)
        {
            if (compressedData == null)
                throw new ArgumentNullException(nameof(compressedData));

            // Descomprimir XML
            using (MemoryStream compressedStream = new MemoryStream(compressedData))
            {
                using (GZipStream gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    using (MemoryStream xmlStream = new MemoryStream())
                    {
                        gzipStream.CopyTo(xmlStream);
                        xmlStream.Position = 0;

                        // Deserializar DataTable desde XML
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataTable));
                        return (DataTable)xmlSerializer.Deserialize(xmlStream)!;
                    }
                }
            }
        }

        public  object DbNullIf(object value)
        {
            if (value == null)
                return DBNull.Value;

            if (value is string s)
                return string.IsNullOrWhiteSpace(s) || s == "*" ? DBNull.Value : s;

            if (value is int i)
                return i == 0 ? DBNull.Value : i;

            if (value is short sh)
                return sh == 0 ? DBNull.Value : sh;

            return value;
        }
    }
}
