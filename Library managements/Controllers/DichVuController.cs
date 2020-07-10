using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_managements.Data;
using Library_managements.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SQLitePCL;

namespace Library_managements.Controllers
{
    
    public class DichVuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DichVuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Borrow()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }
        public async Task<IActionResult> BorrowDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Sach.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            var ls = new LichSuMuon();
            ls.maSach = book.maSach;
            return View(ls);
        }

        [HttpPost]
        public JsonResult GetReaderId(int rId)
        {
            var readerID = (from s in _context.DocGia where s.maDocGia == rId select s.tenDocGia).ToList();
            return Json(readerID);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save([Bind("maPhieuMuon,maSach,maDocGia,ngayMuon")] LichSuMuon lichSu)
        {
            var book = _context.Sach.Find(lichSu.maSach);
            book.tinhTrang = "unvailable";

            if (ModelState.IsValid)
            {

                _context.LichSuMuon.Add(lichSu);
                _context.SaveChanges();
                _context.Sach.Update(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Borrow));

            }
            return View(lichSu);

        }
        private bool SachExists(int id)
        {
            return _context.Sach.Any(e => e.maSach == id);
        }

        public IActionResult LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all book data
                var bookData = (from tempbook in _context.Sach
                                where tempbook.tinhTrang.Equals("available")
                                    select tempbook);

               
                //Search
                if (!string.IsNullOrEmpty(searchValue))
                {
                    bookData = bookData.Where(m => m.maSach.ToString() == searchValue || m.tacGia == searchValue || m.tenSach == searchValue);
                }

                //total number of rows count 
                recordsTotal = bookData.Count();
                //Paging 
                var data = bookData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }

        public IActionResult LoadBorrowBook()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;




                // Getting all book data
                var bookData = from tempBook in _context.Sach
                               join bTemp in _context.LichSuMuon on tempBook.maSach equals bTemp.maSach
                               join rTemp in _context.DocGia on bTemp.maDocGia equals rTemp.maDocGia
                          
                               select new { maPhieuMuon = bTemp.maPhieuMuon, tenSach = tempBook.tenSach,ngayMuon = bTemp.ngayMuon, tenDocGia = rTemp.tenDocGia };


                //Search
                if (!string.IsNullOrEmpty(searchValue))
                {
                    bookData = bookData.Where(m => m.tenSach == searchValue || m.tenDocGia == searchValue || m.maPhieuMuon.ToString() == searchValue);
                }

                //total number of rows count 
                recordsTotal = bookData.Count();
                //Paging 
                var data = bookData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPost]
        public IActionResult Send(int id, PhieuTra pt)
        {

            var ls = _context.LichSuMuon.Find(id);
            pt.maPhieuMuon = ls.maPhieuMuon;
            pt.maSach = ls.maSach;
            pt.ngayMuon = DateTime.Now;

            var book = _context.Sach.Find(ls.maSach);
            book.tinhTrang = "available";
            try
            {
                
                    if (ModelState.IsValid)
                    {

                        _context.PhieuTra.Add(pt);
                        _context.SaveChanges();
                        _context.Sach.Update(book);
                        _context.SaveChanges();
                    return Json(data: true);
                }
                else
                {
                    return Json(data: false);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
