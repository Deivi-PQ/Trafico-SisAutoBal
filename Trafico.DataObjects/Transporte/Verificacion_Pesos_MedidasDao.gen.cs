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
    
    
    public partial class Verificacion_Pesos_MedidasDao : DataAccessBase
    {
        
        public virtual CVerificacion_Pesos_Medidas getVerificacion_Pesos_Medidas(DataRow dr)
        {
            return new CVerificacion_Pesos_Medidas(Convert.ToInt32(dr["IDVerificacion"]),Convert.ToString(dr["Nro_Constancia"]),Convert.ToString(dr["Nro_Guia_Remision"]),Convert.ToDateTime(dr["Fecha"]),Convert.ToString(dr["Nombre_Material"]),Convert.ToString(dr["NroPlaca_Vehiculo"]),Convert.ToString(dr["NroPlaca_Cisterna"]),Convert.ToString(dr["Nro_Placa_Carreta"]),Convert.ToInt32(dr["IDMaterial"]),Convert.ToDouble(dr["Largo"]),Convert.ToDouble(dr["Ancho"]),Convert.ToDouble(dr["Alto"]),Convert.ToDouble(dr["Peso_Bruto_Max_Perm"]),Convert.ToDouble(dr["Peso_Bruto_Max_Transp"]),Convert.ToString(dr["Conf_Veh_Vehiculo"]),Convert.ToString(dr["Conf_Veh_Cisterna"]),Convert.ToString(dr["Conf_Veh_Carreta"]),Convert.ToString(dr["Observacion"]),Convert.ToString(dr["IDPersona_Genera"]),Convert.ToString(dr["Nro_Guia_Transportista"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToDouble(dr["PesoCjtoEje1"]),Convert.ToDouble(dr["PesoCjtoEje2"]),Convert.ToDouble(dr["PesoCjtoEje3"]),Convert.ToDouble(dr["PesoCjtoEje4"]),Convert.ToDouble(dr["PesoCjtoEje5"]),Convert.ToDouble(dr["PesoCjtoEje6"]),Convert.ToInt32(dr["Trafico_IDPersona_Genera"]));
        }
        
        public virtual CVerificacion_Pesos_Medidas getVerificacion_Pesos_Medidas(IDataReader dr)
        {
            return new CVerificacion_Pesos_Medidas(Convert.ToInt32(dr["IDVerificacion"]),Convert.ToString(dr["Nro_Constancia"]),Convert.ToString(dr["Nro_Guia_Remision"]),Convert.ToDateTime(dr["Fecha"]),Convert.ToString(dr["Nombre_Material"]),Convert.ToString(dr["NroPlaca_Vehiculo"]),Convert.ToString(dr["NroPlaca_Cisterna"]),Convert.ToString(dr["Nro_Placa_Carreta"]),Convert.ToInt32(dr["IDMaterial"]),Convert.ToDouble(dr["Largo"]),Convert.ToDouble(dr["Ancho"]),Convert.ToDouble(dr["Alto"]),Convert.ToDouble(dr["Peso_Bruto_Max_Perm"]),Convert.ToDouble(dr["Peso_Bruto_Max_Transp"]),Convert.ToString(dr["Conf_Veh_Vehiculo"]),Convert.ToString(dr["Conf_Veh_Cisterna"]),Convert.ToString(dr["Conf_Veh_Carreta"]),Convert.ToString(dr["Observacion"]),Convert.ToString(dr["IDPersona_Genera"]),Convert.ToString(dr["Nro_Guia_Transportista"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToDouble(dr["PesoCjtoEje1"]),Convert.ToDouble(dr["PesoCjtoEje2"]),Convert.ToDouble(dr["PesoCjtoEje3"]),Convert.ToDouble(dr["PesoCjtoEje4"]),Convert.ToDouble(dr["PesoCjtoEje5"]),Convert.ToDouble(dr["PesoCjtoEje6"]),Convert.ToInt32(dr["Trafico_IDPersona_Genera"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CVerificacion_Pesos_Medidas oVerificacion_Pesos_Medidas)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.spu_Verificacion_Pesos_Medidas_Guardar")){
            Db.AddInParameter(dbCmd, "IDVerificacion", DbType.Int32, oVerificacion_Pesos_Medidas.IDVerificacion);
            Db.AddInParameter(dbCmd, "Nro_Constancia", DbType.String, oVerificacion_Pesos_Medidas.Nro_Constancia);
            Db.AddInParameter(dbCmd, "Nro_Guia_Remision", DbType.String, oVerificacion_Pesos_Medidas.Nro_Guia_Remision);
            Db.AddInParameter(dbCmd, "Fecha", DbType.DateTime, oVerificacion_Pesos_Medidas.Fecha);
            Db.AddInParameter(dbCmd, "Nombre_Material", DbType.String, oVerificacion_Pesos_Medidas.Nombre_Material);
            Db.AddInParameter(dbCmd, "NroPlaca_Vehiculo", DbType.String, oVerificacion_Pesos_Medidas.NroPlaca_Vehiculo);
            Db.AddInParameter(dbCmd, "NroPlaca_Cisterna", DbType.String, oVerificacion_Pesos_Medidas.NroPlaca_Cisterna);
            Db.AddInParameter(dbCmd, "Nro_Placa_Carreta", DbType.String, oVerificacion_Pesos_Medidas.Nro_Placa_Carreta);
            Db.AddInParameter(dbCmd, "IDMaterial", DbType.Int32, oVerificacion_Pesos_Medidas.IDMaterial);
            Db.AddInParameter(dbCmd, "Largo", DbType.Double, oVerificacion_Pesos_Medidas.Largo);
            Db.AddInParameter(dbCmd, "Ancho", DbType.Double, oVerificacion_Pesos_Medidas.Ancho);
            Db.AddInParameter(dbCmd, "Alto", DbType.Double, oVerificacion_Pesos_Medidas.Alto);
            Db.AddInParameter(dbCmd, "Peso_Bruto_Max_Perm", DbType.Double, oVerificacion_Pesos_Medidas.Peso_Bruto_Max_Perm);
            Db.AddInParameter(dbCmd, "Peso_Bruto_Max_Transp", DbType.Double, oVerificacion_Pesos_Medidas.Peso_Bruto_Max_Transp);
            Db.AddInParameter(dbCmd, "Conf_Veh_Vehiculo", DbType.String, oVerificacion_Pesos_Medidas.Conf_Veh_Vehiculo);
            Db.AddInParameter(dbCmd, "Conf_Veh_Cisterna", DbType.String, oVerificacion_Pesos_Medidas.Conf_Veh_Cisterna);
            Db.AddInParameter(dbCmd, "Conf_Veh_Carreta", DbType.String, oVerificacion_Pesos_Medidas.Conf_Veh_Carreta);
            Db.AddInParameter(dbCmd, "Observacion", DbType.String, oVerificacion_Pesos_Medidas.Observacion);
            Db.AddInParameter(dbCmd, "IDPersona_Genera", DbType.String, oVerificacion_Pesos_Medidas.IDPersona_Genera);
            Db.AddInParameter(dbCmd, "Nro_Guia_Transportista", DbType.String, oVerificacion_Pesos_Medidas.Nro_Guia_Transportista);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oVerificacion_Pesos_Medidas.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oVerificacion_Pesos_Medidas.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oVerificacion_Pesos_Medidas.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oVerificacion_Pesos_Medidas.DateEdit);
            Db.AddInParameter(dbCmd, "PesoCjtoEje1", DbType.Double, oVerificacion_Pesos_Medidas.PesoCjtoEje1);
            Db.AddInParameter(dbCmd, "PesoCjtoEje2", DbType.Double, oVerificacion_Pesos_Medidas.PesoCjtoEje2);
            Db.AddInParameter(dbCmd, "PesoCjtoEje3", DbType.Double, oVerificacion_Pesos_Medidas.PesoCjtoEje3);
            Db.AddInParameter(dbCmd, "PesoCjtoEje4", DbType.Double, oVerificacion_Pesos_Medidas.PesoCjtoEje4);
            Db.AddInParameter(dbCmd, "PesoCjtoEje5", DbType.Double, oVerificacion_Pesos_Medidas.PesoCjtoEje5);
            Db.AddInParameter(dbCmd, "PesoCjtoEje6", DbType.Double, oVerificacion_Pesos_Medidas.PesoCjtoEje6);
            Db.AddInParameter(dbCmd, "Trafico_IDPersona_Genera", DbType.Int32, oVerificacion_Pesos_Medidas.Trafico_IDPersona_Genera);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDVerificacion)
        {
            return Db.ExecuteNonQuery("Transporte.spu_Verificacion_Pesos_Medidas_Eliminar",IDVerificacion);
        }
        
        public virtual CVerificacion_Pesos_Medidas Recuperar(Int32 IDVerificacion)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Verificacion_Pesos_Medidas_Recuperar",IDVerificacion).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getVerificacion_Pesos_Medidas(dtDatos.Rows[0]);
            else
            return new CVerificacion_Pesos_Medidas();
        }
        
        public virtual bool Existe(Int32 IDVerificacion)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Verificacion_Pesos_Medidas_Recuperar",IDVerificacion).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDVerificacion, out CVerificacion_Pesos_Medidas oVerificacion_Pesos_Medidas)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Verificacion_Pesos_Medidas_Recuperar",IDVerificacion).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oVerificacion_Pesos_Medidas = getVerificacion_Pesos_Medidas(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oVerificacion_Pesos_Medidas = new CVerificacion_Pesos_Medidas();
            return false;
            }
        }
        
        public virtual IList<CVerificacion_Pesos_Medidas> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Transporte.spu_Verificacion_Pesos_Medidas_Listar")){
            IList<CVerificacion_Pesos_Medidas> list = new List<CVerificacion_Pesos_Medidas>();
            while (dr.Read())
            list.Add(getVerificacion_Pesos_Medidas(dr));
            return list;
            }
        }
        #endregion
    }
}
