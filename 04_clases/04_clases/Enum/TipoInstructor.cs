using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_clases.Enum
{
    public enum TipoInstructor
    {
        //si no asigna un value a cada item del a enumeracion
        //entonces C# les asigna un valor entero a cada uno
        General,
        LaboratorioFisica,
        LaboratorioQuimica,
        LaboratorioMatematicas,
        Deporte,
        Dibujo
    }
}
