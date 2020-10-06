using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApi.Data
{
    public class StudentInfo
    {
        public int StudID { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int TotalMarks { get; set; }
    }
}
