//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 17 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Trafico.BusinessObjects.AutoBal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.AutoBal
{
    
    
    public partial class ComandosDao : DataAccessBase
    {
        
        public virtual Comandos getomandos(DataRow dr)
        {
            return new Comandos(Convert.ToInt32(dr["id"]),Convert.ToString(dr["sn"]),Convert.ToString(dr["comando"]),Convert.ToString(dr["estado"]),Convert.ToDateTime(dr["ttime"]));
        }
        
        public virtual Comandos getomandos(IDataReader dr)
        {
            return new Comandos(Convert.ToInt32(dr["id"]),Convert.ToString(dr["sn"]),Convert.ToString(dr["comando"]),Convert.ToString(dr["estado"]),Convert.ToDateTime(dr["ttime"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(Comandos oomandos)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.spu_Comandos_Guardar")){
            Db.AddInParameter(dbCmd, "id", DbType.Int32, oomandos.id);
            Db.AddInParameter(dbCmd, "sn", DbType.String, oomandos.sn);
            Db.AddInParameter(dbCmd, "comando", DbType.String, oomandos.comando);
            Db.AddInParameter(dbCmd, "estado", DbType.String, oomandos.estado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 id)
        {
            return Db.ExecuteNonQuery("AutoBal.omandos_Eliminar",id);
        }
        
        public virtual Comandos Recuperar(String sn)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Comandos_Recuperar",sn).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getomandos(dtDatos.Rows[0]);
            else
            return new Comandos();
        }
        
        public virtual bool Existe(Int32 id)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Comandos_Recuperar", id).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 id, out Comandos oomandos)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Comandos_Recuperar", id).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oomandos = getomandos(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oomandos = new Comandos();
            return false;
            }
        }
        
        public virtual IList<Comandos> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "AutoBal.spu_Comandos_Listar")){
            IList<Comandos> list = new List<Comandos>();
            while (dr.Read())
            list.Add(getomandos(dr));
            return list;
            }
        }
        #endregion
    }
}
