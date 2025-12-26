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
using Trafico.BusinessObjects.Transporte;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Transporte
{
    
    
    public partial class MaterialDao : DataAccessBase
    {
        
        public virtual CMaterial getMaterial(DataRow dr)
        {
            return new CMaterial(Convert.ToInt32(dr["IDMaterial"]),Convert.ToString(dr["Nombre_Material"]),Convert.ToString(dr["UniMed"]),Convert.ToString(dr["Stock_Code"]),Convert.ToChar(dr["Status"]));
        }
        
        public virtual CMaterial getMaterial(IDataReader dr)
        {
            return new CMaterial(Convert.ToInt32(dr["IDMaterial"]),Convert.ToString(dr["Nombre_Material"]),Convert.ToString(dr["UniMed"]),Convert.ToString(dr["Stock_Code"]),Convert.ToChar(dr["Status"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CMaterial oMaterial)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Material_Guardar")){
            Db.AddInParameter(dbCmd, "IDMaterial", DbType.Int32, oMaterial.IDMaterial);
            Db.AddInParameter(dbCmd, "Nombre_Material", DbType.String, oMaterial.Nombre_Material);
            Db.AddInParameter(dbCmd, "UniMed", DbType.String, oMaterial.UniMed);
            Db.AddInParameter(dbCmd, "Stock_Code", DbType.String, oMaterial.Stock_Code);
            Db.AddInParameter(dbCmd, "Status", DbType.String, oMaterial.Status);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDMaterial)
        {
            return Db.ExecuteNonQuery("Transporte.spu_Material_Eliminar",IDMaterial);
        }
        
        public virtual CMaterial Recuperar(Int32 IDMaterial)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Material_Recuperar",IDMaterial).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getMaterial(dtDatos.Rows[0]);
            else
            return new CMaterial();
        }
        
        public virtual bool Existe(Int32 IDMaterial)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Material_Recuperar",IDMaterial).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDMaterial, out CMaterial oMaterial)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Material_Recuperar",IDMaterial).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oMaterial = getMaterial(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oMaterial = new CMaterial();
            return false;
            }
        }
        
        public virtual IList<CMaterial> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Transporte.spu_Material_Listar")){
            IList<CMaterial> list = new List<CMaterial>();
            while (dr.Read())
            list.Add(getMaterial(dr));
            return list;
            }
        }
        #endregion
    }
}
