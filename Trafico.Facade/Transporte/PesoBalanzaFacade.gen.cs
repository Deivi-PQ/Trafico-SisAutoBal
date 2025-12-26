//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNetCore.InfoApp;
using Trafico.BusinessObjects.Transporte;
using Trafico.DataObjects.Transporte;
using Trafico.Facade.Transporte;
using Trafico.Facade.Transporte;
using Trafico.Facade.Global;
using System.Data;

namespace Trafico.Facade.Transporte
{
    
    
    [DataObject(true)]
    public partial class PesoBalanzaFacade
    {
        
        private PesoBalanzaDao pesoBalanza;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public PesoBalanzaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: pesoBalanza = new PesoBalanzaDao();
            break;
            }
        }
        #endregion
        
        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }
        
        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion
        
        #region Metodos Basicos
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPesoBalanza oPesoBalanza)
        {
            Error = "";
            hayError = false;
            BalanzaFacade faBalanza = new BalanzaFacade();
            MaterialFacade faMaterial = new MaterialFacade();
            VehiculoFacade faVehiculo = new VehiculoFacade();
            //---Validando campos no nulos
            if (!oPesoBalanza.IDPesaje.HasValue || oPesoBalanza.IDPesaje.Value <= 0)
            {
                Error = "IDPesaje no puede ser vacío.";
                hayError = true;
                return false;
            }
            //---Validando referencias foraneas
            else if (!string.IsNullOrWhiteSpace(oPesoBalanza.IDBalanza) && !faBalanza.Existe(oPesoBalanza.IDBalanza))
            {//---No existe clave foranea pero permite vacio
                Error = string.Concat("El valor ", oPesoBalanza.IDBalanza, " en IDBalanza no existe. (Balanza, IDBalanza)");
                hayError = true;
                return false;
            }
            else if (oPesoBalanza.IDMaterial.HasValue && !faMaterial.Existe(oPesoBalanza.IDMaterial.Value))
            {//---No existe clave foranea pero permite vacio
                Error = string.Concat("El valor ", oPesoBalanza.IDMaterial, " en IDMaterial no existe. (Material, IDMaterial)");
                hayError = true;
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(oPesoBalanza.Nro_Placa) && !faVehiculo.Existe(oPesoBalanza.Nro_Placa))
            {//---No existe clave foranea pero permite vacio
                Error = string.Concat("El valor ", oPesoBalanza.Nro_Placa, " en Nro_Placa no existe. (Vehiculo, Nro_Placa)");
                hayError = true;
                return false;
            }
            else
                return pesoBalanza.Grabar(oPesoBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPesoBalanza oPesoBalanza, out string error)
        {
            bool rpta = Grabar(oPesoBalanza);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDPesaje)
        {
            return pesoBalanza.Eliminar(IDPesaje);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CPesoBalanza Recuperar(Int32 IDPesaje)
        {
            return pesoBalanza.Recuperar(IDPesaje);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDPesaje)
        {
            return pesoBalanza.Existe(IDPesaje);
        }
        
        public virtual bool Existe(Int32 IDPesaje, out CPesoBalanza oPesoBalanza)
        {
            return pesoBalanza.Existe(IDPesaje, out oPesoBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CPesoBalanza> Listar(String IDBalanza, String ID, String Nro_Placa, DateTime fecha_Ini, DateTime fecha_Fin, int page_Number, int page_Size)
        {
            return pesoBalanza.Listar( IDBalanza, ID, Nro_Placa, fecha_Ini,fecha_Fin,page_Number,page_Size);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable ReportePesoBalanza(DateTime fecha_Ini, DateTime fecha_Fin, String Nro_Placa)
        {
            return pesoBalanza.ReportePesoBalanza(fecha_Ini, fecha_Fin, Nro_Placa);
        }

        #endregion
    }
}
