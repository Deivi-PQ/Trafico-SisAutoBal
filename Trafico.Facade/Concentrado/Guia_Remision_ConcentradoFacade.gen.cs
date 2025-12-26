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
using Trafico.BusinessObjects.Concentrado;
using Trafico.DataObjects.Concentrado;
using Trafico.Facade.Transporte;
using Trafico.Facade.Global;
using Trafico.Facade.Global;
using Trafico.Facade.Global;
using Trafico.Facade.Concentrado;
using Trafico.Facade.Concentrado;

namespace Trafico.Facade.Concentrado
{
    
    
    [DataObject(true)]
    public partial class Guia_Remision_ConcentradoFacade
    {
        
        private Guia_Remision_ConcentradoDao guia_Remision_Concentrado;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Guia_Remision_ConcentradoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: guia_Remision_Concentrado = new Guia_Remision_ConcentradoDao();
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
        public virtual bool Grabar(CGuia_Remision_Concentrado oGuia_Remision_Concentrado)
        {
            Error = "";
            hayError = false;
            Sistema_TranspFacade faSistema_Transp = new Sistema_TranspFacade();
            LugarFacade faLugar = new LugarFacade();
            Lote_ConcentradoFacade faLote_Concentrado = new Lote_ConcentradoFacade();
            Serie_Guia_ConcentradoFacade faSerie_Guia_Concentrado = new Serie_Guia_ConcentradoFacade();
            //---Validando campos no nulos
            if (oGuia_Remision_Concentrado.Nro_Serie.Trim() == "")
            {
            	Error = "Nro_Serie no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oGuia_Remision_Concentrado.Nro_Guia_Remision.Trim() == "")
            {
            	Error = "Nro_Guia_Remision no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oGuia_Remision_Concentrado.Cod_Sis_Transp.Trim() != "" && (!faSistema_Transp.Existe(oGuia_Remision_Concentrado.Cod_Sis_Transp))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oGuia_Remision_Concentrado.Cod_Sis_Transp," en Cod_Sis_Transp no existe. (Sistema_Transp, Cod_Sis_Transp)");
            	hayError = true;
            	return false;
            }
            else if ((oGuia_Remision_Concentrado.REC_IDLugar_Recepcion <= 0 && (!faLugar.Existe(oGuia_Remision_Concentrado.REC_IDLugar_Recepcion))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oGuia_Remision_Concentrado.REC_IDLugar_Recepcion," en REC_IDLugar_Recepcion no existe. (Lugar, REC_IDLugar_Recepcion)");
            	hayError = true;
            	return false;
            }
            else if ((oGuia_Remision_Concentrado.DES_IDLugar_Despacho <= 0 && (!faLugar.Existe(oGuia_Remision_Concentrado.DES_IDLugar_Despacho))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oGuia_Remision_Concentrado.DES_IDLugar_Despacho," en DES_IDLugar_Despacho no existe. (Lugar, DES_IDLugar_Despacho)");
            	hayError = true;
            	return false;
            }
            else if ((oGuia_Remision_Concentrado.IDLugar_Emision <= 0 && (!faLugar.Existe(oGuia_Remision_Concentrado.IDLugar_Emision))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oGuia_Remision_Concentrado.IDLugar_Emision," en IDLugar_Emision no existe. (Lugar, IDLugar_Emision)");
            	hayError = true;
            	return false;
            }
            else if ((oGuia_Remision_Concentrado.Nro_Lote.Trim() != "" && (!faLote_Concentrado.Existe(oGuia_Remision_Concentrado.Nro_Lote))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oGuia_Remision_Concentrado.Nro_Lote," en Nro_Lote no existe. (Lote_Concentrado, Nro_Lote)");
            	hayError = true;
            	return false;
            }
            else if (!faSerie_Guia_Concentrado.Existe(oGuia_Remision_Concentrado.Nro_Serie))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oGuia_Remision_Concentrado.Nro_Serie," en Nro_Serie no existe. (Serie_Guia_Concentrado, Nro_Serie)");
            	hayError = true;
            	return false;
            }
            else
            	return guia_Remision_Concentrado.Grabar(oGuia_Remision_Concentrado);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CGuia_Remision_Concentrado oGuia_Remision_Concentrado, out string error)
        {
            bool rpta = Grabar(oGuia_Remision_Concentrado);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Nro_Serie, String Nro_Guia_Remision)
        {
            return guia_Remision_Concentrado.Eliminar(Nro_Serie,Nro_Guia_Remision);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CGuia_Remision_Concentrado Recuperar(String Nro_Serie, String Nro_Guia_Remision)
        {
            return guia_Remision_Concentrado.Recuperar(Nro_Serie,Nro_Guia_Remision);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Nro_Serie, String Nro_Guia_Remision)
        {
            return guia_Remision_Concentrado.Existe(Nro_Serie,Nro_Guia_Remision);
        }
        
        public virtual bool Existe(String Nro_Serie, String Nro_Guia_Remision, out CGuia_Remision_Concentrado oGuia_Remision_Concentrado)
        {
            return guia_Remision_Concentrado.Existe(Nro_Serie,Nro_Guia_Remision, out oGuia_Remision_Concentrado);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CGuia_Remision_Concentrado> Listar()
        {
            return guia_Remision_Concentrado.Listar();
        }
        #endregion
    }
}
