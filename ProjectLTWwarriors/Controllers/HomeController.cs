using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectLTWwarriors.Data;
using ProjectLTWwarriors.Models;

namespace ProjectLTWwarriors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var products = ProductData.GetAllProducts();  // lấy danh sách sản phẩm
            return View(products);
        }

        public ActionResult LandingPage()
        {
            var products = ProductData.GetAllProducts(); // Lấy danh sách sản phẩm
            return View(products); // Truyền vào View
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        

        public ActionResult ProductDetail(int? id)
        {
            if (id == null)
                return RedirectToAction("Index"); // hoặc trả về view thông báo lỗi

            var product = ProductData.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }




        // Action để hiển thị trang giỏ hàng
        public ActionResult GioHangTrong()
        {
            // Lấy giỏ hàng từ Session
            var gioHang = Session["GioHang"] as List<MatHangTrongGio>;

            // Nếu giỏ hàng chưa có hoặc không có sản phẩm nào
            if (gioHang == null || gioHang.Count == 0)
            {
                // Trả về view giỏ hàng trống
                return View("GioHangTrong"); // Bạn cần tạo 1 view tên là GioHangTrong.cshtml
            }

            // Nếu có sản phẩm, trả về view với danh sách mặt hàng
            return View(gioHang);
        }

        //// Action để xử lý việc thêm sản phẩm vào giỏ (sẽ được gọi bằng JavaScript)
        //[HttpPost]
        //public ActionResult GioHangCoSanPham(int maSP, int soLuong)
        //{
        //    // Lấy giỏ hàng hiện tại từ Session
        //    var gioHang = Session["GioHang"] as List<MatHangTrongGio>;

        //    // Nếu chưa có giỏ hàng, tạo mới
        //    if (gioHang == null)
        //    {
        //        gioHang = new List<MatHangTrongGio>();
        //    }

        //    // Kiểm tra xem sản phẩm đã có trong giỏ chưa
        //    var matHang = gioHang.FirstOrDefault(m => m.SanPham.Id == maSP);

        //    if (matHang == null) // Nếu chưa có
        //    {
        //        // Tìm sản phẩm trong "database" (lớp ProductData)
        //        var sanPham = ProductData.GetAllProducts().FirstOrDefault(p => p.Id == maSP);
        //        if (sanPham != null)
        //        {
        //            // Tạo một mặt hàng mới và thêm vào giỏ
        //            var matHangMoi = new MatHangTrongGio
        //            {
        //                SanPham = sanPham,
        //                SoLuong = soLuong
        //            };
        //            gioHang.Add(matHangMoi);
        //        }
        //    }
        //    else // Nếu đã có
        //    {
        //        // Chỉ cần cập nhật lại số lượng
        //        matHang.SoLuong += soLuong;
        //    }

        //    // Lưu giỏ hàng trở lại vào Session
        //    Session["GioHang"] = gioHang;

        //    // Trả về kết quả JSON để JavaScript biết đã thành công
        //    return Json(new { success = true, message = "Đã thêm sản phẩm vào giỏ hàng!" });



        // HÀM SỐ 1: DÙNG ĐỂ "XEM" GIỎ HÀNG
        // Đây là hàm duy nhất bạn cần để hiển thị trang giỏ hàng.
        // URL đúng để vào trang này là: /Home/XemGioHang
        public ActionResult XemGioHang()
        {
            // Lấy giỏ hàng từ Session ra kiểm tra
            var gioHang = Session["GioHang"] as List<MatHangTrongGio>;

            // Controller sẽ TỰ QUYẾT ĐỊNH xem nên hiển thị giao diện nào
            if (gioHang == null || gioHang.Count == 0)
            {
                // NẾU GIỎ HÀNG TRỐNG:
                // Trả về file giao diện tên là "GioHangTrong.cshtml"
                return View("GioHangTrong");
            }
            else
            {
                // NẾU GIỎ HÀNG CÓ SẢN PHẨM:
                // Trả về file giao diện tên là "GioHangCoSanPham.cshtml" và gửi kèm dữ liệu.
                return View("GioHangCoSanPham", gioHang);
            }
        }

        // HÀM SỐ 2: DÙNG ĐỂ "THÊM" SẢN PHẨM VÀO GIỎ
        // Tên của nó phải mô tả đúng hành động nó làm.
        // [HttpPost] là quy tắc đặc biệt: "Chỉ JavaScript mới được gọi hàm này, gõ trên trình duyệt sẽ không chạy!"
        [HttpPost]
        public ActionResult ThemVaoGio(int maSP, int soLuong)
        {
            // Lấy giỏ hàng hiện tại từ Session
            var gioHang = Session["GioHang"] as List<MatHangTrongGio>;

            // Nếu chưa có giỏ hàng, tạo mới
            if (gioHang == null)
            {
                gioHang = new List<MatHangTrongGio>();
            }

            // Kiểm tra xem sản phẩm đã có trong giỏ chưa
            var matHang = gioHang.FirstOrDefault(m => m.SanPham.Id == maSP);

            if (matHang == null) // Nếu chưa có
            {
                var sanPham = ProductData.GetAllProducts().FirstOrDefault(p => p.Id == maSP);
                if (sanPham != null)
                {
                    gioHang.Add(new MatHangTrongGio { SanPham = sanPham, SoLuong = soLuong });
                }
            }
            else // Nếu đã có
            {
                matHang.SoLuong += soLuong;
            }

            // Lưu giỏ hàng trở lại vào Session
            Session["GioHang"] = gioHang;

            // Trả về thông báo cho JavaScript
            return Json(new { success = true, message = "Đã thêm sản phẩm vào giỏ hàng!" });
        }
    }

    
}   