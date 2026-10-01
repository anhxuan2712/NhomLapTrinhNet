using System;
using System.Collections.Generic;
using System.Linq;

abstract class PhuongTien
{
    private string _maPT;
    private string _tenHang;
    private int _namSanXuat;
    private decimal _giaGoc;

    public string MaPT
    {
        get { return _maPT; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _maPT = "PT000";
            else
                _maPT = value;
        }
    }

    public string TenHang
    {
        get { return _tenHang; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên hãng không được để trống!");

            _tenHang = value;
        }
    }

    public int NamSanXuat
    {
        get { return _namSanXuat; }
        set
        {
            int namHienTai = DateTime.Now.Year;

            if (value < 1900 || value > namHienTai)
                throw new ArgumentException(
                    "Năm sản xuất phải từ 1900 đến " + namHienTai + "!");

            _namSanXuat = value;
        }
    }

    public decimal GiaGoc
    {
        get { return _giaGoc; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Giá gốc phải lớn hơn 0!");

            _giaGoc = value;
        }
    }

    public PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
    {
        MaPT = maPT;
        TenHang = tenHang;
        NamSanXuat = namSanXuat;
        GiaGoc = giaGoc;
    }

    public abstract decimal TinhGiaLanBanh();

    public virtual string GetInfo()
    {
        return "Mã PT: " + MaPT +
               " | Hãng: " + TenHang +
               " | Năm SX: " + NamSanXuat +
               " | Giá gốc: " + GiaGoc.ToString("N0") + " VNĐ";
    }
}


class OTo : PhuongTien
{
    private int _soChoNgoi;
    private double _dungTichDongCo;

    public int SoChoNgoi
    {
        get { return _soChoNgoi; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0!");

            _soChoNgoi = value;
        }
    }

    public double DungTichDongCo
    {
        get { return _dungTichDongCo; }
        set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Dung tích động cơ phải lớn hơn 0!");

            _dungTichDongCo = value;
        }
    }

    public OTo(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc,
        int soChoNgoi,
        double dungTichDongCo)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        SoChoNgoi = soChoNgoi;
        DungTichDongCo = dungTichDongCo;
    }

    public override decimal TinhGiaLanBanh()
    {
        if (SoChoNgoi <= 9)
        {
            return GiaGoc
                + GiaGoc * 0.12m
                + GiaGoc * 0.30m;
        }
        else
        {
            return GiaGoc
                + GiaGoc * 0.10m;
        }
    }

    public override string GetInfo()
    {
        return base.GetInfo() +
               " | Số chỗ: " + SoChoNgoi +
               " | Dung tích động cơ: " + DungTichDongCo + " L";
    }
}


class XeMay : PhuongTien
{
    private int _dungTichXylanh;

    public int DungTichXylanh
    {
        get { return _dungTichXylanh; }
        set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Dung tích xy-lanh phải lớn hơn 0!");

            _dungTichXylanh = value;
        }
    }

    public XeMay(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc,
        int dungTichXylanh)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        DungTichXylanh = dungTichXylanh;
    }

    public override decimal TinhGiaLanBanh()
    {
        if (DungTichXylanh < 175)
        {
            return GiaGoc + GiaGoc * 0.02m;
        }
        else
        {
            return GiaGoc + GiaGoc * 0.05m;
        }
    }

    public override string GetInfo()
    {
        return base.GetInfo() +
               " | Dung tích xy-lanh: " + DungTichXylanh + " cc";
    }
}


class QuanLyPhuongTien
{
    private List<PhuongTien> danhSach;

    public QuanLyPhuongTien()
    {
        danhSach = new List<PhuongTien>();
    }

    public void AddPhuongTien(PhuongTien pt)
    {
        danhSach.Add(pt);
        Console.WriteLine("Đã thêm phương tiện thành công!");
    }

    public void DisplayAll()
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sách phương tiện đang trống!");
            return;
        }

        Console.WriteLine("\n========== DANH SÁCH PHƯƠNG TIỆN ==========");

        foreach (PhuongTien pt in danhSach)
        {
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine(
                "Giá lăn bánh: " +
                pt.TinhGiaLanBanh().ToString("N0") +
                " VNĐ");
            Console.WriteLine("--------------------------------------------");
        }
    }

    public PhuongTien FindMaxGiaLanBanh()
    {
        if (danhSach.Count == 0)
            return null;

        return danhSach
            .OrderByDescending(pt => pt.TinhGiaLanBanh())
            .First();
    }

    public List<PhuongTien> SearchByName(string keyword)
    {
        return danhSach
            .Where(pt =>
                pt.TenHang.Contains(
                    keyword,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}


class Program
{
    static void Main(string[] args)
    {
        QuanLyPhuongTien quanLy = new QuanLyPhuongTien();

        while (true)
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("   HỆ THỐNG QUẢN LÝ PHƯƠNG TIỆN");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Thêm ô tô");
            Console.WriteLine("2. Thêm xe máy");
            Console.WriteLine("3. Hiển thị tất cả phương tiện");
            Console.WriteLine("4. Tìm phương tiện có giá lăn bánh cao nhất");
            Console.WriteLine("5. Tìm phương tiện theo tên hãng");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("======================================");
            Console.Write("Chọn chức năng: ");

            string luaChon = Console.ReadLine();

            try
            {
                switch (luaChon)
                {
                    case "1":
                        ThemOTo(quanLy);
                        break;

                    case "2":
                        ThemXeMay(quanLy);
                        break;

                    case "3":
                        quanLy.DisplayAll();
                        break;

                    case "4":
                        TimGiaLanBanhCaoNhat(quanLy);
                        break;

                    case "5":
                        TimTheoTenHang(quanLy);
                        break;

                    case "0":
                        Console.WriteLine("Đã thoát chương trình!");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }


    static void ThemOTo(QuanLyPhuongTien quanLy)
    {
        Console.WriteLine("\n========== THÊM Ô TÔ ==========");

        Console.Write("Nhập mã phương tiện: ");
        string maPT = Console.ReadLine();

        Console.Write("Nhập tên hãng: ");
        string tenHang = Console.ReadLine();

        Console.Write("Nhập năm sản xuất: ");
        int namSanXuat = int.Parse(Console.ReadLine());

        Console.Write("Nhập giá gốc: ");
        decimal giaGoc = decimal.Parse(Console.ReadLine());

        Console.Write("Nhập số chỗ ngồi: ");
        int soChoNgoi = int.Parse(Console.ReadLine());

        Console.Write("Nhập dung tích động cơ (L): ");
        double dungTichDongCo = double.Parse(Console.ReadLine());

        OTo oto = new OTo(
            maPT,
            tenHang,
            namSanXuat,
            giaGoc,
            soChoNgoi,
            dungTichDongCo);

        quanLy.AddPhuongTien(oto);
    }


    static void ThemXeMay(QuanLyPhuongTien quanLy)
    {
        Console.WriteLine("\n========== THÊM XE MÁY ==========");

        Console.Write("Nhập mã phương tiện: ");
        string maPT = Console.ReadLine();

        Console.Write("Nhập tên hãng: ");
        string tenHang = Console.ReadLine();

        Console.Write("Nhập năm sản xuất: ");
        int namSanXuat = int.Parse(Console.ReadLine());

        Console.Write("Nhập giá gốc: ");
        decimal giaGoc = decimal.Parse(Console.ReadLine());

        Console.Write("Nhập dung tích xy-lanh (cc): ");
        int dungTichXylanh = int.Parse(Console.ReadLine());

        XeMay xeMay = new XeMay(
            maPT,
            tenHang,
            namSanXuat,
            giaGoc,
            dungTichXylanh);

        quanLy.AddPhuongTien(xeMay);
    }


    static void TimGiaLanBanhCaoNhat(QuanLyPhuongTien quanLy)
    {
        PhuongTien pt = quanLy.FindMaxGiaLanBanh();

        if (pt == null)
        {
            Console.WriteLine("Danh sách phương tiện đang trống!");
            return;
        }

        Console.WriteLine("\n===== PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT =====");
        Console.WriteLine(pt.GetInfo());
        Console.WriteLine(
            "Giá lăn bánh: " +
            pt.TinhGiaLanBanh().ToString("N0") +
            " VNĐ");
    }


    static void TimTheoTenHang(QuanLyPhuongTien quanLy)
    {
        Console.Write("\nNhập tên hãng cần tìm: ");
        string keyword = Console.ReadLine();

        List<PhuongTien> ketQua =
            quanLy.SearchByName(keyword);

        if (ketQua.Count == 0)
        {
            Console.WriteLine("Không tìm thấy phương tiện!");
            return;
        }

        Console.WriteLine("\n========== KẾT QUẢ TÌM KIẾM ==========");

        foreach (PhuongTien pt in ketQua)
        {
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine(
                "Giá lăn bánh: " +
                pt.TinhGiaLanBanh().ToString("N0") +
                " VNĐ");
            Console.WriteLine("---------------------------------------");
        }
    }
}