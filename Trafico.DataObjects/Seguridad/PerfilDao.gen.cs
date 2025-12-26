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
    
    
    public partial class PerfilDao : DataAccessBase
    {
        
        public virtual CPerfil getPerfil(DataRow dr)
        {
            return new CPerfil(Convert.ToInt32(dr["IDPerfil"]),Convert.ToString(dr["Des_Perfil"]),Convert.ToChar(dr["Estado"]));
        }
        
        public virtual CPerfil getPerfil(IDataReader dr)
        {
            return new CPerfil(Convert.ToInt32(dr["IDPerfil"]),Convert.ToString(dr["Des_Perfil"]),Convert.ToChar(dr["Estado"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CPerfil oPerfil)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Perfil_Guardar")){
            Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int32, oPerfil.IDPerfil);
            Db.AddInParameter(dbCmd, "Des_Perfil", DbType.String, oPerfil.Des_Perfil);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oPerfil.Estado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDPerfil)
        {
            return Db.ExecuteNonQuery("Seguridad.spu_Perfil_Eliminar",IDPerfil);
        }
        
        public virtual CPerfil Recuperar(Int32 IDPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Perfil_Recuperar",IDPerfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getPerfil(dtDatos.Rows[0]);
            else
            return new CPerfil();
        }
        
        public virtual bool Existe(Int32 IDPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Perfil_Recuperar",IDPerfil).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDPerfil, out CPerfil oPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Perfil_Recuperar",IDPerfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oPerfil = getPerfil(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oPerfil = new CPerfil();
            return false;
            }
        }
        
        public virtual IList<CPerfil> Listar(CPerfil oPerfil)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Perfil_Listar"))
            {
                Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int32, (object)(oPerfil.IDPerfil == null || oPerfil.IDPerfil == 0 ? DBNull.Value : (object)oPerfil.IDPerfil));
                Db.AddInParameter(dbCmd, "Des_Perfil", DbType.String, (object)(string.IsNullOrEmpty(oPerfil.Des_Perfil) ? DBNull.Value : (object)oPerfil.Des_Perfil));
                Db.AddInParameter(dbCmd, "Estado", DbType.String, (object)(oPerfil.Estado == null || oPerfil.Estado=='T' ? DBNull.Value : (object)oPerfil.Estado.ToString()));
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CPerfil> list = new List<CPerfil>();
                    while (dr.Read())
                        list.Add(getPerfil(dr));
                    return list;
                }
            }
        }
        #endregion
    }
}
