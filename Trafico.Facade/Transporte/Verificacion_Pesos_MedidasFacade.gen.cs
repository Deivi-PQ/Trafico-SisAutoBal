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

namespace Trafico.Facade.Transporte
{
    
    
    [DataObject(true)]
    public partial class Verificacion_Pesos_MedidasFacade
    {
        
        private Verificacion_Pesos_MedidasDao verificacion_Pesos_Medidas;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Verificacion_Pesos_MedidasFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: verificacion_Pesos_Medidas = new Verificacion_Pesos_MedidasDao();
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
        public virtual bool Grabar(CVerificacion_Pesos_Medidas oVerificacion_Pesos_Medidas)
        {
            Error = "";
            hayError = false;
            MaterialFacade faMaterial = new MaterialFacade();
            //---Validando campos no nulos
            if (oVerificacion_Pesos_Medidas.IDVerificacion<=0)
            {
            	Error = "IDVerificacion no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oVerificacion_Pesos_Medidas.IDMaterial <= 0 && (!faMaterial.Existe(oVerificacion_Pesos_Medidas.IDMaterial))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oVerificacion_Pesos_Medidas.IDMaterial," en IDMaterial no existe. (Material, IDMaterial)");
            	hayError = true;
            	return false;
            }
            else
            	return verificacion_Pesos_Medidas.Grabar(oVerificacion_Pesos_Medidas);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CVerificacion_Pesos_Medidas oVerificacion_Pesos_Medidas, out string error)
        {
            bool rpta = Grabar(oVerificacion_Pesos_Medidas);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDVerificacion)
        {
            return verificacion_Pesos_Medidas.Eliminar(IDVerificacion);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CVerificacion_Pesos_Medidas Recuperar(Int32 IDVerificacion)
        {
            return verificacion_Pesos_Medidas.Recuperar(IDVerificacion);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDVerificacion)
        {
            return verificacion_Pesos_Medidas.Existe(IDVerificacion);
        }
        
        public virtual bool Existe(Int32 IDVerificacion, out CVerificacion_Pesos_Medidas oVerificacion_Pesos_Medidas)
        {
            return verificacion_Pesos_Medidas.Existe(IDVerificacion, out oVerificacion_Pesos_Medidas);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CVerificacion_Pesos_Medidas> Listar()
        {
            return verificacion_Pesos_Medidas.Listar();
        }
        #endregion
    }
}
