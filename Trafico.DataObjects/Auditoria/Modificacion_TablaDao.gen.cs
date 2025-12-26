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
using Trafico.BusinessObjects.Auditoria;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Auditoria
{
    
    
    public partial class Modificacion_TablaDao : DataAccessBase
    {
        
        public virtual CModificacion_Tabla getModificacion_Tabla(DataRow dr)
        {
            return new CModificacion_Tabla(Convert.ToInt32(dr["idModificacion"]),Convert.ToString(dr["Tabla"]),Convert.ToChar(dr["Tipo_Modificacion"]),Convert.ToString(dr["Usuario"]),Convert.ToDateTime(dr["Fecha_Hora"]),Convert.ToString(dr["Campo"]),Convert.ToString(dr["Descripcion"]));
        }
        
        public virtual CModificacion_Tabla getModificacion_Tabla(IDataReader dr)
        {
            return new CModificacion_Tabla(Convert.ToInt32(dr["idModificacion"]),Convert.ToString(dr["Tabla"]),Convert.ToChar(dr["Tipo_Modificacion"]),Convert.ToString(dr["Usuario"]),Convert.ToDateTime(dr["Fecha_Hora"]),Convert.ToString(dr["Campo"]),Convert.ToString(dr["Descripcion"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CModificacion_Tabla oModificacion_Tabla)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Auditoria.spu_Modificacion_Tabla_Guardar")){
            Db.AddInParameter(dbCmd, "idModificacion", DbType.Int32, oModificacion_Tabla.idModificacion);
            Db.AddInParameter(dbCmd, "Tabla", DbType.String, oModificacion_Tabla.Tabla);
            Db.AddInParameter(dbCmd, "Tipo_Modificacion", DbType.String, oModificacion_Tabla.Tipo_Modificacion);
            Db.AddInParameter(dbCmd, "Usuario", DbType.String, oModificacion_Tabla.Usuario);
            Db.AddInParameter(dbCmd, "Fecha_Hora", DbType.DateTime, oModificacion_Tabla.Fecha_Hora);
            Db.AddInParameter(dbCmd, "Campo", DbType.String, oModificacion_Tabla.Campo);
            Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oModificacion_Tabla.Descripcion);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 idModificacion)
        {
            return Db.ExecuteNonQuery("Auditoria.spu_Modificacion_Tabla_Eliminar",idModificacion);
        }
        
        public virtual CModificacion_Tabla Recuperar(Int32 idModificacion)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Modificacion_Tabla_Recuperar",idModificacion).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getModificacion_Tabla(dtDatos.Rows[0]);
            else
            return new CModificacion_Tabla();
        }
        
        public virtual bool Existe(Int32 idModificacion)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Modificacion_Tabla_Recuperar",idModificacion).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 idModificacion, out CModificacion_Tabla oModificacion_Tabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Auditoria.spu_Modificacion_Tabla_Recuperar",idModificacion).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oModificacion_Tabla = getModificacion_Tabla(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oModificacion_Tabla = new CModificacion_Tabla();
            return false;
            }
        }
        
        public virtual IList<CModificacion_Tabla> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Auditoria.spu_Modificacion_Tabla_Listar")){
            IList<CModificacion_Tabla> list = new List<CModificacion_Tabla>();
            while (dr.Read())
            list.Add(getModificacion_Tabla(dr));
            return list;
            }
        }
        #endregion
    }
}
