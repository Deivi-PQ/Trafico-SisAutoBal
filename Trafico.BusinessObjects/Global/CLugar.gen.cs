//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 11 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Trafico.BusinessObjects.Global
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CLugar
    {
        
        [DataMember()]
        public Int32 IDLugar {get;set;}
        
        [DataMember()]
        public String Cod_Lugar {get;set;}
        
        [DataMember()]
        public String Descripcion {get;set;}
        
        [DataMember()]
        public String Observaciones {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        [DataMember()]
        public Char Status {get;set;}
        
        [DataMember()]
        public String Distrito {get;set;}
        
        [DataMember()]
        public String Provincia {get;set;}
        
        [DataMember()]
        public String Departamento {get;set;}
        
        #region Constructores
        // Constructores
        public CLugar()
        {
        }
        
        public CLugar(Int32 IDLugar_, String Cod_Lugar_, String Descripcion_, String Observaciones_, String UserNew_, DateTime DateNew_, String UserEdit_, DateTime DateEdit_, Char Status_, String Distrito_, String Provincia_, String Departamento_)
        {
            IDLugar = IDLugar_;
            Cod_Lugar = Cod_Lugar_;
            Descripcion = Descripcion_;
            Observaciones = Observaciones_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
            Status = Status_;
            Distrito = Distrito_;
            Provincia = Provincia_;
            Departamento = Departamento_;
        }
        #endregion
    }
}
