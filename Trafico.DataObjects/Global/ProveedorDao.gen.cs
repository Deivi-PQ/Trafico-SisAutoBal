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
    
    
    public partial class ProveedorDao : DataAccessBase
    {
        
        public virtual CProveedor getProveedor(DataRow dr)
        {
            return new CProveedor(Convert.ToString(dr["IDProveedor"]),Convert.ToString(dr["RazonSocial"]),Convert.ToString(dr["Ruc"]),Convert.ToString(dr["Direccion"]),Convert.ToString(dr["Ciudad"]),Convert.ToString(dr["Actividad"]),Convert.ToString(dr["Telefono"]),Convert.ToString(dr["e_mail"]),Convert.ToString(dr["Persona_Contacto"]),Convert.ToDateTime(dr["Fecha_Inscripcion"]),Convert.ToString(dr["Observaciones"]),Convert.ToBoolean(dr["Estado"]));
        }
        
        public virtual CProveedor getProveedor(IDataReader dr)
        {
            return new CProveedor(Convert.ToString(dr["IDProveedor"]),Convert.ToString(dr["RazonSocial"]),Convert.ToString(dr["Ruc"]),Convert.ToString(dr["Direccion"]),Convert.ToString(dr["Ciudad"]),Convert.ToString(dr["Actividad"]),Convert.ToString(dr["Telefono"]),Convert.ToString(dr["e_mail"]),Convert.ToString(dr["Persona_Contacto"]),Convert.ToDateTime(dr["Fecha_Inscripcion"]),Convert.ToString(dr["Observaciones"]),Convert.ToBoolean(dr["Estado"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CProveedor oProveedor)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Proveedor_Guardar")){
            Db.AddInParameter(dbCmd, "IDProveedor", DbType.String, oProveedor.IDProveedor);
            Db.AddInParameter(dbCmd, "RazonSocial", DbType.String, oProveedor.RazonSocial);
            Db.AddInParameter(dbCmd, "Ruc", DbType.String, oProveedor.Ruc);
            Db.AddInParameter(dbCmd, "Direccion", DbType.String, oProveedor.Direccion);
            Db.AddInParameter(dbCmd, "Ciudad", DbType.String, oProveedor.Ciudad);
            Db.AddInParameter(dbCmd, "Actividad", DbType.String, oProveedor.Actividad);
            Db.AddInParameter(dbCmd, "Telefono", DbType.String, oProveedor.Telefono);
            Db.AddInParameter(dbCmd, "e_mail", DbType.String, oProveedor.e_mail);
            Db.AddInParameter(dbCmd, "Persona_Contacto", DbType.String, oProveedor.Persona_Contacto);
            Db.AddInParameter(dbCmd, "Fecha_Inscripcion", DbType.DateTime, oProveedor.Fecha_Inscripcion);
            Db.AddInParameter(dbCmd, "Observaciones", DbType.String, oProveedor.Observaciones);
            Db.AddInParameter(dbCmd, "Estado", DbType.Boolean, oProveedor.Estado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String IDProveedor)
        {
            return Db.ExecuteNonQuery("Global.spu_Proveedor_Eliminar",IDProveedor);
        }
        
        public virtual CProveedor Recuperar(String IDProveedor)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Proveedor_Recuperar",IDProveedor).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getProveedor(dtDatos.Rows[0]);
            else
            return new CProveedor();
        }
        
        public virtual bool Existe(String IDProveedor)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Proveedor_Recuperar",IDProveedor).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String IDProveedor, out CProveedor oProveedor)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Proveedor_Recuperar",IDProveedor).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oProveedor = getProveedor(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oProveedor = new CProveedor();
            return false;
            }
        }
        
        public virtual IList<CProveedor> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.spu_Proveedor_Listar")){
            IList<CProveedor> list = new List<CProveedor>();
            while (dr.Read())
            list.Add(getProveedor(dr));
            return list;
            }
        }
        #endregion
    }
}
