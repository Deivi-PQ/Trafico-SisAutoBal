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
using Trafico.BusinessObjects.Seguridad;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Seguridad
{
    
    
    public partial class AccesoDao : DataAccessBase
    {
        
        public virtual CAcceso getAcceso(DataRow dr)
        {
            return new CAcceso(
                dr["Cod_Acceso"] == DBNull.Value ? null : dr["Cod_Acceso"].ToString(),
                dr["Nombre_Acceso"] == DBNull.Value ? null : dr["Nombre_Acceso"].ToString(),
                dr["Descripcion"] == DBNull.Value ? null : dr["Descripcion"].ToString(),
                dr["Comando"] == DBNull.Value ? null : dr["Comando"].ToString(),
                dr["Nivel"] == DBNull.Value ? (short?)null : Convert.ToInt16(dr["Nivel"]),
                dr["Estado"] == DBNull.Value ? '\0' : Convert.ToChar(dr["Estado"]),
                dr["Imagen"] == DBNull.Value ? null : dr["Imagen"].ToString()
            );
        }
        
        public virtual CAcceso getAcceso(IDataReader dr)
        {
            return new CAcceso(
                dr["Cod_Acceso"] == DBNull.Value ? null : dr["Cod_Acceso"].ToString(),
                dr["Nombre_Acceso"] == DBNull.Value ? null : dr["Nombre_Acceso"].ToString(),
                dr["Descripcion"] == DBNull.Value ? null : dr["Descripcion"].ToString(),
                dr["Comando"] == DBNull.Value ? null : dr["Comando"].ToString(),
                dr["Nivel"] == DBNull.Value ? (short?)null : Convert.ToInt16(dr["Nivel"]),
                dr["Estado"] == DBNull.Value ? '\0' : Convert.ToChar(dr["Estado"]),
                dr["Imagen"] == DBNull.Value ? null : dr["Imagen"].ToString()
            );
        }
        
        #region Metodos Principales                          
        public virtual bool Grabar(CAcceso oAcceso)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Acceso_Guardar"))
            {
                Db.AddInParameter(dbCmd, "Cod_Acceso", DbType.String, oAcceso.Cod_Acceso ?? (object)DBNull.Value);
                Db.AddInParameter(dbCmd, "Nombre_Acceso", DbType.String, oAcceso.Nombre_Acceso ?? (object)DBNull.Value);
                Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oAcceso.Descripcion ?? (object)DBNull.Value);
                Db.AddInParameter(dbCmd, "Comando", DbType.String, oAcceso.Comando ?? (object)DBNull.Value);
                Db.AddInParameter(dbCmd, "Nivel", DbType.Int16, oAcceso.Nivel ?? (object)DBNull.Value);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, oAcceso.Estado ?? (object)DBNull.Value);
                Db.AddInParameter(dbCmd, "Imagen", DbType.String, oAcceso.Imagen ?? (object)DBNull.Value);

                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }
        
        public virtual int Eliminar(String Cod_Acceso)
        {
            return Db.ExecuteNonQuery("Seguridad.spu_Acceso_Eliminar",Cod_Acceso);
        }
        
        public virtual CAcceso Recuperar(String Cod_Acceso)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Acceso_Recuperar",Cod_Acceso).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getAcceso(dtDatos.Rows[0]);
            else
            return new CAcceso();
        }
        
        public virtual bool Existe(String Cod_Acceso)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Acceso_Recuperar",Cod_Acceso).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Acceso, out CAcceso oAcceso)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Acceso_Recuperar",Cod_Acceso).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oAcceso = getAcceso(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oAcceso = new CAcceso();
            return false;
            }
        }
        
        public virtual IList<CAcceso> Listar(String Cod_Acceso, String Nombre_Acceso, String Descripcion,String Estado)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Acceso_Listar"))
            {
                Db.AddInParameter(dbCmd, "Cod_Acceso", DbType.String, Cod_Acceso == "" ? DBNull.Value : Cod_Acceso);
                Db.AddInParameter(dbCmd, "Nombre_Acceso", DbType.String, Nombre_Acceso == "" ? DBNull.Value : Nombre_Acceso);
                Db.AddInParameter(dbCmd, "Descripcion", DbType.String, Descripcion == "" ? DBNull.Value : Descripcion);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, Estado == "T" ? DBNull.Value : Estado);
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CAcceso> list = new List<CAcceso>();
                    while (dr.Read())
                        list.Add(getAcceso(dr));
                    return list;
                }
            }
        }
        public virtual IList<CAcceso> Filtrar(String Cod_Acceso, String Nombre_Acceso, String Descripcion, Int16 Nivel, String Estado)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_spu_Acceso_Filtrar"))
            {
                Db.AddInParameter(dbCmd, "Cod_Acceso", DbType.String, Cod_Acceso == "" ? DBNull.Value : Cod_Acceso);
                Db.AddInParameter(dbCmd, "Nombre_Acceso", DbType.String, Nombre_Acceso == "" ? DBNull.Value : Nombre_Acceso);
                Db.AddInParameter(dbCmd, "Descripcion", DbType.String, Descripcion == "" ? DBNull.Value : Descripcion);
                Db.AddInParameter(dbCmd, "Nivel", DbType.String, Nivel == -1 ? DBNull.Value : Nivel);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, Estado == "*" ? DBNull.Value : Estado);
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CAcceso> list = new List<CAcceso>();
                    while (dr.Read())
                        list.Add(getAcceso(dr));
                    return list;
                }
            }
        }

        public virtual IList<CAcceso> MenuSistema(int IDPerfil)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_MenuSistema"))
            {
                Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int32, IDPerfil);
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CAcceso> list = new List<CAcceso>();
                    while (dr.Read())
                        list.Add(getAcceso(dr));
                    return list;
                }
            }
        }
        #endregion
    }
}
