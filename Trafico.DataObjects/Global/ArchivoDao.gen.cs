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
using Trafico.BusinessObjects.Global;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Global
{
    
    
    public partial class ArchivoDao : DataAccessBase
    {
        
        public virtual CArchivo getArchivo(DataRow dr)
        {
            return new CArchivo(Convert.ToString(dr["Cod_Archivo"]),Convert.ToString(dr["Nombre_Archivo"]),Convert.ToBoolean(dr["Archivo"]));
        }
        
        public virtual CArchivo getArchivo(IDataReader dr)
        {
            return new CArchivo(Convert.ToString(dr["Cod_Archivo"]),Convert.ToString(dr["Nombre_Archivo"]),Convert.ToBoolean(dr["Archivo"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CArchivo oArchivo)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Archivo_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Archivo", DbType.String, oArchivo.Cod_Archivo);
            Db.AddInParameter(dbCmd, "Nombre_Archivo", DbType.String, oArchivo.Nombre_Archivo);
            Db.AddInParameter(dbCmd, "Archivo", DbType.Boolean, oArchivo.Archivo);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Archivo)
        {
            return Db.ExecuteNonQuery("Global.spu_Archivo_Eliminar",Cod_Archivo);
        }
        
        public virtual CArchivo Recuperar(String Cod_Archivo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Archivo_Recuperar",Cod_Archivo).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getArchivo(dtDatos.Rows[0]);
            else
            return new CArchivo();
        }
        
        public virtual bool Existe(String Cod_Archivo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Archivo_Recuperar",Cod_Archivo).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Archivo, out CArchivo oArchivo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Archivo_Recuperar",Cod_Archivo).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oArchivo = getArchivo(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oArchivo = new CArchivo();
            return false;
            }
        }
        
        public virtual IList<CArchivo> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.spu_Archivo_Listar")){
            IList<CArchivo> list = new List<CArchivo>();
            while (dr.Read())
            list.Add(getArchivo(dr));
            return list;
            }
        }
        #endregion
    }
}
