//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Trafico.BusinessObjects.Config;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Config
{
    
    
    public partial class Configuracion_UsuarioDao : DataAccessBase
    {
        
        public virtual CConfiguracion_Usuario getConfiguracion_Usuario(DataRow dr)
        {
            return new CConfiguracion_Usuario(Convert.ToString(dr["IDUsuario"]),Convert.ToString(dr["Nombre_Variable"]),Convert.ToString(dr["Valor_Variable"]),Convert.ToInt32(dr["Trafico_IDUsuario"]));
        }
        
        public virtual CConfiguracion_Usuario getConfiguracion_Usuario(IDataReader dr)
        {
            return new CConfiguracion_Usuario(Convert.ToString(dr["IDUsuario"]),Convert.ToString(dr["Nombre_Variable"]),Convert.ToString(dr["Valor_Variable"]),Convert.ToInt32(dr["Trafico_IDUsuario"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Config.spu_Configuracion_Usuario_Guardar")){
            Db.AddInParameter(dbCmd, "IDUsuario", DbType.String, oConfiguracion_Usuario.IDUsuario);
            Db.AddInParameter(dbCmd, "Nombre_Variable", DbType.String, oConfiguracion_Usuario.Nombre_Variable);
            Db.AddInParameter(dbCmd, "Valor_Variable", DbType.String, oConfiguracion_Usuario.Valor_Variable);
            Db.AddInParameter(dbCmd, "Trafico_IDUsuario", DbType.Int32, oConfiguracion_Usuario.Trafico_IDUsuario);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String IDUsuario, String Nombre_Variable)
        {
            return Db.ExecuteNonQuery("Config.spu_Configuracion_Usuario_Eliminar",IDUsuario,Nombre_Variable);
        }
        
        public virtual CConfiguracion_Usuario Recuperar(String IDUsuario, String Nombre_Variable)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Config.spu_Configuracion_Usuario_Recuperar",IDUsuario,Nombre_Variable).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getConfiguracion_Usuario(dtDatos.Rows[0]);
            else
            return new CConfiguracion_Usuario();
        }
        
        public virtual bool Existe(String IDUsuario, String Nombre_Variable)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Config.spu_Configuracion_Usuario_Recuperar",IDUsuario,Nombre_Variable).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String IDUsuario, String Nombre_Variable, out CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Config.spu_Configuracion_Usuario_Recuperar",IDUsuario,Nombre_Variable).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oConfiguracion_Usuario = getConfiguracion_Usuario(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oConfiguracion_Usuario = new CConfiguracion_Usuario();
            return false;
            }
        }
        
        public virtual IList<CConfiguracion_Usuario> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Config.spu_Configuracion_Usuario_Listar")){
            IList<CConfiguracion_Usuario> list = new List<CConfiguracion_Usuario>();
            while (dr.Read())
            list.Add(getConfiguracion_Usuario(dr));
            return list;
            }
        }
        #endregion
    }
}
