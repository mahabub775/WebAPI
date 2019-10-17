using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Student
    {
        Student()
        {
            StudentID = 0;
            Trade = "";
            Lavel = "";
            Language = "";
            SyllabusName = "";
            SyllabusFile = "";
            TestPlanFile = "";
            DeptOffName = "";
            ManagerName = "";
            ActiveDate = new DateTime(1800, 01, 01); //yy-mm-dd
        }
        [Key]
        public int StudentID { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Trade { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Lavel { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Language { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string SyllabusName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string SyllabusFile { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string TestPlanFile { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string DeptOffName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string ManagerName { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime ActiveDate { get; set; }

        #region Derived variable
        public string TradeSt
        {
            get
            {
                //CSE=1, ETE=2, BBA=3
                if (this.Trade == "A") { return "CSE"; }
                else if (this.Trade =="B" ) { return "ETE"; }
                else if (this.Trade == "C") { return "BBA"; }
                else { return ""; }

            }
        }
        public string LavelSt
        {
            get
            {
                if (this.Lavel == "1") { return "Programming"; }
                else if (this.Lavel == "2") { return "Algorithm"; }
                else if (this.Lavel == "3") { return "Electrical"; }
                else if (this.Lavel == "4") { return "Microwave"; }
                else if (this.Lavel == "5") { return "Management"; }
                else if (this.Lavel == "6") { return "Statistics"; }
                
                else { return ""; }

            }
        }
        
        public string ActiveDateSt
        {
            get
            {

                return this.ActiveDate>new DateTime(1800, 01, 01)? this.ActiveDate.ToString("MM/dd/yyyy"):"";
            }
        }
        #endregion
    }
}
