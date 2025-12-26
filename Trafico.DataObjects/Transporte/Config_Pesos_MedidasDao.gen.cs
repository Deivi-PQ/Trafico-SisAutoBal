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
    
    
    public partial class Config_Pesos_MedidasDao : DataAccessBase
    {
        
        public virtual CConfig_Pesos_Medidas getConfig_Pesos_Medidas(DataRow dr)
        {
            return new CConfig_Pesos_Medidas(Convert.ToString(dr["Conf_Vehicular"]),Convert.ToInt32(dr["NroEjes"]),Convert.ToDouble(dr["Peso_Bruto_Max_MTC"]),Convert.ToDouble(dr["Peso_Bruto_Max_Empresa"]),Convert.ToString(dr["Observacion"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToInt16(dr["NroConjEjes"]));
        }
        
        public virtual CConfig_Pesos_Medidas getConfig_Pesos_Medidas(IDataReader dr)
        {
            return new CConfig_Pesos_Medidas(Convert.ToString(dr["Conf_Vehicular"]),Convert.ToInt32(dr["NroEjes"]),Convert.ToDouble(dr["Peso_Bruto_Max_MTC"]),Convert.ToDouble(dr["Peso_Bruto_Max_Empresa"]),Convert.ToString(dr["Observacion"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToInt16(dr["NroConjEjes"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CConfig_Pesos_Medidas oConfig_Pesos_Medidas)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Config_Pesos_Medidas_Guardar")){
            Db.AddInParameter(dbCmd, "Conf_Vehicular", DbType.String, oConfig_Pesos_Medidas.Conf_Vehicular);
            Db.AddInParameter(dbCmd, "NroEjes", DbType.Int32, oConfig_Pesos_Medidas.NroEjes);
            Db.AddInParameter(dbCmd, "Peso_Bruto_Max_MTC", DbType.Double, oConfig_Pesos_Medidas.Peso_Bruto_Max_MTC);
            Db.AddInParameter(dbCmd, "Peso_Bruto_Max_Empresa", DbType.Double, oConfig_Pesos_Medidas.Peso_Bruto_Max_Empresa);
            Db.AddInParameter(dbCmd, "Observacion", DbType.String, oConfig_Pesos_Medidas.Observacion);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oConfig_Pesos_Medidas.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oConfig_Pesos_Medidas.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oConfig_Pesos_Medidas.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oConfig_Pesos_Medidas.DateEdit);
            Db.AddInParameter(dbCmd, "NroConjEjes", DbType.Int16, oConfig_Pesos_Medidas.NroConjEjes);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Conf_Vehicular)
        {
            return Db.ExecuteNonQuery("Transporte.spu_Config_Pesos_Medidas_Eliminar",Conf_Vehicular);
        }
        
        public virtual CConfig_Pesos_Medidas Recuperar(String Conf_Vehicular)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Config_Pesos_Medidas_Recuperar",Conf_Vehicular).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getConfig_Pesos_Medidas(dtDatos.Rows[0]);
            else
            return new CConfig_Pesos_Medidas();
        }
        
        public virtual bool Existe(String Conf_Vehicular)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Config_Pesos_Medidas_Recuperar",Conf_Vehicular).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Conf_Vehicular, out CConfig_Pesos_Medidas oConfig_Pesos_Medidas)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Config_Pesos_Medidas_Recuperar",Conf_Vehicular).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oConfig_Pesos_Medidas = getConfig_Pesos_Medidas(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oConfig_Pesos_Medidas = new CConfig_Pesos_Medidas();
            return false;
            }
        }
        
        public virtual IList<CConfig_Pesos_Medidas> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Transporte.spu_Config_Pesos_Medidas_Listar")){
            IList<CConfig_Pesos_Medidas> list = new List<CConfig_Pesos_Medidas>();
            while (dr.Read())
            list.Add(getConfig_Pesos_Medidas(dr));
            return list;
            }
        }
        #endregion
    }
}
