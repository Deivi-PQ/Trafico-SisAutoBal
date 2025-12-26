using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Trafico.BusinessObjects.Seguridad;

namespace Trafico.BusinessObjects.Utils
{
    public partial class CMenu
    {
        [DataMember()]
        public String Cod_Acceso { get; set; }

        [DataMember()]
        public String Nombre_Acceso { get; set; }

        [DataMember()]
        public String Descripcion { get; set; }

        [DataMember()]
        public String Comando { get; set; }

        [DataMember()]
        public Int16 Nivel { get; set; }

        [DataMember()]
        public Char Estado { get; set; }
        [DataMember()]
        public string Class { get; set; }
        [DataMember()]
        public string Target { get; set; }

        [DataMember()]
        public String Cod_Sistema { get; set; }
        public IList<CAcceso> SubMenu { get; set; }

        public CMenu()
        {
        }

        public CMenu(String Cod_Acceso_, String Nombre_Acceso_, String Descripcion_, String Comando_, Int16 Nivel_, Char Estado_, string Cod_Sistema_, string Target_, string Class_, IList<CAcceso> SubMenu_)
        {
            Cod_Acceso = Cod_Acceso_;
            Nombre_Acceso = Nombre_Acceso_;
            Descripcion = Descripcion_;
            Comando = Comando_;
            Nivel = Nivel_;
            Estado = Estado_;
            Cod_Sistema = Cod_Sistema_;
            Target = Target_;
            Class = Class_;
            SubMenu = SubMenu_;
        }
    }
}
