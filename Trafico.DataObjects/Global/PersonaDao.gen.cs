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
    
    
    public partial class PersonaDao : DataAccessBase
    {
        
        public virtual CPersona getPersona(DataRow dr)
        {
            return new CPersona(Convert.ToString(dr["IDPersona"]),Convert.ToString(dr["Nombres"]),Convert.ToString(dr["Apellido_Paterno"]),Convert.ToString(dr["Apellido_Materno"]),Convert.ToString(dr["Nro_Doc_Iden"]),Convert.ToString(dr["Direccion"]),Convert.ToString(dr["EMail"]),Convert.ToString(dr["IDProveedor"]),Convert.ToDateTime(dr["Fecha_Nacimiento"]),Convert.ToString(dr["Estado_Civil"]),Convert.ToChar(dr["Sexo"]),Convert.ToDateTime(dr["Fecha_Registro"]),Convert.ToString(dr["RUC"]),Convert.ToDateTime(dr["Fecha_Cese"]),Convert.ToString(dr["Obs_Persona"]),Convert.ToString(dr["Nro_Licencia"]),Convert.ToBoolean(dr["Estado"]));
        }
        
        public virtual CPersona getPersona(IDataReader dr)
        {
            return new CPersona(Convert.ToString(dr["IDPersona"]),Convert.ToString(dr["Nombres"]),Convert.ToString(dr["Apellido_Paterno"]),Convert.ToString(dr["Apellido_Materno"]),Convert.ToString(dr["Nro_Doc_Iden"]),Convert.ToString(dr["Direccion"]),Convert.ToString(dr["EMail"]),Convert.ToString(dr["IDProveedor"]),Convert.ToDateTime(dr["Fecha_Nacimiento"]),Convert.ToString(dr["Estado_Civil"]),Convert.ToChar(dr["Sexo"]),Convert.ToDateTime(dr["Fecha_Registro"]),Convert.ToString(dr["RUC"]),Convert.ToDateTime(dr["Fecha_Cese"]),Convert.ToString(dr["Obs_Persona"]),Convert.ToString(dr["Nro_Licencia"]),Convert.ToBoolean(dr["Estado"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CPersona oPersona)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Persona_Guardar")){
            Db.AddInParameter(dbCmd, "IDPersona", DbType.String, oPersona.IDPersona);
            Db.AddInParameter(dbCmd, "Nombres", DbType.String, oPersona.Nombres);
            Db.AddInParameter(dbCmd, "Apellido_Paterno", DbType.String, oPersona.Apellido_Paterno);
            Db.AddInParameter(dbCmd, "Apellido_Materno", DbType.String, oPersona.Apellido_Materno);
            Db.AddInParameter(dbCmd, "Nro_Doc_Iden", DbType.String, oPersona.Nro_Doc_Iden);
            Db.AddInParameter(dbCmd, "Direccion", DbType.String, oPersona.Direccion);
            Db.AddInParameter(dbCmd, "EMail", DbType.String, oPersona.EMail);
            Db.AddInParameter(dbCmd, "IDProveedor", DbType.String, oPersona.IDProveedor);
            Db.AddInParameter(dbCmd, "Fecha_Nacimiento", DbType.DateTime, oPersona.Fecha_Nacimiento);
            Db.AddInParameter(dbCmd, "Estado_Civil", DbType.String, oPersona.Estado_Civil);
            Db.AddInParameter(dbCmd, "Sexo", DbType.String, oPersona.Sexo);
            Db.AddInParameter(dbCmd, "Fecha_Registro", DbType.DateTime, oPersona.Fecha_Registro);
            Db.AddInParameter(dbCmd, "RUC", DbType.String, oPersona.RUC);
            Db.AddInParameter(dbCmd, "Fecha_Cese", DbType.DateTime, oPersona.Fecha_Cese);
            Db.AddInParameter(dbCmd, "Obs_Persona", DbType.String, oPersona.Obs_Persona);
            Db.AddInParameter(dbCmd, "Nro_Licencia", DbType.String, oPersona.Nro_Licencia);
            Db.AddInParameter(dbCmd, "Estado", DbType.Boolean, oPersona.Estado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String IDPersona)
        {
            return Db.ExecuteNonQuery("Global.spu_Persona_Eliminar",IDPersona);
        }
        
        public virtual CPersona Recuperar(String IDPersona)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Persona_Recuperar",IDPersona).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getPersona(dtDatos.Rows[0]);
            else
            return new CPersona();
        }
        
        public virtual bool Existe(String IDPersona)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Persona_Recuperar",IDPersona).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String IDPersona, out CPersona oPersona)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Persona_Recuperar",IDPersona).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oPersona = getPersona(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oPersona = new CPersona();
            return false;
            }
        }
        
        public virtual IList<CPersona> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.spu_Persona_Listar")){
            IList<CPersona> list = new List<CPersona>();
            while (dr.Read())
            list.Add(getPersona(dr));
            return list;
            }
        }
        #endregion
    }
}
