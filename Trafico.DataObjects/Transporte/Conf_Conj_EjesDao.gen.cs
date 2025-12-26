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
    
    
    public partial class Conf_Conj_EjesDao : DataAccessBase
    {
        
        public virtual CConf_Conj_Ejes getConf_Conj_Ejes(DataRow dr)
        {
            return new CConf_Conj_Ejes(Convert.ToString(dr["Conf_Vehicular"]),Convert.ToInt16(dr["NroConjEje"]),Convert.ToDouble(dr["CjtoPesoMaxPerm"]));
        }
        
        public virtual CConf_Conj_Ejes getConf_Conj_Ejes(IDataReader dr)
        {
            return new CConf_Conj_Ejes(Convert.ToString(dr["Conf_Vehicular"]),Convert.ToInt16(dr["NroConjEje"]),Convert.ToDouble(dr["CjtoPesoMaxPerm"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CConf_Conj_Ejes oConf_Conj_Ejes)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Conf_Conj_Ejes_Guardar")){
            Db.AddInParameter(dbCmd, "Conf_Vehicular", DbType.String, oConf_Conj_Ejes.Conf_Vehicular);
            Db.AddInParameter(dbCmd, "NroConjEje", DbType.Int16, oConf_Conj_Ejes.NroConjEje);
            Db.AddInParameter(dbCmd, "CjtoPesoMaxPerm", DbType.Double, oConf_Conj_Ejes.CjtoPesoMaxPerm);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Conf_Vehicular, Int16 NroConjEje)
        {
            return Db.ExecuteNonQuery("Transporte.spu_Conf_Conj_Ejes_Eliminar",Conf_Vehicular,NroConjEje);
        }
        
        public virtual CConf_Conj_Ejes Recuperar(String Conf_Vehicular, Int16 NroConjEje)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Conf_Conj_Ejes_Recuperar",Conf_Vehicular,NroConjEje).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getConf_Conj_Ejes(dtDatos.Rows[0]);
            else
            return new CConf_Conj_Ejes();
        }
        
        public virtual bool Existe(String Conf_Vehicular, Int16 NroConjEje)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Conf_Conj_Ejes_Recuperar",Conf_Vehicular,NroConjEje).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Conf_Vehicular, Int16 NroConjEje, out CConf_Conj_Ejes oConf_Conj_Ejes)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Conf_Conj_Ejes_Recuperar",Conf_Vehicular,NroConjEje).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oConf_Conj_Ejes = getConf_Conj_Ejes(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oConf_Conj_Ejes = new CConf_Conj_Ejes();
            return false;
            }
        }
        
        public virtual IList<CConf_Conj_Ejes> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Transporte.spu_Conf_Conj_Ejes_Listar")){
            IList<CConf_Conj_Ejes> list = new List<CConf_Conj_Ejes>();
            while (dr.Read())
            list.Add(getConf_Conj_Ejes(dr));
            return list;
            }
        }
        #endregion
    }
}
