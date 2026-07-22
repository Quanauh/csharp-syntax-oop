class BankAccount
{
    private string tkKhachHang;
    private decimal Sodu;
    public BankAccount(string a)
    {
        this.tkKhachHang = a;
        this.Sodu = 0;
    }

    // Thêm getter để nơi khác đọc được thông tin
    public string LaySoTK() => this.tkKhachHang;
    public decimal LaySoDu() => this.Sodu;

    public void Naptien(decimal a)
    {
        this.Sodu += a;
    }

    public void RutTien(decimal a)
    {
        // Kiểm tra đủ tiền trước khi trừ
        if (a > this.Sodu)
        {
            Console.WriteLine("Số dư không đủ để rút!");
            return;
        }
        this.Sodu -= a;
    }
}

class BankManager
{
    // Danh sách lưu tất cả tài khoản đã tạo (trong bộ nhớ, không dùng database)
    private List<BankAccount> ds = new List<BankAccount>();

    public void TaoTaiKhoan(string stk)
    {
        // Kiểm tra trùng số tài khoản
        if (TimTaiKhoan(stk) != null)
        {
            Console.WriteLine("Số tài khoản này đã tồn tại!");
            return;
        }
        ds.Add(new BankAccount(stk));
        Console.WriteLine("Tạo tài khoản thành công!");
    }

    public BankAccount? TimTaiKhoan(string stk)
    {
        foreach (var tk in ds)
        {
            if (tk.LaySoTK() == stk)
                return tk;
        }
        return null; // không tìm thấy
    }
}

class Program1
{
    // Một BankManager dùng chung cho cả chương trình
    static BankManager qlNganHang = new BankManager();

    static void Menu()
    {
        Console.WriteLine("        ===NganHangHuanBank===      ");
        Console.WriteLine("1.Tao tai khoan");
        Console.WriteLine("2.Dang nhap tai khoan");
        Console.WriteLine("0.Thoat");
        Console.Write("Chon chuc nang: ");
    }

    static void TaoTK()
    {
        Console.WriteLine("        ===TaoTK===      ");
        Console.Write("Nhap so tai khoan muon tao: ");
        string stk = Console.ReadLine()!;
        qlNganHang.TaoTaiKhoan(stk);
    }

    static void DangNhap()
    {
        Console.WriteLine("        ===Dang Nhap===      ");
        Console.Write("Nhap stk cua ban: ");
        string s = Console.ReadLine()!;

        // Tìm tài khoản đã tồn tại thay vì tạo mới
        BankAccount tk = qlNganHang.TimTaiKhoan(s);
        if (tk == null)
        {
            Console.WriteLine("Khong tim thay tai khoan nay!");
            return;
        }

        Console.WriteLine("Ban da dang nhap thanh cong");
        Xuly(tk); // truyền tài khoản đã tìm được vào
    }

    static void Xuly(BankAccount tk)
    {
        Console.WriteLine("        ===Xin Chao===      ");
        Console.WriteLine("1. Chuyen tien");
        Console.WriteLine("2. Nap Tien");
        Console.WriteLine("3. Rut tien");
        Console.WriteLine("0. Quay lai");
        Console.Write("Chon chuc nang: ");
        int t = int.Parse(Console.ReadLine()!);
        switch (t)
        {
            case 1:
                Chuyentien(tk);
                break;
            case 2:
                NapTien2(tk);
                break;
            case 3:
                Ruttien(tk);
                break;
        }
    }

    static void Chuyentien(BankAccount tk)
    {
        Console.WriteLine("        ===Chuyen Tien===      ");
        Console.Write("Nhap so tai khoan can chuyen: ");
        string stkDich = Console.ReadLine()!;

        BankAccount tkDich = qlNganHang.TimTaiKhoan(stkDich);
        if (tkDich == null)
        {
            Console.WriteLine("Khong tim thay tai khoan dich!");
            return;
        }

        Console.Write("Nhap so tien can chuyen: ");
        decimal soTien = decimal.Parse(Console.ReadLine()!);

        // Rut o tai khoan nguon, nap vao tai khoan dich
        tk.RutTien(soTien);
        tkDich.Naptien(soTien);
        Console.WriteLine("Chuyen tien thanh cong!");
    }

    static void Ruttien(BankAccount tk)
    {
        Console.WriteLine("        ===Rut Tien===      ");
        Console.Write("Nhap so tien can rut: ");
        decimal tienrut = decimal.Parse(Console.ReadLine()!);
        tk.RutTien(tienrut);
        Console.WriteLine($"So du cua ban la: {tk.LaySoDu()}");
    }

    static void NapTien2(BankAccount tk)
    {
        Console.WriteLine("        ===Nap Tien===      ");
        Console.Write("Nhap so tien can nap: ");
        decimal soTien = decimal.Parse(Console.ReadLine()!);
        tk.Naptien(soTien);
        Console.WriteLine($"So du cua ban la: {tk.LaySoDu()}");
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Menu();
            int t = int.Parse(Console.ReadLine()!);
            switch (t)
            {
                case 1:
                    TaoTK();
                    break;
                case 2:
                    DangNhap();
                    break;
                case 0:
                    return;
            }
        }
    }
}