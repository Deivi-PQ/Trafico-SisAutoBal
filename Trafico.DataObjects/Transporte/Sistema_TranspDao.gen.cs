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
    
    
    public partial class Sistema_TranspDao : DataAccessBase
    {
        
        public virtual CSistema_Transp getSistema_Transp(DataRow dr)
        {
            return new CSistema_Transp(Convert.ToString(dr["Cod_Sis_Transp"]),Convert.ToString(dr["Des_Sis_Transp"]),Convert.ToInt16(dr["NroPlacas"]),Convert.ToChar(dr["Estado"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["UserEdit"]));
        }
        
        public virtual CSistema_Transp getSistema_Transp(IDataReader dr)
        {
            return new CSistema_Transp(Convert.ToString(dr["Cod_Sis_Transp"]),Convert.ToString(dr["Des_Sis_Transp"]),Convert.ToInt16(dr["NroPlacas"]),Convert.ToChar(dr["Estado"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["UserEdit"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CSistema_Transp oSistema_Transp)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Sistema_Transp_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Sis_Transp", DbType.String, oSistema_Transp.Cod_Sis_Transp);
            Db.AddInParameter(dbCmd, "Des_Sis_Transp", DbType.String, oSistema_Transp.Des_Sis_Transp);
            Db.AddInParameter(dbCmd, "NroPlacas", DbType.Int16, oSistema_Transp.NroPlacas);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oSistema_Transp.Estado);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oSistema_Transp.DateNew);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oSistema_Transp.UserNew);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oSistema_Transp.DateEdit);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oSistema_Transp.UserEdit);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Sis_Transp)
        {
            return Db.ExecuteNonQuery("Transporte.spu_Sistema_Transp_Eliminar",Cod_Sis_Transp);
        }
        
        public virtual CSistema_Transp Recuperar(String Cod_Sis_Transp)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Sistema_Transp_Recuperar",Cod_Sis_Transp).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getSistema_Transp(dtDatos.Rows[0]);
            else
            return new CSistema_Transp();
        }
        
        public virtual bool Existe(String Cod_Sis_Transp)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Sistema_Transp_Recuperar",Cod_Sis_Transp).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Sis_Transp, out CSistema_Transp oSistema_Transp)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Sistema_Transp_Recuperar",Cod_Sis_Transp).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oSistema_Transp = getSistema_Transp(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oSistema_Transp = new CSistema_Transp();
            return false;
            }
        }
        
        public virtual IList<CSistema_Transp> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Transporte.spu_Sistema_Transp_Listar")){
            IList<CSistema_Transp> list = new List<CSistema_Transp>();
            while (dr.Read())
            list.Add(getSistema_Transp(dr));
            return list;
            }
        }
        #endregion
    }
}
