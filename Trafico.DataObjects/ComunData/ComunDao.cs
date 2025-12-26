using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Trafico.BusinessObjects.Comun;

namespace Trafico.DataObjects.ComunData
{
    public class ComunDao
    {
        Database Db;

        #region Constructores
        /// <summary>
        /// Conexitividad por defecto
        /// </summary>        
        public ComunDao()
        {
            Db = DatabaseFactory.CreateDatabase(DataAccessFactory.getVarConexion());
        }
        #endregion Constructores

        #region Metodos Comunes
        /// <summary>
        /// Busqueda de registros. Devuelve un datatable con los parametros solicitados
        /// </summary>
        /// <param name="atributos"></param>
        /// <param name="nombreTabla"></param>
        /// <param name="condicion"></param>
        /// <param name="atributoClave"></param>
        /// <param name="valorBusqueda"></param>
        /// <param name="tipo"></param>
        /// <param name="nroRegistrosMostrar"></param>
        /// <param name="Orden"></param>
        /// <returns></returns>
        public DataTable getBuscar_Registros(string atributos, string nombreTabla, string condicion, 
            string atributoClave, string valorBusqueda, string tipo, int? nroRegistrosMostrar,
            string Orden)
        {
            // --- Creando cadena de consulta de busqueda de registros
            StringBuilder sql = new StringBuilder();
            sql.Append("exec spu_Lib_Buscar_Registros ");
            sql.Append("@Atributos = '"+atributos+"', ");
            sql.Append("@NombreTabla = '"+nombreTabla+"', ");
            sql.Append("@Condicion = '"+condicion+"', ");
            sql.Append("@AtributoClave = '"+atributoClave+"', ");
            sql.Append("@ValorBusqueda = '" + valorBusqueda + "', ");
            
            // --- verificando si se desea ver todos
            if (nroRegistrosMostrar!=null)
                sql.Append("@NroRegistrosMostrar = " + nroRegistrosMostrar.ToString() + ", ");

            // --- verificando si se desea ver todos
            if (Orden != null)
                sql.Append("@Orden = '" + Orden + "', ");

            sql.Append("@Tipo = '"+tipo+"'");
                            
            // --- Ejecutando consulta
            return Db.ExecuteDataSet(CommandType.Text, sql.ToString()).Tables[0];
        }

        /// <summary>
        /// Busqueda de registros. Devuelve un datatable con los parametros solicitados
        /// </summary>
        /// <param name="atributos"></param>
        /// <param name="nombreTabla"></param>
        /// <param name="condicion"></param>
        /// <param name="atributoClave"></param>
        /// <param name="valorBusqueda"></param>
        /// <param name="tipo"></param>
        /// <param name="nroRegistrosMostrar"></param>
        /// <returns></returns>
        public DataTable getBuscar_Registros(string atributos, string nombreTabla, string condicion,
            string atributoClave, string valorBusqueda, string tipo, int? nroRegistrosMostrar)
        {
            // --- Ejecutando consulta
            return getBuscar_Registros(atributos, nombreTabla, condicion,
                atributoClave, valorBusqueda, tipo, nroRegistrosMostrar, null);
        }

        /// <summary>
        /// Ejecuta una consulta sql
        /// </summary>
        /// <param name="ConsultaSql"></param>
        /// <returns></returns>
        public DataTable getDataTable(string ConsultaSql)
        {
            // --- Ejecutando consulta
            return Db.ExecuteDataSet(CommandType.Text, ConsultaSql).Tables[0];
        }

        /// <summary>
        /// Ejecuta una consulta sql a partir de un procedimiento almacenado
        /// </summary>
        /// <param name="ConsultaSql"></param>
        /// <returns></returns>
        public DataTable getDataTable(string NombreProcedimiento, params object[] parametros)
        {
            // --- Ejecutando consulta
            return Db.ExecuteDataSet(NombreProcedimiento, parametros).Tables[0];
        }

        public virtual IList<CParametroSP> getParametros_Procedimiento_Almacenado(string nombre_procedimiento)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select pa.name as Nombre_Variable, pa.parameter_id, pa.system_type_id, ");
            sql.Append("(Select T1.Name ");
            sql.Append("From sys.Types T1 ");
            sql.Append("Where T1.system_type_id = pa.system_type_id and ");
            sql.Append("T1.system_type_id = T1.user_type_id) as Tipo ");
            sql.Append("from sys.procedures p, sys.all_parameters pa ");
            sql.Append("where p.object_id = pa.object_id and ");
            sql.Append("p.name='"+nombre_procedimiento+"' ");
            sql.Append("order by pa.parameter_id ");

            using (IDataReader dr = Db.ExecuteReader(CommandType.Text, sql.ToString()))
            {
                IList<CParametroSP> list = new List<CParametroSP>();
                while (dr.Read())
                {
                    list.Add(new CParametroSP(
                        Convert.ToString(dr["Nombre_Variable"]),
                        "",
                        Convert.ToString(dr["Tipo"])));
                } return list;
            }
        }

        #endregion Metodos Comunes
        

    }
}
