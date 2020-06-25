using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string MSSV { get; set; }

        [ForeignKey("MonHoc")]
        public int MonHocId { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
