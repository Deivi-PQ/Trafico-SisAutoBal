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
    
    
    public partial class Evento_ModuloDao : DataAccessBase
    {
        
        public virtual CEvento_Modulo getEvento_Modulo(DataRow dr)
        {
            return new CEvento_Modulo(Convert.ToInt32(dr["IDEvento_Mod"]),Convert.ToString(dr["Modulo"]),Convert.ToString(dr["Des_Evento"]),Convert.ToChar(dr["Tipo_Evento"]),Convert.ToString(dr["Usuario"]),Convert.ToDateTime(dr["FechaHora"]));
        }
        
        public virtual CEvento_Modulo getEvento_Modulo(IDataReader dr)
        {
            return new CEvento_Modulo(Convert.ToInt32(dr["IDEvento_Mod"]),Convert.ToString(dr["Modulo"]),Convert.ToString(dr["Des_Evento"]),Convert.ToChar(dr["Tipo_Evento"]),Convert.ToString(dr["Usuario"]),Convert.ToDateTime(dr["FechaHora"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CEvento_Modulo oEvento_Modulo)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Auditoria.spu_Evento_Modulo_Guardar")){
            Db.AddInParameter(dbCmd, "IDEvento_Mod", DbType.Int32, oEvento_Modulo.IDEvento_Mod);
            Db.AddInParameter(dbCmd, "Modulo", DbType.String, oEvento_Modulo.Modulo);
            Db.AddInParameter(dbCmd, "Des_Evento", DbType.String, oEvento_Modulo.Des_Evento);
            Db.AddInParameter(dbCmd, "Tipo_Evento", DbType.String, oEvento_Modulo.Tipo_Evento);
            Db.AddInParameter(dbCmd, "Usuario", DbType.String, oEvento_Modulo.Usuario);
            Db.AddInParameter(dbCmd, "FechaHora", DbType.DateTime, oEvento_Modulo.FechaHora);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDEvento_Mod)
        {
            return Db.ExecuteNonQuery("Auditoria.spu_Evento_Modulo_Eliminar",IDEvento_Mod);
        }
        
        public virtual CEvento_Modulo Recuperar(Int32 IDEvento_Mod)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Evento_Modulo_Recuperar",IDEvento_Mod).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getEvento_Modulo(dtDatos.Rows[0]);
            else
            return new CEvento_Modulo();
        }
        
        public virtual bool Existe(Int32 IDEvento_Mod)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Evento_Modulo_Recuperar",IDEvento_Mod).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDEvento_Mod, out CEvento_Modulo oEvento_Modulo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Evento_Modulo_Recuperar",IDEvento_Mod).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oEvento_Modulo = getEvento_Modulo(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oEvento_Modulo = new CEvento_Modulo();
            return false;
            }
        }
        
        public virtual IList<CEvento_Modulo> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Auditoria.spu_Evento_Modulo_Listar")){
            IList<CEvento_Modulo> list = new List<CEvento_Modulo>();
            while (dr.Read())
            list.Add(getEvento_Modulo(dr));
            return list;
            }
        }
        #endregion
    }
}
