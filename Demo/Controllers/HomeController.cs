using MyDatabase;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Controllers
{
    public class HomeController : ApiController
    {
        private QLSVDataContext dataContext = new QLSVDataContext();

        [HttpGet]
        public IHttpActionResult GetAllSinhVien()
        {
            return Ok(dataContext.SinhViens);
        }

        [HttpGet]
        public IHttpActionResult GetSinhVienByMSSV(string mssv)
        {
            var sinhVien = dataContext.SinhViens.FirstOrDefault(sv => sv.MSSV == mssv);
            return Ok(new SinhVien() { 
                HoTen = sinhVien.HoTen,
                Id = sinhVien.Id,
                MSSV = sinhVien.MSSV,
                MonHocId = sinhVien.MonHocId
            });
        }

        [HttpPost]
        public IHttpActionResult AddSinhVien(SinhVien sinhVien)
        {
            try
            {
                sinhVien.Id = 0;
                dataContext.SinhViens.Add(sinhVien);
                dataContext.SaveChanges();
                return Ok();
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateSinhVien(SinhVien sinhVien)
        {
            try
            {
                var sv = dataContext.SinhViens.FirstOrDefault(s => s.MSSV == sinhVien.MSSV);
                sv.MSSV = sinhVien.MSSV;
                sv.MonHocId = sinhVien.MonHocId;
                sv.HoTen = sinhVien.HoTen;

                dataContext.Entry(sv).State = EntityState.Modified;

                dataContext.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
                throw;
            }
        }
    }
}
