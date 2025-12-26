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
    
    
    public partial class UsuarioDao : DataAccessBase
    {
        
        public virtual CUsuario getUsuario(DataRow dr)
        {
            return new CUsuario(
               dr["IDUsuario"] == DBNull.Value ? "" : dr["IDUsuario"].ToString()!,
               dr["Passwd"] == DBNull.Value ? "" : dr["Passwd"].ToString()!,
               dr["IDPersona"] == DBNull.Value ? "" : dr["IDPersona"].ToString()!,
               dr["Nombre_Usuario"] == DBNull.Value ? "" : dr["Nombre_Usuario"].ToString()!,
               dr["EMail"] == DBNull.Value ? "" : dr["EMail"].ToString()!,
               dr["flagActDir"] == DBNull.Value ? false : Convert.ToBoolean(dr["flagActDir"]),
               dr["IDPerfil"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDPerfil"]),
               dr["Estado"] == DBNull.Value ? 'X' : Convert.ToChar(dr["Estado"]),
               dr["UserNew"] == DBNull.Value ? "" : dr["UserNew"].ToString()!,
               dr["DateNew"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateNew"]),
               dr["UserEdit"] == DBNull.Value ? "" : dr["UserEdit"].ToString()!,
               dr["DateEdit"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateEdit"]),
               dr["flagDobleFactor"] == DBNull.Value ? false : Convert.ToBoolean(dr["flagDobleFactor"]),
               dr["flagSeRegistro2FA"] == DBNull.Value ? false : Convert.ToBoolean(dr["flagSeRegistro2FA"]),
               dr["Celular"] == DBNull.Value ? "" : dr["Celular"].ToString()!
           );
        }
        
        public virtual CUsuario getUsuario(IDataReader dr)
        {
            return new CUsuario(
               dr["IDUsuario"] == DBNull.Value ? "" : dr["IDUsuario"].ToString()!,
               dr["Passwd"] == DBNull.Value ? "" : dr["Passwd"].ToString()!,
               dr["IDPersona"] == DBNull.Value ? "" : dr["IDPersona"].ToString()!,
               dr["Nombre_Usuario"] == DBNull.Value ? "" : dr["Nombre_Usuario"].ToString()!,
               dr["EMail"] == DBNull.Value ? "" : dr["EMail"].ToString()!,
               dr["flagActDir"] == DBNull.Value ? false : Convert.ToBoolean(dr["flagActDir"]),
               dr["IDPerfil"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDPerfil"]),
               dr["Estado"] == DBNull.Value ? 'X' : Convert.ToChar(dr["Estado"]),
               dr["UserNew"] == DBNull.Value ? "" : dr["UserNew"].ToString()!,
               dr["DateNew"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateNew"]),
               dr["UserEdit"] == DBNull.Value ? "" : dr["UserEdit"].ToString()!,
               dr["DateEdit"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateEdit"]),
               dr["flagDobleFactor"] == DBNull.Value ? false : Convert.ToBoolean(dr["flagDobleFactor"]),
               dr["flagSeRegistro2FA"] == DBNull.Value ? false : Convert.ToBoolean(dr["flagSeRegistro2FA"]),
               dr["Celular"] == DBNull.Value ? "" : dr["Celular"].ToString()!
           );
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CUsuario oUsuario)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Usuario_Guardar")){
            Db.AddInParameter(dbCmd, "IDUsuario", DbType.String, oUsuario.IDUsuario);
            Db.AddInParameter(dbCmd, "Passwd", DbType.String, oUsuario.Passwd);
            Db.AddInParameter(dbCmd, "IDPersona", DbType.String, oUsuario.IDPersona);
            Db.AddInParameter(dbCmd, "Nombre_Usuario", DbType.String, oUsuario.Nombre_Usuario);
            Db.AddInParameter(dbCmd, "EMail", DbType.String, oUsuario.EMail);
            Db.AddInParameter(dbCmd, "flagActDir", DbType.Boolean, oUsuario.flagActDir);
            Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int32, oUsuario.IDPerfil);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oUsuario.Estado);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oUsuario.UserNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oUsuario.UserEdit);
            Db.AddInParameter(dbCmd, "flagDobleFactor", DbType.Boolean, oUsuario.flagDobleFactor);
            Db.AddInParameter(dbCmd, "flagSeRegistro2FA", DbType.Boolean, oUsuario.flagSeRegistro2FA);
            Db.AddInParameter(dbCmd, "Celular", DbType.String, oUsuario.Celular);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String IDUsuario)
        {
            return Db.ExecuteNonQuery("Seguridad.spu_Usuario_Eliminar", IDUsuario);
        }
        
        public virtual CUsuario Recuperar(String IDUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Usuario_Recuperar",IDUsuario).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getUsuario(dtDatos.Rows[0]);
            else
            return new CUsuario();
        }
        
        public virtual bool Existe(String IDUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Usuario_Recuperar", IDUsuario).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String IDUsuario, out CUsuario oUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Usuario_Recuperar", IDUsuario).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oUsuario = getUsuario(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oUsuario = new CUsuario();
            return false;
            }
        }
        
        public virtual IList<CUsuario> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Seguridad.spu_Usuario_Listar")){
            IList<CUsuario> list = new List<CUsuario>();
            while (dr.Read())
            list.Add(getUsuario(dr));
            return list;
            }
        }

        public bool Actualizar_Password(string Cod_Usuario, bool flagActDir, string Password, string UserEdit)
        {
            return Db.ExecuteNonQuery("Seguridad.spu_Usuario_Actualizar_Password", Cod_Usuario, flagActDir, Password, UserEdit) > 0;
        }

        public bool Actualizar_Registro2FA(string Cod_Usuario, bool flagSeRegistro2FA, string UserEdit)
        {
            return Db.ExecuteNonQuery("Seguridad.spu_Usuario_Actualizar_Registro2FA", Cod_Usuario, flagSeRegistro2FA, UserEdit) > 0;
        }

        public virtual IList<CUsuario> Filtra(CUsuario oUsuario)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Usuario_Filtrar"))
            {
                Db.AddInParameter(dbCmd, "CodUsuario", DbType.String, oUsuario.IDUsuario == "" ? DBNull.Value : oUsuario.IDUsuario);
                Db.AddInParameter(dbCmd, "Nombre_Usuario", DbType.String, oUsuario.Nombre_Usuario == "" ? DBNull.Value : oUsuario.Nombre_Usuario);
                Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int64, oUsuario.IDPerfil == -1 ? DBNull.Value : oUsuario.IDPerfil);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, oUsuario.Estado == 'T' ? DBNull.Value : oUsuario.Estado);
                Db.AddInParameter(dbCmd, "Tipo_Usuario", DbType.String, oUsuario.IDPerfil == 'T' ? DBNull.Value : oUsuario.IDPerfil);
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CUsuario> list = new List<CUsuario>();
                    while (dr.Read())
                        list.Add(getUsuario(dr));
                    return list;
                }
            }
        }
        #endregion
    }
}
