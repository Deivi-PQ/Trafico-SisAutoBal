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
using Trafico.BusinessObjects.Auditoria;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Auditoria
{
    
    
    public partial class Acceso_ModuloDao : DataAccessBase
    {
        
        public virtual CAcceso_Modulo getAcceso_Modulo(DataRow dr)
        {
            return new CAcceso_Modulo(Convert.ToInt32(dr["IDAcceso_Mod"]),Convert.ToString(dr["Nombre_Pagina"]),Convert.ToDateTime(dr["FechaHora"]),Convert.ToString(dr["Usuario"]));
        }
        
        public virtual CAcceso_Modulo getAcceso_Modulo(IDataReader dr)
        {
            return new CAcceso_Modulo(Convert.ToInt32(dr["IDAcceso_Mod"]),Convert.ToString(dr["Nombre_Pagina"]),Convert.ToDateTime(dr["FechaHora"]),Convert.ToString(dr["Usuario"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CAcceso_Modulo oAcceso_Modulo)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Auditoria.spu_Acceso_Modulo_Guardar")){
            Db.AddInParameter(dbCmd, "IDAcceso_Mod", DbType.Int32, oAcceso_Modulo.IDAcceso_Mod);
            Db.AddInParameter(dbCmd, "Nombre_Pagina", DbType.String, oAcceso_Modulo.Nombre_Pagina);
            Db.AddInParameter(dbCmd, "FechaHora", DbType.DateTime, oAcceso_Modulo.FechaHora);
            Db.AddInParameter(dbCmd, "Usuario", DbType.String, oAcceso_Modulo.Usuario);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDAcceso_Mod)
        {
            return Db.ExecuteNonQuery("Auditoria.spu_Acceso_Modulo_Eliminar",IDAcceso_Mod);
        }
        
        public virtual CAcceso_Modulo Recuperar(Int32 IDAcceso_Mod)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Acceso_Modulo_Recuperar",IDAcceso_Mod).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getAcceso_Modulo(dtDatos.Rows[0]);
            else
            return new CAcceso_Modulo();
        }
        
        public virtual bool Existe(Int32 IDAcceso_Mod)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Acceso_Modulo_Recuperar",IDAcceso_Mod).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDAcceso_Mod, out CAcceso_Modulo oAcceso_Modulo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Acceso_Modulo_Recuperar",IDAcceso_Mod).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oAcceso_Modulo = getAcceso_Modulo(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oAcceso_Modulo = new CAcceso_Modulo();
            return false;
            }
        }
        
        public virtual IList<CAcceso_Modulo> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Auditoria.spu_Acceso_Modulo_Listar")){
            IList<CAcceso_Modulo> list = new List<CAcceso_Modulo>();
            while (dr.Read())
            list.Add(getAcceso_Modulo(dr));
            return list;
            }
        }
        #endregion
    }
}
