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
    
    
    public partial class TablaDao : DataAccessBase
    {
        
        public virtual CTabla getTabla(DataRow dr)
        {
            return new CTabla(Convert.ToString(dr["CodTabla"]),Convert.ToString(dr["Nom_Tabla"]),Convert.ToString(dr["DesTabla"]),Convert.ToString(dr["CodPadre"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Campo1"]),Convert.ToString(dr["Campo2"]),Convert.ToString(dr["Cod_Producto_Sunat"]),Convert.ToString(dr["Obs_Tabla"]));
        }
        
        public virtual CTabla getTabla(IDataReader dr)
        {
            return new CTabla(Convert.ToString(dr["CodTabla"]),Convert.ToString(dr["Nom_Tabla"]),Convert.ToString(dr["DesTabla"]),Convert.ToString(dr["CodPadre"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Campo1"]),Convert.ToString(dr["Campo2"]),Convert.ToString(dr["Cod_Producto_Sunat"]),Convert.ToString(dr["Obs_Tabla"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CTabla oTabla)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Tabla_Guardar")){
            Db.AddInParameter(dbCmd, "CodTabla", DbType.String, oTabla.CodTabla);
            Db.AddInParameter(dbCmd, "Nom_Tabla", DbType.String, oTabla.Nom_Tabla);
            Db.AddInParameter(dbCmd, "DesTabla", DbType.String, oTabla.DesTabla);
            Db.AddInParameter(dbCmd, "CodPadre", DbType.String, oTabla.CodPadre);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oTabla.Estado);
            Db.AddInParameter(dbCmd, "Campo1", DbType.String, oTabla.Campo1);
            Db.AddInParameter(dbCmd, "Campo2", DbType.String, oTabla.Campo2);
            Db.AddInParameter(dbCmd, "Cod_Producto_Sunat", DbType.String, oTabla.Cod_Producto_Sunat);
            Db.AddInParameter(dbCmd, "Obs_Tabla", DbType.String, oTabla.Obs_Tabla);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodTabla)
        {
            return Db.ExecuteNonQuery("Global.spu_Tabla_Eliminar",CodTabla);
        }
        
        public virtual CTabla Recuperar(String CodTabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Tabla_Recuperar",CodTabla).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTabla(dtDatos.Rows[0]);
            else
            return new CTabla();
        }
        
        public virtual bool Existe(String CodTabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Tabla_Recuperar",CodTabla).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodTabla, out CTabla oTabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Tabla_Recuperar",CodTabla).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oTabla = getTabla(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oTabla = new CTabla();
            return false;
            }
        }
        
        public virtual IList<CTabla> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.spu_Tabla_Listar")){
            IList<CTabla> list = new List<CTabla>();
            while (dr.Read())
            list.Add(getTabla(dr));
            return list;
            }
        }
        #endregion
    }
}
