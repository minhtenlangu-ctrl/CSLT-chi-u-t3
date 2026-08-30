using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

namespace CSLT_chiều_t3.buổi2
{
    /*internal class BAI1
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal chiSoCu = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            decimal chiSoMoi = decimal.Parse(Console.ReadLine());

            if (chiSoMoi < chiSoCu)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }

            decimal soKwh = chiSoMoi - chiSoCu;
            decimal tienDienChuaThue = 0;
            decimal kwhConLai = soKwh;
            decimal bac1 = Math.Min(kwhConLai, 50);
            tienDienChuaThue += bac1 * 1806m;
            kwhConLai -= bac1;

            if (kwhConLai > 0)
            {
                decimal bac2 = Math.Min(kwhConLai, 50);
                tienDienChuaThue += bac2 * 1866m;
                kwhConLai -= bac2;
            }
            if (kwhConLai > 0)
            {
                decimal bac3 = Math.Min(kwhConLai, 100);
                tienDienChuaThue += bac3 * 2167m;
                kwhConLai -= bac3;
            }
            if (kwhConLai > 0)
            {
                decimal bac4 = Math.Min(kwhConLai, 100);
                tienDienChuaThue += bac4 * 2729m;
                kwhConLai -= bac4;
            }
            if (kwhConLai > 0)
            {
                tienDienChuaThue += kwhConLai * 3050m;
            }

            decimal thueVAT = Math.Round(tienDienChuaThue * 0.08m, MidpointRounding.AwayFromZero);
            decimal tongThanhToan = tienDienChuaThue + thueVAT;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Số điện tiêu thụ: {soKwh} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDienChuaThue:#,##0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:#,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongThanhToan:#,##0} VNĐ");
        }
     }*/


    /*internal class BAI2
    {
       static void Main()

       {
           Console.OutputEncoding = System.Text.Encoding.UTF8;

           Console.Write("Chiều cao (m): ");
           double chieuCao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.Write("Cân nặng (kg): ");
           double canNang = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           double bmi = Math.Round(canNang / Math.Pow(chieuCao, 2), 2);

           string phanLoai = "";
           if (bmi < 18.5)
               phanLoai = "Gầy (Thiếu cân)";
           else if (bmi < 23.0)
               phanLoai = "Bình thường (Lý tưởng)";
           else if (bmi < 25.0)
               phanLoai = "Thừa cân (Tiền béo phì)";
           else
               phanLoai = "Béo phì";

           double canNangMin = Math.Round(18.5 * Math.Pow(chieuCao, 2), 2);
           double canNangMax = Math.Round(22.9 * Math.Pow(chieuCao, 2), 2);

           Console.WriteLine("\n--- OUTPUT ---");
           Console.WriteLine($"Chỉ số BMI của bạn: {bmi.ToString("F2",CultureInfo.InvariantCulture)}");
           Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
           Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2} kg đến {canNangMax:F2} kg.");
       }
   }*/

    /* enum CurrencyType
     {
         USD = 1,
         EUR = 2,
         JPY = 3,
         GBP = 4
     }

     internal class BAI3
     {
         static void Main()
         {
             Console.OutputEncoding = System.Text.Encoding.UTF8;

             Console.Write("Nhập số tiền VNĐ: ");
             decimal soTienVnd = decimal.Parse(Console.ReadLine());

             Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
             CurrencyType loaiNgoaiTe = (CurrencyType)int.Parse(Console.ReadLine());

             decimal phiDichVu = soTienVnd * 0.005m;
             decimal tienVndSauPhi = soTienVnd - phiDichVu;

             decimal tyGia = 0m;
             string maTienTe = "";

             switch (loaiNgoaiTe)
             {
                 case CurrencyType.USD:
                     tyGia = 25400m;
                     maTienTe = "USD";
                     break;
                 case CurrencyType.EUR:
                     tyGia = 27200m;
                     maTienTe = "EUR";
                     break;
                 case CurrencyType.JPY:
                     tyGia = 165m;
                     maTienTe = "JPY";
                     break;
                 case CurrencyType.GBP:
                     tyGia = 32100m;
                     maTienTe = "GBP";
                     break;
                 default:
                     Console.WriteLine("Loại ngoại tệ không hợp lệ!");
                     return;
             }

             decimal soTienNgoaiTe = tienVndSauPhi / tyGia;

             Console.WriteLine("\n--- OUTPUT ---");
             Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:#,##0} VNĐ");
             Console.WriteLine($"Số tiền VNĐ tính đổi: {tienVndSauPhi:#,##0} VNĐ");
             Console.WriteLine($"Số tiền {maTienTe} nhận được: {soTienNgoaiTe:N2} {maTienTe}");
         }
     }*/

    /*internal class BAI4
     {
         static void Main()
         {
             Console.OutputEncoding = System.Text.Encoding.UTF8;

             Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
             string input = Console.ReadLine();

             if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))
             {
                 Console.WriteLine("Định dạng ngày sinh không hợp lệ!");
                 return;
             }

             DateTime ngayHienTai = DateTime.Now.Date;

             // Tính tuổi
             int tuoi = ngayHienTai.Year - ngaySinh.Year;
             if (ngayHienTai < ngaySinh.AddYears(tuoi))
             {
                 tuoi--;
             }

             // Tính tổng số ngày đã sống
             int tongSoNgaySong = (int)(ngayHienTai - ngaySinh).TotalDays;

             // Tính ngày sinh nhật tiếp theo
             DateTime sinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
             if (sinhNhatTiepTheo < ngayHienTai)
             {
                 sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
             }

             int soNgayConLai = (int)(sinhNhatTiepTheo - ngayHienTai).TotalDays;

             Console.WriteLine("\n--- OUTPUT ---");
             Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
             Console.WriteLine($"Bạn đã sống tổng cộng: {tongSoNgaySong:#,##0} ngày");
             Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai} ngày nữa");
         }
     }*/

    /*internal class Bai5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int tcCSharp = 4, tcToan = 3, tcTiengAnh = 2;

            Console.Write($"C# ({tcCSharp} TC): ");
            double diemCSharp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Toán ({tcToan} TC): ");
            double diemToan = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Tiếng Anh ({tcTiengAnh} TC): ");
            double diemTiengAnh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int tongTinChi = tcCSharp + tcToan + tcTiengAnh;
            double scoreAvg = ((diemCSharp * tcCSharp) + (diemToan * tcToan) + (diemTiengAnh * tcTiengAnh)) / tongTinChi;

            string diemChu = "";
            double gpa4 = 0.0;
            string xepLoai = "";

            // Quy đổi theo đúng bảng trong đề bài
            if (scoreAvg >= 8.5)
            {
                diemChu = "A";
                gpa4 = 4.0;
                xepLoai = "Xuất sắc / Giỏi";
            }
            else if (scoreAvg >= 7.0)
            {
                diemChu = "B";
                gpa4 = 3.0;
                xepLoai = "Khá";
            }
            else if (scoreAvg >= 5.5)
            {
                diemChu = "C";
                gpa4 = 2.0;
                xepLoai = "Trung bình";
            }
            else if (scoreAvg >= 4.0)
            {
                diemChu = "D";
                gpa4 = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = "F";
                gpa4 = 0.0;
                xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Điểm TB Thang 10: {scoreAvg.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa4.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }
    }*/

    /*internal class Bai6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên thô: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                Console.WriteLine("Họ tên không hợp lệ!");
                return;
            }
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                words[i] = char.ToUpper(word[0]) + word.Substring(1);
            }

            string hoTenChuanHoa = string.Join(" ", words);
            string ho = words[0];
            string ten = words[words.Length - 1];
            string tenDem = words.Length > 2
                ? string.Join(" ", words.Skip(1).Take(words.Length - 2))
                : (words.Length == 2 ? words[0] : "");
            string tenKhongDau = LoaiBoDauTiengViet(ten).ToLower();
            string hoKhongDau = LoaiBoDauTiengViet(ho).ToLower();

            string tenDemKhongDau = "";
            if (words.Length > 2)
            {
                var tenDemWords = words.Skip(1).Take(words.Length - 2).Select(w => LoaiBoDauTiengViet(w).ToLower());
                tenDemKhongDau = string.Join("", tenDemWords);
            }

            string username = $"{tenKhongDau}.{hoKhongDau}{tenDemKhongDau}";
            string email = $"{username}@company.edu.vn";

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Họ tên chuẩn hóa: {hoTenChuanHoa}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {(string.IsNullOrEmpty(tenDem) ? "Không có" : tenDem)} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");
        }
        static string LoaiBoDauTiengViet(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
                    return sb.ToString().Normalize(NormalizationForm.FormC).Replace('đ', 'd').Replace('Đ', 'D');
        }
    }*/

    /*internal class BAI7
    {
    
            static void Main(string[] args)
            {
                // Thiết lập hiển thị tiếng Việt có dấu trong Console
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("--- INPUT ---");

                // 1. Nhập khoảng cách chuyến đi (km - kiểu double)
                Console.Write("Quãng đường (km): ");
                if (!double.TryParse(Console.ReadLine(), out double distance) || distance <= 0)
                {
                    Console.WriteLine("Lỗi: Quãng đường phải là một số dương hợp lệ.");
                    return;
                }

                // 2. Nhập mức tiêu thụ nhiên liệu trung bình (L/100km - kiểu double)
                Console.Write("Mức tiêu hao (L/100km): ");
                if (!double.TryParse(Console.ReadLine(), out double consumption) || consumption <= 0)
                {
                    Console.WriteLine("Lỗi: Mức tiêu thụ nhiên liệu phải là một số dương hợp lệ.");
                    return;
                }

                // 3. Nhập giá xăng hiện tại (VNĐ/Lít - kiểu decimal)
                Console.Write("Giá xăng (VNĐ/Lít): ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal fuelPrice) || fuelPrice <= 0)
                {
                    Console.WriteLine("Lỗi: Giá xăng phải là một số dương hợp lệ.");
                    return;
                }

                // 4. Nhập số lượng người tham gia (người - kiểu int)
                Console.Write("Số người đi: ");
                if (!int.TryParse(Console.ReadLine(), out int peopleCount) || peopleCount <= 0)
                {
                    Console.WriteLine("Lỗi: Số người đi phải là một số nguyên dương.");
                    return;
                }

                // --- TÍNH TOÁN ---

                // Tổng số lít xăng cần dùng
                double totalFuel = (distance / 100.0) * consumption;

                // Tổng chi phí tiền xăng (Ép kiểu totalFuel sang decimal để nhân chính xác)
                decimal totalCost = (decimal)totalFuel * fuelPrice;

                // Chi phí trung bình thực tế cho 1 người
                decimal rawCostPerPerson = totalCost / peopleCount;

                // Làm tròn LÊN hàng nghìn gần nhất bằng Math.Ceiling
                // Chia cho 1000 -> làm tròn lên nguyên -> nhân lại 1000
                decimal costPerPersonRounded = (decimal)Math.Ceiling((double)rawCostPerPerson / 1000.0) * 1000m;

                // --- OUTPUT ---
                Console.WriteLine("--- OUTPUT ---");

                // Định dạng 0.00 để hiển thị 2 chữ số thập phân cho nhiên liệu
                Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {totalFuel:0.00} Lít");

                // Định dạng #,##0 để thêm dấu phẩy phân cách hàng nghìn cho số tiền
                Console.WriteLine($"Tổng chi phí xăng dầu: {totalCost:#,##0} VNĐ");
                Console.WriteLine($"Chi phí mỗi người: {costPerPersonRounded:#,##0} VNĐ");

                Console.ReadLine();
            }
    }*/

    /*internal class BAI8
    {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // 1. Hệ thống tạo sẵn mã OTP và thời gian
                string correctOtp = "839201";
                DateTime creationTime = DateTime.Now;

                // 2. Thu thập dữ liệu Input từ người dùng
                Console.WriteLine("--- INPUT ---");
                Console.Write("Mã OTP nhận được: ");
                string inputOtp = Console.ReadLine() ?? "";

                // Giả lập nhập thời gian trôi qua để test nhanh
                Console.Write("Thời gian trôi qua - Phút: ");
                int.TryParse(Console.ReadLine(), out int elapsedMinutes);

                Console.Write("Thời gian trôi qua - Giây: ");
                int.TryParse(Console.ReadLine(), out int elapsedSeconds);

                Console.WriteLine("\n--- OUTPUT ---");

                // Tạo TimeSpan mô phỏng thời gian đã trôi qua
                TimeSpan timePassed = new TimeSpan(0, elapsedMinutes, elapsedSeconds);

                // Giả lập thời điểm người dùng bấm nút "Xác nhận"
                DateTime verificationTime = creationTime.Add(timePassed);

                // 3. Tiến hành kiểm tra 3 điều kiện an toàn

                // Điều kiện 1: Chuỗi nhập vào đúng đủ 6 ký tự và toàn là số
                bool isNumeric = int.TryParse(inputOtp, out _);
                bool isValidFormat = inputOtp.Length == 6 && isNumeric;

                if (!isValidFormat)
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Định dạng không hợp lệ.");
                    return;
                }

                // Điều kiện 3 (kiểm tra trước mã OTP để báo hết hạn nếu đã quá giờ): 
                // Thời điểm xác thực không vượt quá 5 phút (300 giây)
                TimeSpan difference = verificationTime - creationTime;
                if (difference.TotalSeconds > 300)
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Hết hạn OTP.");
                    return;
                }

                // Điều kiện 2: Mã OTP nhập vào khớp hoàn toàn với mã hệ thống
                if (inputOtp != correctOtp)
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Mã sai.");
                    return;
                }

                // Vượt qua toàn bộ bài kiểm tra
                Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
            }
    }*/

    /*internal class BAI9
        {
            static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.Write("Nhập Lương Gross (VNĐ): ");
                decimal gross = decimal.Parse(Console.ReadLine());

                Console.Write("Số người phụ thuộc: ");
                int dependents = int.Parse(Console.ReadLine());

                decimal insurance = gross * 0.105m;

                decimal taxableIncome = gross - insurance - 11000000m - (dependents * 4400000m);
                if (taxableIncome < 0) taxableIncome = 0;

                decimal personalTax = CalculatePIT(taxableIncome);

                decimal netSalary = gross - insurance - personalTax;

                Console.WriteLine("\n--- OUTPUT ---");
                Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {insurance:N0} VNĐ");
                Console.WriteLine($"Thu nhập chịu thuế: {taxableIncome:N0} VNĐ");
                Console.WriteLine($"Thuế TNCN phải nộp: {personalTax:N0} VNĐ");
                Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {netSalary:N0} VNĐ");
            }

            static decimal CalculatePIT(decimal taxableIncome)
            {
                if (taxableIncome <= 0) return 0;

                decimal tax = 0;
                if (taxableIncome > 5000000m)
                {
                    tax += 5000000m * 0.05m;
                    taxableIncome -= 5000000m;
                }
                else return tax + taxableIncome * 0.05m;

                if (taxableIncome > 5000000m)
                {
                    tax += 5000000m * 0.10m;
                    taxableIncome -= 5000000m;
                }
                else return tax + taxableIncome * 0.10m;

                if (taxableIncome > 8000000m)
                {
                    tax += 8000000m * 0.15m;
                    taxableIncome -= 8000000m;
                }
                else return tax + taxableIncome * 0.15m;

                return tax;
            }
        }*/

    /*internal class BAI11
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Số tiền gửi: ");
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.Write("Lãi suất năm (%): ");
            double annualRate = double.Parse(Console.ReadLine());

            Console.Write("Thời gian gửi (tháng): ");
            int months = int.Parse(Console.ReadLine());

            decimal simpleInterest = principal * (decimal)(annualRate / 100) * (months / 12.0m);

            double ratePerMonth = annualRate / 100 / 12;
            double compoundAmountDouble = (double)principal * Math.Pow(1 + ratePerMonth, months);
            decimal compoundInterest = (decimal)compoundAmountDouble - principal;

            decimal difference = compoundInterest - simpleInterest;


            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {simpleInterest:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {compoundInterest:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {difference:N0} VNĐ (Lãi kép tối ưu hơn)");
        }
    }*/


}

