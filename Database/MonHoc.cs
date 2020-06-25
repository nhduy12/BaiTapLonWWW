using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class MonHoc
    {
        public int Id { get; set; }
        public string TenMonHoc { get; set; }

        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
