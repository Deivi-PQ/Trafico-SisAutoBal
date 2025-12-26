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
using Trafico.BusinessObjects.AutoBal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.AutoBal
{
    
    
    public partial class Datos_RFIDDao : DataAccessBase
    {
        
        public virtual CDatos_RFID getDatos_RFID(DataRow dr)
        {
            return new CDatos_RFID(Convert.ToInt64(dr["ID"]),Convert.ToString(dr["SN"]),Convert.ToDateTime(dr["Time"]),Convert.ToString(dr["Pin"]),Convert.ToString(dr["Card"]),Convert.ToBoolean(dr["flagProcesado"]));
        }
        
        public virtual CDatos_RFID getDatos_RFID(IDataReader dr)
        {
            return new CDatos_RFID(Convert.ToInt64(dr["ID"]),Convert.ToString(dr["SN"]),Convert.ToDateTime(dr["Time"]),Convert.ToString(dr["Pin"]),Convert.ToString(dr["Card"]),Convert.ToBoolean(dr["flagProcesado"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CDatos_RFID oDatos_RFID)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.spu_Datos_RFID_Guardar")){
            Db.AddInParameter(dbCmd, "ID", DbType.Int64, oDatos_RFID.ID);
            Db.AddInParameter(dbCmd, "SN", DbType.String, oDatos_RFID.SN);
            Db.AddInParameter(dbCmd, "Time", DbType.DateTime, oDatos_RFID.Time);
            Db.AddInParameter(dbCmd, "Pin", DbType.String, oDatos_RFID.Pin);
            Db.AddInParameter(dbCmd, "Card", DbType.String, oDatos_RFID.Card);
            Db.AddInParameter(dbCmd, "flagProcesado", DbType.Boolean, oDatos_RFID.flagProcesado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int64 ID)
        {
            return Db.ExecuteNonQuery("AutoBal.spu_Datos_RFID_Eliminar",ID);
        }
        
        public virtual CDatos_RFID Recuperar(Int64 ID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Datos_RFID_Recuperar",ID).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getDatos_RFID(dtDatos.Rows[0]);
            else
            return new CDatos_RFID();
        }
        
        public virtual bool Existe(Int64 ID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Datos_RFID_Recuperar",ID).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int64 ID, out CDatos_RFID oDatos_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Datos_RFID_Recuperar",ID).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oDatos_RFID = getDatos_RFID(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oDatos_RFID = new CDatos_RFID();
            return false;
            }
        }
        
        public virtual IList<CDatos_RFID> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"AutoBal.spu_Datos_RFID_Listar")){
            IList<CDatos_RFID> list = new List<CDatos_RFID>();
            while (dr.Read())
            list.Add(getDatos_RFID(dr));
            return list;
            }
        }
        #endregion
    }
}
