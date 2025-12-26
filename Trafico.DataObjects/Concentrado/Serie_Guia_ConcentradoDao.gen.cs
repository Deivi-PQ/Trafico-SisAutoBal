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
    
    
    public partial class Serie_Guia_ConcentradoDao : DataAccessBase
    {
        
        public virtual CSerie_Guia_Concentrado getSerie_Guia_Concentrado(DataRow dr)
        {
            return new CSerie_Guia_Concentrado(Convert.ToString(dr["Nro_Serie"]),Convert.ToInt16(dr["NroDigitos"]),Convert.ToString(dr["CorrelativoIni"]),Convert.ToBoolean(dr["flagCerrado"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["Cod_Material"]));
        }
        
        public virtual CSerie_Guia_Concentrado getSerie_Guia_Concentrado(IDataReader dr)
        {
            return new CSerie_Guia_Concentrado(Convert.ToString(dr["Nro_Serie"]),Convert.ToInt16(dr["NroDigitos"]),Convert.ToString(dr["CorrelativoIni"]),Convert.ToBoolean(dr["flagCerrado"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["Cod_Material"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CSerie_Guia_Concentrado oSerie_Guia_Concentrado)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Concentrado.spu_Serie_Guia_Concentrado_Guardar")){
            Db.AddInParameter(dbCmd, "Nro_Serie", DbType.String, oSerie_Guia_Concentrado.Nro_Serie);
            Db.AddInParameter(dbCmd, "NroDigitos", DbType.Int16, oSerie_Guia_Concentrado.NroDigitos);
            Db.AddInParameter(dbCmd, "CorrelativoIni", DbType.String, oSerie_Guia_Concentrado.CorrelativoIni);
            Db.AddInParameter(dbCmd, "flagCerrado", DbType.Boolean, oSerie_Guia_Concentrado.flagCerrado);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oSerie_Guia_Concentrado.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oSerie_Guia_Concentrado.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oSerie_Guia_Concentrado.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oSerie_Guia_Concentrado.DateEdit);
            Db.AddInParameter(dbCmd, "Cod_Material", DbType.String, oSerie_Guia_Concentrado.Cod_Material);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Nro_Serie)
        {
            return Db.ExecuteNonQuery("Concentrado.spu_Serie_Guia_Concentrado_Eliminar", Nro_Serie);
        }
        
        public virtual CSerie_Guia_Concentrado Recuperar(String Nro_Serie)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Serie_Guia_Concentrado_Recuperar", Nro_Serie).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getSerie_Guia_Concentrado(dtDatos.Rows[0]);
            else
            return new CSerie_Guia_Concentrado();
        }
        
        public virtual bool Existe(String Nro_Serie)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Serie_Guia_Concentrado_Recuperar", Nro_Serie).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Nro_Serie, out CSerie_Guia_Concentrado oSerie_Guia_Concentrado)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Serie_Guia_Concentrado_Recuperar", Nro_Serie).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oSerie_Guia_Concentrado = getSerie_Guia_Concentrado(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oSerie_Guia_Concentrado = new CSerie_Guia_Concentrado();
            return false;
            }
        }
        
        public virtual IList<CSerie_Guia_Concentrado> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Concentrado.spu_Serie_Guia_Concentrado_Listar")){
            IList<CSerie_Guia_Concentrado> list = new List<CSerie_Guia_Concentrado>();
            while (dr.Read())
            list.Add(getSerie_Guia_Concentrado(dr));
            return list;
            }
        }
        #endregion
    }
}
