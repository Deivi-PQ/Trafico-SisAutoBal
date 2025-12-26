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
using Trafico.BusinessObjects.Concentrado;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Concentrado
{
    
    
    public partial class Guia_Remision_ConcentradoDao : DataAccessBase
    {
        
        public virtual CGuia_Remision_Concentrado getGuia_Remision_Concentrado(DataRow dr)
        {
            return new CGuia_Remision_Concentrado(Convert.ToString(dr["Nro_Serie"]),Convert.ToString(dr["Nro_Guia_Remision"]),Convert.ToString(dr["Nro_Lote"]),Convert.ToString(dr["IDProveedor_Transp"]),Convert.ToString(dr["IDVehiculo"]),Convert.ToString(dr["IDCarreta"]),Convert.ToString(dr["IDConductor"]),Convert.ToString(dr["Motivo_Traslado"]),Convert.ToString(dr["IDProveedor_Dest"]),Convert.ToString(dr["Nro_Factura"]),Convert.ToDouble(dr["Costo_Minimo"]),Convert.ToString(dr["Estado"]),Convert.ToInt32(dr["IDLugar_Emision"]),Convert.ToString(dr["DES_IDUsuario_Despacho"]),Convert.ToInt32(dr["DES_IDLugar_Despacho"]),Convert.ToDateTime(dr["DES_FechaHora_Despacho"]),Convert.ToDateTime(dr["DES_FechaHora_Inicio_Trasl"]),Convert.ToDateTime(dr["DES_Fecha_Emision_Valida"]),Convert.ToDouble(dr["DES_Peso_Bruto"]),Convert.ToDouble(dr["DES_Tara"]),Convert.ToString(dr["DES_Observacion"]),Convert.ToString(dr["DES_Precinto_Seguridad"]),Convert.ToString(dr["REC_IDUsuario_Recepcion"]),Convert.ToInt32(dr["REC_IDLugar_Recepcion"]),Convert.ToDateTime(dr["REC_FechaHora_Recepcion"]),Convert.ToDateTime(dr["REC_FechaHoraFin_Recepcion"]),Convert.ToDouble(dr["REC_Peso_Bruto"]),Convert.ToDouble(dr["REC_Tara"]),Convert.ToBoolean(dr["REC_Flag_Guia_Procesada"]),Convert.ToString(dr["REC_Observacion"]),Convert.ToString(dr["Tipo_Material"]),Convert.ToDateTime(dr["FechaHora_Salida"]),Convert.ToDateTime(dr["FechaHora_Llegada"]),Convert.ToString(dr["Obs_Llegada"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToBoolean(dr["FlagTranspFacturado"]),Convert.ToDouble(dr["Peso_Bruto_Total"]),Convert.ToString(dr["Nro_Placa_Veh"]),Convert.ToString(dr["Nro_Placa_Car"]),Convert.ToString(dr["Cod_Sis_Transp"]),Convert.ToString(dr["REC_Cod_Sis_Transp"]),Convert.ToInt16(dr["NroMuestra"]));
        }
        
        public virtual CGuia_Remision_Concentrado getGuia_Remision_Concentrado(IDataReader dr)
        {
            return new CGuia_Remision_Concentrado(Convert.ToString(dr["Nro_Serie"]),Convert.ToString(dr["Nro_Guia_Remision"]),Convert.ToString(dr["Nro_Lote"]),Convert.ToString(dr["IDProveedor_Transp"]),Convert.ToString(dr["IDVehiculo"]),Convert.ToString(dr["IDCarreta"]),Convert.ToString(dr["IDConductor"]),Convert.ToString(dr["Motivo_Traslado"]),Convert.ToString(dr["IDProveedor_Dest"]),Convert.ToString(dr["Nro_Factura"]),Convert.ToDouble(dr["Costo_Minimo"]),Convert.ToString(dr["Estado"]),Convert.ToInt32(dr["IDLugar_Emision"]),Convert.ToString(dr["DES_IDUsuario_Despacho"]),Convert.ToInt32(dr["DES_IDLugar_Despacho"]),Convert.ToDateTime(dr["DES_FechaHora_Despacho"]),Convert.ToDateTime(dr["DES_FechaHora_Inicio_Trasl"]),Convert.ToDateTime(dr["DES_Fecha_Emision_Valida"]),Convert.ToDouble(dr["DES_Peso_Bruto"]),Convert.ToDouble(dr["DES_Tara"]),Convert.ToString(dr["DES_Observacion"]),Convert.ToString(dr["DES_Precinto_Seguridad"]),Convert.ToString(dr["REC_IDUsuario_Recepcion"]),Convert.ToInt32(dr["REC_IDLugar_Recepcion"]),Convert.ToDateTime(dr["REC_FechaHora_Recepcion"]),Convert.ToDateTime(dr["REC_FechaHoraFin_Recepcion"]),Convert.ToDouble(dr["REC_Peso_Bruto"]),Convert.ToDouble(dr["REC_Tara"]),Convert.ToBoolean(dr["REC_Flag_Guia_Procesada"]),Convert.ToString(dr["REC_Observacion"]),Convert.ToString(dr["Tipo_Material"]),Convert.ToDateTime(dr["FechaHora_Salida"]),Convert.ToDateTime(dr["FechaHora_Llegada"]),Convert.ToString(dr["Obs_Llegada"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToBoolean(dr["FlagTranspFacturado"]),Convert.ToDouble(dr["Peso_Bruto_Total"]),Convert.ToString(dr["Nro_Placa_Veh"]),Convert.ToString(dr["Nro_Placa_Car"]),Convert.ToString(dr["Cod_Sis_Transp"]),Convert.ToString(dr["REC_Cod_Sis_Transp"]),Convert.ToInt16(dr["NroMuestra"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CGuia_Remision_Concentrado oGuia_Remision_Concentrado)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Concentrado.spu_Guia_Remision_Concentrado_Guardar")){
            Db.AddInParameter(dbCmd, "Nro_Serie", DbType.String, oGuia_Remision_Concentrado.Nro_Serie);
            Db.AddInParameter(dbCmd, "Nro_Guia_Remision", DbType.String, oGuia_Remision_Concentrado.Nro_Guia_Remision);
            Db.AddInParameter(dbCmd, "Nro_Lote", DbType.String, oGuia_Remision_Concentrado.Nro_Lote);
            Db.AddInParameter(dbCmd, "IDProveedor_Transp", DbType.String, oGuia_Remision_Concentrado.IDProveedor_Transp);
            Db.AddInParameter(dbCmd, "IDVehiculo", DbType.String, oGuia_Remision_Concentrado.IDVehiculo);
            Db.AddInParameter(dbCmd, "IDCarreta", DbType.String, oGuia_Remision_Concentrado.IDCarreta);
            Db.AddInParameter(dbCmd, "IDConductor", DbType.String, oGuia_Remision_Concentrado.IDConductor);
            Db.AddInParameter(dbCmd, "Motivo_Traslado", DbType.String, oGuia_Remision_Concentrado.Motivo_Traslado);
            Db.AddInParameter(dbCmd, "IDProveedor_Dest", DbType.String, oGuia_Remision_Concentrado.IDProveedor_Dest);
            Db.AddInParameter(dbCmd, "Nro_Factura", DbType.String, oGuia_Remision_Concentrado.Nro_Factura);
            Db.AddInParameter(dbCmd, "Costo_Minimo", DbType.Double, oGuia_Remision_Concentrado.Costo_Minimo);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oGuia_Remision_Concentrado.Estado);
            Db.AddInParameter(dbCmd, "IDLugar_Emision", DbType.Int32, oGuia_Remision_Concentrado.IDLugar_Emision);
            Db.AddInParameter(dbCmd, "DES_IDUsuario_Despacho", DbType.String, oGuia_Remision_Concentrado.DES_IDUsuario_Despacho);
            Db.AddInParameter(dbCmd, "DES_IDLugar_Despacho", DbType.Int32, oGuia_Remision_Concentrado.DES_IDLugar_Despacho);
            Db.AddInParameter(dbCmd, "DES_FechaHora_Despacho", DbType.DateTime, oGuia_Remision_Concentrado.DES_FechaHora_Despacho);
            Db.AddInParameter(dbCmd, "DES_FechaHora_Inicio_Trasl", DbType.DateTime, oGuia_Remision_Concentrado.DES_FechaHora_Inicio_Trasl);
            Db.AddInParameter(dbCmd, "DES_Fecha_Emision_Valida", DbType.DateTime, oGuia_Remision_Concentrado.DES_Fecha_Emision_Valida);
            Db.AddInParameter(dbCmd, "DES_Peso_Bruto", DbType.Double, oGuia_Remision_Concentrado.DES_Peso_Bruto);
            Db.AddInParameter(dbCmd, "DES_Tara", DbType.Double, oGuia_Remision_Concentrado.DES_Tara);
            Db.AddInParameter(dbCmd, "DES_Observacion", DbType.String, oGuia_Remision_Concentrado.DES_Observacion);
            Db.AddInParameter(dbCmd, "DES_Precinto_Seguridad", DbType.String, oGuia_Remision_Concentrado.DES_Precinto_Seguridad);
            Db.AddInParameter(dbCmd, "REC_IDUsuario_Recepcion", DbType.String, oGuia_Remision_Concentrado.REC_IDUsuario_Recepcion);
            Db.AddInParameter(dbCmd, "REC_IDLugar_Recepcion", DbType.Int32, oGuia_Remision_Concentrado.REC_IDLugar_Recepcion);
            Db.AddInParameter(dbCmd, "REC_FechaHora_Recepcion", DbType.DateTime, oGuia_Remision_Concentrado.REC_FechaHora_Recepcion);
            Db.AddInParameter(dbCmd, "REC_FechaHoraFin_Recepcion", DbType.DateTime, oGuia_Remision_Concentrado.REC_FechaHoraFin_Recepcion);
            Db.AddInParameter(dbCmd, "REC_Peso_Bruto", DbType.Double, oGuia_Remision_Concentrado.REC_Peso_Bruto);
            Db.AddInParameter(dbCmd, "REC_Tara", DbType.Double, oGuia_Remision_Concentrado.REC_Tara);
            Db.AddInParameter(dbCmd, "REC_Flag_Guia_Procesada", DbType.Boolean, oGuia_Remision_Concentrado.REC_Flag_Guia_Procesada);
            Db.AddInParameter(dbCmd, "REC_Observacion", DbType.String, oGuia_Remision_Concentrado.REC_Observacion);
            Db.AddInParameter(dbCmd, "Tipo_Material", DbType.String, oGuia_Remision_Concentrado.Tipo_Material);
            Db.AddInParameter(dbCmd, "FechaHora_Salida", DbType.DateTime, oGuia_Remision_Concentrado.FechaHora_Salida);
            Db.AddInParameter(dbCmd, "FechaHora_Llegada", DbType.DateTime, oGuia_Remision_Concentrado.FechaHora_Llegada);
            Db.AddInParameter(dbCmd, "Obs_Llegada", DbType.String, oGuia_Remision_Concentrado.Obs_Llegada);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oGuia_Remision_Concentrado.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oGuia_Remision_Concentrado.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oGuia_Remision_Concentrado.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oGuia_Remision_Concentrado.DateEdit);
            Db.AddInParameter(dbCmd, "FlagTranspFacturado", DbType.Boolean, oGuia_Remision_Concentrado.FlagTranspFacturado);
            Db.AddInParameter(dbCmd, "Peso_Bruto_Total", DbType.Double, oGuia_Remision_Concentrado.Peso_Bruto_Total);
            Db.AddInParameter(dbCmd, "Nro_Placa_Veh", DbType.String, oGuia_Remision_Concentrado.Nro_Placa_Veh);
            Db.AddInParameter(dbCmd, "Nro_Placa_Car", DbType.String, oGuia_Remision_Concentrado.Nro_Placa_Car);
            Db.AddInParameter(dbCmd, "Cod_Sis_Transp", DbType.String, oGuia_Remision_Concentrado.Cod_Sis_Transp);
            Db.AddInParameter(dbCmd, "REC_Cod_Sis_Transp", DbType.String, oGuia_Remision_Concentrado.REC_Cod_Sis_Transp);
            Db.AddInParameter(dbCmd, "NroMuestra", DbType.Int16, oGuia_Remision_Concentrado.NroMuestra);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Nro_Serie, String Nro_Guia_Remision)
        {
            return Db.ExecuteNonQuery("Concentrado.spu_Guia_Remision_Concentrado_Eliminar", Nro_Serie,Nro_Guia_Remision);
        }
        
        public virtual CGuia_Remision_Concentrado Recuperar(String Nro_Serie, String Nro_Guia_Remision)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Guia_Remision_Concentrado_Recuperar", Nro_Serie,Nro_Guia_Remision).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getGuia_Remision_Concentrado(dtDatos.Rows[0]);
            else
            return new CGuia_Remision_Concentrado();
        }
        
        public virtual bool Existe(String Nro_Serie, String Nro_Guia_Remision)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Guia_Remision_Concentrado_Recuperar", Nro_Serie,Nro_Guia_Remision).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Nro_Serie, String Nro_Guia_Remision, out CGuia_Remision_Concentrado oGuia_Remision_Concentrado)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Concentrado.spu_Guia_Remision_Concentrado_Recuperar", Nro_Serie,Nro_Guia_Remision).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oGuia_Remision_Concentrado = getGuia_Remision_Concentrado(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oGuia_Remision_Concentrado = new CGuia_Remision_Concentrado();
            return false;
            }
        }
        
        public virtual IList<CGuia_Remision_Concentrado> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Concentrado.spu_Guia_Remision_Concentrado_Listar")){
            IList<CGuia_Remision_Concentrado> list = new List<CGuia_Remision_Concentrado>();
            while (dr.Read())
            list.Add(getGuia_Remision_Concentrado(dr));
            return list;
            }
        }
        #endregion
    }
}
