
namespace Proyecto_Empleados
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Empleados
    {
        public int Clave_Emp { get; set; }
        public Nullable<int> Id_puesto { get; set; }
        [Required, MinLength(3, ErrorMessage ="El nombre minimo debe de tener 3 caracteres"), MaxLength(50,ErrorMessage ="El maximo son 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Este Campo es Obligatorio"), MinLength(3, ErrorMessage = "Debes de tener minimo 3 caracteres"), MaxLength(50, ErrorMessage = "El maximo son 50 caracteres")]

        public string ApPaterno { get; set; }
        [Required(ErrorMessage = "Este Campo es Obligatorio"), MinLength(3, ErrorMessage = "Debes de tener 3 caracteres"), MaxLength(50, ErrorMessage = "El maximo son 50 caracteres")]
        public string ApMaterno { get; set; }
     
        [Required(ErrorMessage = "Este Campo es Obligatorio") ]
        [DataType(DataType.Date)]
        [Display(Name ="Fecha de Nacimiento")]
        public System.DateTime FecNac { get; set; }

        [Required (ErrorMessage ="Este Campo es Obligatorio")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:$#.##}")]
public Nullable<decimal> Sueldo { get; set; }
    
        public virtual Departamentos Departamentos { get; set; }
    }
}
