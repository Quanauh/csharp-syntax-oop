using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccountApp
{
    // Lớp đại diện cho 1 tài khoản
    class Account
    {
        public string AccountNumber { get; }
        public string OwnerName { get; }
        public decimal Balance { get; set; }

        public Account(string accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
        }

        public override string ToString()
        {
            return $"{AccountNumber,-10} | {OwnerName,-20} | {Balance,15:N0} VND";
        }
    }

    // Lớp quản lý toàn bộ nghiệp vụ, lưu dữ liệu trong bộ nhớ (không DB)
    class BankManager
    {
        private readonly Dictionary<string, Account> _accounts = new Dictionary<string, Account>();
        private int _nextId = 1;

        public Account CreateAccount(string ownerName, decimal initialBalance)
        {
            string accNumber = $"ACC{_nextId:D4}";
            _nextId++;
            var acc = new Account(accNumber, ownerName, initialBalance);
            _accounts[accNumber] = acc;
            return acc;
        }

        public bool TryGetAccount(string accNumber, out Account account)
        {
            return _accounts.TryGetValue(accNumber, out account);
        }

        public void Deposit(string accNumber, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Số tiền nộp phải lớn hơn 0.");

            if (!_accounts.TryGetValue(accNumber, out var acc))
                throw new KeyNotFoundException($"Không tìm thấy tài khoản {accNumber}.");

            acc.Balance += amount;
        }

        public void Withdraw(string accNumber, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Số tiền rút phải lớn hơn 0.");

            if (!_accounts.TryGetValue(accNumber, out var acc))
                throw new KeyNotFoundException($"Không tìm thấy tài khoản {accNumber}.");

            if (acc.Balance < amount)
                throw new InvalidOperationException("Số dư không đủ để rút.");

            acc.Balance -= amount;
        }

        public void Transfer(string fromAcc, string toAcc, decimal amount)
        {
            if (fromAcc == toAcc)
                throw new ArgumentException("Không thể chuyển tiền cho chính tài khoản đó.");

            if (!_accounts.ContainsKey(fromAcc))
                throw new KeyNotFoundException($"Không tìm thấy tài khoản nguồn {fromAcc}.");

            if (!_accounts.ContainsKey(toAcc))
                throw new KeyNotFoundException($"Không tìm thấy tài khoản đích {toAcc}.");

            // Rút trước, nộp sau - nếu rút lỗi thì không thực hiện nộp
            Withdraw(fromAcc, amount);
            Deposit(toAcc, amount);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accounts.Values.OrderBy(a => a.AccountNumber);
        }
    }

    class Program
    {
        static BankManager _bank = new BankManager();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SeedSampleData();

            bool running = true;
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine()?.Trim();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            CreateAccountUI();
                            break;
                        case "2":
                            DepositUI();
                            break;
                        case "3":
                            WithdrawUI();
                            break;
                        case "4":
                            TransferUI();
                            break;
                        case "5":
                            ListAccountsUI();
                            break;
                        case "0":
                            running = false;
                            Console.WriteLine("Tạm biệt!");
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }

                if (running)
                {
                    Console.WriteLine("\nNhấn Enter để tiếp tục...");
                    Console.ReadLine();
                }
            }
        }

        static void SeedSampleData()
        {
            _bank.CreateAccount("Nguyen Van A", 1_000_000);
            _bank.CreateAccount("Tran Thi B", 500_000);
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== QUẢN LÝ TÀI KHOẢN TIỀN =====");
            Console.WriteLine("1. Tạo tài khoản mới");
            Console.WriteLine("2. Nộp tiền");
            Console.WriteLine("3. Rút tiền");
            Console.WriteLine("4. Chuyển tiền giữa các tài khoản");
            Console.WriteLine("5. Xem danh sách tài khoản");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
        }

        static void CreateAccountUI()
        {
            Console.Write("Nhập tên chủ tài khoản: ");
            string name = Console.ReadLine();

            Console.Write("Nhập số dư ban đầu: ");
            decimal initialBalance = ReadDecimal();

            var acc = _bank.CreateAccount(name, initialBalance);
            Console.WriteLine($"Đã tạo tài khoản: {acc}");
        }

        static void DepositUI()
        {
            Console.Write("Nhập số tài khoản: ");
            string accNumber = Console.ReadLine()?.Trim();

            Console.Write("Nhập số tiền muốn nộp: ");
            decimal amount = ReadDecimal();

            _bank.Deposit(accNumber, amount);
            _bank.TryGetAccount(accNumber, out var acc);
            Console.WriteLine($"Nộp tiền thành công. Số dư mới: {acc.Balance:N0} VND");
        }

        static void WithdrawUI()
        {
            Console.Write("Nhập số tài khoản: ");
            string accNumber = Console.ReadLine()?.Trim();

            Console.Write("Nhập số tiền muốn rút: ");
            decimal amount = ReadDecimal();

            _bank.Withdraw(accNumber, amount);
            _bank.TryGetAccount(accNumber, out var acc);
            Console.WriteLine($"Rút tiền thành công. Số dư mới: {acc.Balance:N0} VND");
        }

        static void TransferUI()
        {
            Console.Write("Nhập số tài khoản nguồn: ");
            string fromAcc = Console.ReadLine()?.Trim();

            Console.Write("Nhập số tài khoản đích: ");
            string toAcc = Console.ReadLine()?.Trim();

            Console.Write("Nhập số tiền muốn chuyển: ");
            decimal amount = ReadDecimal();

            _bank.Transfer(fromAcc, toAcc, amount);
            Console.WriteLine("Chuyển tiền thành công.");
        }

        static void ListAccountsUI()
        {
            Console.WriteLine("\nSố TK      | Chủ tài khoản        | Số dư");
            Console.WriteLine(new string('-', 55));
            foreach (var acc in _bank.GetAllAccounts())
            {
                Console.WriteLine(acc);
            }
        }

        // Đọc số decimal an toàn, tránh lỗi parse hoặc null
        static decimal ReadDecimal()
        {
            string input = Console.ReadLine();
            if (!decimal.TryParse(input, out decimal result))
            {
                throw new FormatException("Giá trị nhập vào không phải là số hợp lệ.");
            }
            return result;
        }
    }
}