//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 17 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNetCore.InfoApp;
using Trafico.BusinessObjects.AutoBal;
using Trafico.DataObjects.AutoBal;

namespace Trafico.Facade.AutoBal
{
    
    
    [DataObject(true)]
    public partial class ComandosFacade
    {
        
        private ComandosDao omandos;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public ComandosFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: omandos = new ComandosDao();
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
        public virtual bool Grabar(Comandos oomandos)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oomandos.id<0)
            {
            	Error = "id no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return omandos.Grabar(oomandos);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(Comandos oomandos, out string error)
        {
            bool rpta = Grabar(oomandos);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 id)
        {
            return omandos.Eliminar(id);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual Comandos Recuperar(String sn)
        {
            return omandos.Recuperar(sn);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 id)
        {
            return omandos.Existe(id);
        }
        
        public virtual bool Existe(Int32 id, out Comandos oomandos)
        {
            return omandos.Existe(id, out oomandos);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<Comandos> Listar()
        {
            return omandos.Listar();
        }
        #endregion
    }
}
