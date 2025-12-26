//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using LibreriaBSNetCore;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Trafico.BusinessObjects.AutoBal;
using Trafico.BusinessObjects.Seguridad;

namespace Trafico.DataObjects.AutoBal
{
    
    
    public partial class Tag_RFIDDao : DataAccessBase
    {
        
        public virtual CTag_RFID getTag_RFID(DataRow dr)
        {
            return new CTag_RFID(
                dr["Cod_RFID"] == DBNull.Value ? null : dr["Cod_RFID"].ToString(),
                dr["Nro_Placa"] == DBNull.Value ? null : dr["Nro_Placa"].ToString(),
                dr["DateNew"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateNew"]),
                dr["DateEdit"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateEdit"]),
                dr["UserNew"] == DBNull.Value ? null : dr["UserNew"].ToString(),
                dr["UserEdit"] == DBNull.Value ? null : dr["UserEdit"].ToString()
            );
        }
        
        public virtual CTag_RFID getTag_RFID(IDataReader dr)
        {
            return new CTag_RFID(
                dr["Cod_RFID"] == DBNull.Value ? null : dr["Cod_RFID"].ToString(),
                dr["Nro_Placa"] == DBNull.Value ? null : dr["Nro_Placa"].ToString(),
                dr["DateNew"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateNew"]),
                dr["DateEdit"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateEdit"]),
                dr["UserNew"] == DBNull.Value ? null : dr["UserNew"].ToString(),
                dr["UserEdit"] == DBNull.Value ? null : dr["UserEdit"].ToString()
            );
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CTag_RFID oTag_RFID)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.spu_Tag_RFID_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_RFID", DbType.String, oTag_RFID.Cod_RFID);
            Db.AddInParameter(dbCmd, "Nro_Placa", DbType.String, oTag_RFID.Nro_Placa);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oTag_RFID.DateNew);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oTag_RFID.DateEdit);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oTag_RFID.UserNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oTag_RFID.UserEdit);
            // --- Ejecutando procedimiento almacenado
             return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_RFID)
        {
            return Db.ExecuteNonQuery("AutoBal.spu_Tag_RFID_Eliminar",Cod_RFID);
        }
        
        public virtual CTag_RFID Recuperar(String Cod_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Tag_RFID_Recuperar",Cod_RFID).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTag_RFID(dtDatos.Rows[0]);
            else
            return new CTag_RFID();
        }
        
        public virtual bool Existe(String Cod_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Tag_RFID_Recuperar",Cod_RFID).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_RFID, out CTag_RFID oTag_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Tag_RFID_Recuperar",Cod_RFID).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oTag_RFID = getTag_RFID(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oTag_RFID = new CTag_RFID();
                return false;
            }
        }
        
        public virtual IList<CTag_RFID> Listar(String Cod_RFID, String Nro_Placa)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.spu_Tag_RFID_Listar"))
            {
                Db.AddInParameter(dbCmd, "Cod_RFID", DbType.String, (object)(string.IsNullOrEmpty(Cod_RFID) ? DBNull.Value : (object)Cod_RFID));
                Db.AddInParameter(dbCmd, "Nro_Placa", DbType.String, (object)(string.IsNullOrEmpty(Nro_Placa) ? DBNull.Value : (object)Nro_Placa));
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CTag_RFID> list = new List<CTag_RFID>();
                    while (dr.Read())
                        list.Add(getTag_RFID(dr));
                    return list;
                }
            }
        }
        #endregion
    }
}
