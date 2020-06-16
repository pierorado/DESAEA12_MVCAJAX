using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }

        [Required]
        public string studentName { get; set; }

        [Required]
        public string studentLastName { get; set; }

        [Required]
        public string studentAddress { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime studentFechaCreacion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime studentFechaModificacion { get; set; }
    }
}
