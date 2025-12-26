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
using Trafico.BusinessObjects.Concentrado;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Concentrado
{
    
    
    public partial class Lote_ConcentradoDao : DataAccessBase
    {
        
        public virtual CLote_Concentrado getLote_Concentrado(DataRow dr)
        {
            return new CLote_Concentrado(Convert.ToString(dr["Nro_Lote"]),Convert.ToDateTime(dr["Fecha_Inicio_Vigencia"]),Convert.ToDateTime(dr["Fecha_Fin_Vigencia"]),Convert.ToString(dr["IDProveedor"]),Convert.ToDouble(dr["Cantidad_Prod"]),Convert.ToDouble(dr["Porc_Hum_Prom_Desp"]),Convert.ToDouble(dr["Ley_Cobre_Prom"]),Convert.ToString(dr["Estado"]),Convert.ToDouble(dr["Porc_Hum_Prom_Recep"]),Convert.ToString(dr["Tipo_Material"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]));
        }
        
        public virtual CLote_Concentrado getLote_Concentrado(IDataReader dr)
        {
            return new CLote_Concentrado(Convert.ToString(dr["Nro_Lote"]),Convert.ToDateTime(dr["Fecha_Inicio_Vigencia"]),Convert.ToDateTime(dr["Fecha_Fin_Vigencia"]),Convert.ToString(dr["IDProveedor"]),Convert.ToDouble(dr["Cantidad_Prod"]),Convert.ToDouble(dr["Porc_Hum_Prom_Desp"]),Convert.ToDouble(dr["Ley_Cobre_Prom"]),Convert.ToString(dr["Estado"]),Convert.ToDouble(dr["Porc_Hum_Prom_Recep"]),Convert.ToString(dr["Tipo_Material"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CLote_Concentrado oLote_Concentrado)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Concentrado.spu_Lote_Concentrado_Guardar")){
            Db.AddInParameter(dbCmd, "Nro_Lote", DbType.String, oLote_Concentrado.Nro_Lote);
            Db.AddInParameter(dbCmd, "Fecha_Inicio_Vigencia", DbType.DateTime, oLote_Concentrado.Fecha_Inicio_Vigencia);
            Db.AddInParameter(dbCmd, "Fecha_Fin_Vigencia", DbType.DateTime, oLote_Concentrado.Fecha_Fin_Vigencia);
            Db.AddInParameter(dbCmd, "IDProveedor", DbType.String, oLote_Concentrado.IDProveedor);
            Db.AddInParameter(dbCmd, "Cantidad_Prod", DbType.Double, oLote_Concentrado.Cantidad_Prod);
            Db.AddInParameter(dbCmd, "Porc_Hum_Prom_Desp", DbType.Double, oLote_Concentrado.Porc_Hum_Prom_Desp);
            Db.AddInParameter(dbCmd, "Ley_Cobre_Prom", DbType.Double, oLote_Concentrado.Ley_Cobre_Prom);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oLote_Concentrado.Estado);
            Db.AddInParameter(dbCmd, "Porc_Hum_Prom_Recep", DbType.Double, oLote_Concentrado.Porc_Hum_Prom_Recep);
            Db.AddInParameter(dbCmd, "Tipo_Material", DbType.String, oLote_Concentrado.Tipo_Material);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oLote_Concentrado.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oLote_Concentrado.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oLote_Concentrado.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oLote_Concentrado.DateEdit);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Nro_Lote)
        {
            return Db.ExecuteNonQuery("Concentrado.spu_Lote_Concentrado_Eliminar", Nro_Lote);
        }
        
        public virtual CLote_Concentrado Recuperar(String Nro_Lote)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Lote_Concentrado_Recuperar", Nro_Lote).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getLote_Concentrado(dtDatos.Rows[0]);
            else
            return new CLote_Concentrado();
        }
        
        public virtual bool Existe(String Nro_Lote)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Lote_Concentrado_Recuperar", Nro_Lote).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Nro_Lote, out CLote_Concentrado oLote_Concentrado)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Lote_Concentrado_Recuperar", Nro_Lote).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oLote_Concentrado = getLote_Concentrado(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oLote_Concentrado = new CLote_Concentrado();
            return false;
            }
        }
        
        public virtual IList<CLote_Concentrado> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Concentrado.spu_Lote_Concentrado_Listar")){
            IList<CLote_Concentrado> list = new List<CLote_Concentrado>();
            while (dr.Read())
            list.Add(getLote_Concentrado(dr));
            return list;
            }
        }
        #endregion
    }
}
