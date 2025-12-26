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
    
    
    public partial class LugarDao : DataAccessBase
    {
        
        public virtual CLugar getLugar(DataRow dr)
        {
            return new CLugar(Convert.ToInt32(dr["IDLugar"]),Convert.ToString(dr["Cod_Lugar"]),Convert.ToString(dr["Descripcion"]),Convert.ToString(dr["Observaciones"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToChar(dr["Status"]),Convert.ToString(dr["Distrito"]),Convert.ToString(dr["Provincia"]),Convert.ToString(dr["Departamento"]));
        }
        
        public virtual CLugar getLugar(IDataReader dr)
        {
            return new CLugar(Convert.ToInt32(dr["IDLugar"]),Convert.ToString(dr["Cod_Lugar"]),Convert.ToString(dr["Descripcion"]),Convert.ToString(dr["Observaciones"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToChar(dr["Status"]),Convert.ToString(dr["Distrito"]),Convert.ToString(dr["Provincia"]),Convert.ToString(dr["Departamento"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CLugar oLugar)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Lugar_Guardar")){
            Db.AddInParameter(dbCmd, "IDLugar", DbType.Int32, oLugar.IDLugar);
            Db.AddInParameter(dbCmd, "Cod_Lugar", DbType.String, oLugar.Cod_Lugar);
            Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oLugar.Descripcion);
            Db.AddInParameter(dbCmd, "Observaciones", DbType.String, oLugar.Observaciones);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oLugar.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oLugar.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oLugar.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oLugar.DateEdit);
            Db.AddInParameter(dbCmd, "Status", DbType.String, oLugar.Status);
            Db.AddInParameter(dbCmd, "Distrito", DbType.String, oLugar.Distrito);
            Db.AddInParameter(dbCmd, "Provincia", DbType.String, oLugar.Provincia);
            Db.AddInParameter(dbCmd, "Departamento", DbType.String, oLugar.Departamento);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDLugar)
        {
            return Db.ExecuteNonQuery("Global.spu_Lugar_Eliminar",IDLugar);
        }
        
        public virtual CLugar Recuperar(Int32 IDLugar)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Lugar_Recuperar",IDLugar).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getLugar(dtDatos.Rows[0]);
            else
            return new CLugar();
        }
        
        public virtual bool Existe(Int32 IDLugar)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Lugar_Recuperar",IDLugar).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDLugar, out CLugar oLugar)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Lugar_Recuperar",IDLugar).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oLugar = getLugar(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oLugar = new CLugar();
            return false;
            }
        }
        
        public virtual IList<CLugar> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.spu_Lugar_Listar")){
            IList<CLugar> list = new List<CLugar>();
            while (dr.Read())
            list.Add(getLugar(dr));
            return list;
            }
        }
        #endregion
    }
}
