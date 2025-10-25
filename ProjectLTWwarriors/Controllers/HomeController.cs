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

        public ActionResult iPhone()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Mac()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult iPad()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Watch()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TaiNghe_Loa()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PhuKien()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult WelcomeBack()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ThanhToanThanhCong()
        {
            // Lấy từ TempData
            var orderId = TempData["LastOrderId"] as string;

            // Giữ TempData sống thêm 1 request nữa để view đọc được
            TempData.Keep("LastOrderId");

            // Nếu TempData rỗng thì fallback sang Session
            if (string.IsNullOrEmpty(orderId))
            {
                var ds = Session["DonHangs"] as List<DonHang>;
                orderId = ds?.FirstOrDefault()?.MaDon;
            }

            System.Diagnostics.Debug.WriteLine(">>> OrderId được gửi sang View: " + (orderId ?? "NULL"));

            ViewBag.OrderId = orderId;
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



        // ============ CHECKOUT: Tạo đơn & chuyển tới chi tiết đơn ============
        // POST: /Home/TienHanhThanhToan
        [HttpPost]
        public ActionResult TienHanhThanhToan(
            string hoTen, string soDienThoai, string diaChi,
            string phuongThucThanhToan, string maKhuyenMai,
            decimal? phiVanChuyen, decimal? giamGia)
        {
            // Lấy giỏ hàng từ Session
            var gioHang = Session["GioHang"] as List<MatHangTrongGio>;
            if (gioHang == null || gioHang.Count == 0)
                return RedirectToAction("XemGioHang");

            // Tính tiền
            decimal tamTinh = gioHang.Sum(x => (decimal)x.SanPham.Price * x.SoLuong);
            decimal ship = phiVanChuyen ?? 0;
            decimal giam = giamGia ?? 0;
            decimal tong = Math.Max(0, tamTinh + ship - giam);

            // Tạo mã đơn
            string maDon = "DH" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            // Tạo object đơn hàng (dùng luôn items trong giỏ)
            var don = new DonHang
            {
                MaDon = maDon,
                CreatedAt = DateTime.Now, /*dòng CreateAt đó thể hiện cho biết khi đặt sẽ lấy thời gian thực tế lúc đặt*/
                HoTen = hoTen,
                SoDienThoai = soDienThoai,
                DiaChiDayDu = diaChi,
                PhuongThucThanhToan = phuongThucThanhToan,
                TrangThai = (phuongThucThanhToan ?? "").ToUpper().Contains("COD") ? "processing" : "paid",
                TamTinh = tamTinh,
                PhiVanChuyen = ship,
                GiamGia = giam,
                TongCong = tong,
                MaKhuyenMai = string.IsNullOrWhiteSpace(maKhuyenMai) ? null : maKhuyenMai,
                Items = gioHang.Select(x => new MatHangTrongGio { SanPham = x.SanPham, SoLuong = x.SoLuong }).ToList()
            };

            // Lưu vào Session “DonHangs”
            var ds = Session["DonHangs"] as List<DonHang> ?? new List<DonHang>();
            ds.Insert(0, don);
            Session["DonHangs"] = ds;

            // Xoá giỏ
            Session["GioHang"] = null;

            // Truyền orderId sang trang Thành công (sống 1 lần redirect)
            TempData["LastOrderId"] = maDon;

            System.Diagnostics.Debug.WriteLine(">> Đã tạo đơn: " + maDon);
            System.Diagnostics.Debug.WriteLine(">> TempData LastOrderId = " + maDon);


            // Đi đến trang thành công (nút ở đó sẽ dẫn qua chi tiết đơn)
            return RedirectToAction("ThanhToanThanhCong");
        }

        // GET: /Home/OrderDetail?id=...
        public ActionResult OrderDetail(string id)
        {
            var ds = Session["DonHangs"] as List<DonHang> ?? new List<DonHang>();
            var don = ds.FirstOrDefault(x => x.MaDon == id);
            if (don == null) return HttpNotFound("Không tìm thấy đơn hàng");
            return View(don); // Views/Home/OrderDetail.cshtml
        }

        // Tạo trang để check lịch sử mua hàng
        // GET: /Home/LichSuMuaHang
        public ActionResult LichSuMuaHang()
        {
            var ds = Session["DonHangs"] as List<DonHang> ?? new List<DonHang>();
            return View(ds);
        }
    }
}