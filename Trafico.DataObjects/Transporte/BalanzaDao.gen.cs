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
using Trafico.BusinessObjects.Transporte;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Transporte
{
    
    
    public partial class BalanzaDao : DataAccessBase
    {
        
        public virtual CBalanza getBalanza(DataRow dr)
        {
            return new CBalanza(
                dr["IDBalanza"] == DBNull.Value ? "" : dr["IDBalanza"].ToString(),
                dr["Des_Balanza"] == DBNull.Value ? "" : dr["Des_Balanza"].ToString(),
                dr["Tipo"] == DBNull.Value ? "" : dr["Tipo"].ToString(),
                dr["UserNew"] == DBNull.Value ? "" : dr["UserNew"].ToString(),
                dr["DateNew"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateNew"]),
                dr["UserEdit"] == DBNull.Value ? "" : dr["UserEdit"].ToString(),
                dr["DateEdit"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateEdit"]),
                dr["Estado"] == DBNull.Value ? 'T' : Convert.ToChar(dr["Estado"]),
                dr["SN_Contr"] == DBNull.Value ? "" : dr["SN_Contr"].ToString()
            );
        }
        
        public virtual CBalanza getBalanza(IDataReader dr)
        {
            return new CBalanza(
                dr["IDBalanza"] == DBNull.Value ? "" : dr["IDBalanza"].ToString(),
                dr["Des_Balanza"] == DBNull.Value ? "" : dr["Des_Balanza"].ToString(),
                dr["Tipo"] == DBNull.Value ? "" : dr["Tipo"].ToString(),
                dr["UserNew"] == DBNull.Value ? "" : dr["UserNew"].ToString(),
                dr["DateNew"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateNew"]),
                dr["UserEdit"] == DBNull.Value ? "" : dr["UserEdit"].ToString(),
                dr["DateEdit"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateEdit"]),
                dr["Estado"] == DBNull.Value ? 'T' : Convert.ToChar(dr["Estado"]),
                dr["SN_Contr"] == DBNull.Value ? "" : dr["SN_Contr"].ToString()
            );
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CBalanza oBalanza)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Balanza_Guardar")){
            Db.AddInParameter(dbCmd, "IDBalanza", DbType.String, oBalanza.IDBalanza);
            Db.AddInParameter(dbCmd, "Des_Balanza", DbType.String, oBalanza.Des_Balanza);
            Db.AddInParameter(dbCmd, "Tipo", DbType.String, oBalanza.Tipo);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oBalanza.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oBalanza.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oBalanza.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oBalanza.DateEdit);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oBalanza.Estado);
            Db.AddInParameter(dbCmd, "SN_Contr", DbType.String, oBalanza.SN_Contr);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String IDBalanza)
        {
            return Db.ExecuteNonQuery("Transporte.spu_Balanza_Eliminar",IDBalanza);
        }
        
        public virtual CBalanza Recuperar(String IDBalanza)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Balanza_Recuperar",IDBalanza).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getBalanza(dtDatos.Rows[0]);
            else
                return new CBalanza();
        }
        
        public virtual bool Existe(String IDBalanza)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Balanza_Recuperar",IDBalanza).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String IDBalanza, out CBalanza oBalanza)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Balanza_Recuperar",IDBalanza).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oBalanza = getBalanza(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oBalanza = new CBalanza();
                return false;
            }
        }
        
        public virtual IList<CBalanza> Listar(String Des_Balanza, String Tipo, String Estado, String SN_Contr)
        {

            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Balanza_Listar"))
            {
                Db.AddInParameter(dbCmd, "Des_Balanza", DbType.String, Des_Balanza == "" ? DBNull.Value : Des_Balanza);
                Db.AddInParameter(dbCmd, "Tipo", DbType.String, Tipo == "" ? DBNull.Value : Tipo);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, Estado == "" ? DBNull.Value : Estado);
                Db.AddInParameter(dbCmd, "SN_Contr", DbType.String, SN_Contr == "" ? DBNull.Value : SN_Contr);
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CBalanza> list = new List<CBalanza>();
                    while (dr.Read())
                        list.Add(getBalanza(dr));
                    return list;
                }
            }
        }
        #endregion
    }
}
