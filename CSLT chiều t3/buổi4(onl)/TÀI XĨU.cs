using System;
using System.Text;
namespace buổi4onl
{
    /*internal class TÀI_XĨU
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("""
    
    ╔══════════════════════════════════════════════════════════╗
    ║                                                          ║
    ║              🎲  D I C E   G A M E  🎲                  ║
    ║                                                          ║
    ║          TÀI  •  XỈU  •  LỤC  •  MAY MẮN                 ║
    ║                                                          ║
    ╚══════════════════════════════════════════════════════════╝
    """);
            DiceGame();
        }
        public static void DiceGame()
        {
            long tien = 1_000_000;
            int soLanChoi = 0;
            int soLanThang = 0;
            int soLanThua = 0;
            int soLanDacBiet = 0;
            bool continuePlaying = true;
            Random rand = new Random();
            do
            {
                if (tien <= 0)
                {
                    Console.WriteLine("Bạn đã hết tiền. Trò chơi kết thúc!");
                    break;
                }
                soLanChoi++;
                Console.WriteLine($"\nBạn có {tien} đồng.");
                Console.Write("Bạn đặt bao nhiêu? ");
                long tienDatCuoc;
                while (!long.TryParse(Console.ReadLine(), out tienDatCuoc) ||
                       tienDatCuoc <= 1000 ||
                       tienDatCuoc > tien)
                {
                    Console.WriteLine(
                        $"Vui lòng nhập số tiền cược hợp lệ, lớn hơn 1000 và không vượt quá {tien} đồng."
                    );
                    Console.Write("Bạn đặt bao nhiêu? ");
                }
                string guess;
                do
                {
                    Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)? ");
                    guess = Console.ReadLine()?.ToLower();
                    if (guess != "t" && guess != "x" && guess != "l")
                    {
                        Console.WriteLine("Vui lòng nhập T, X hoặc L.");
                    }
                }
                while (guess != "t" && guess != "x" && guess != "l");
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                int sum = dice1 + dice2;
                bool isWin = false;
                bool isSpecial = false;
                if (guess == "t" && sum > 6)
                {
                    isWin = true;
                }
                else if (guess == "x" && sum < 6)
                {
                    isWin = true;
                }
                else if (guess == "l" && sum == 6)
                {
                    isWin = true;
                    isSpecial = true;
                }
                Console.WriteLine($"\nKết quả gieo súc sắc: {dice1} + {dice2} = {sum}");
                if (isWin)
                {
                    soLanThang++;
                    if (isSpecial)
                    {
                        soLanDacBiet++;
                        tien += tienDatCuoc * 3;
                        Console.WriteLine(
                            $"Bạn thắng đặc biệt! Bạn được thưởng {tienDatCuoc * 3} đồng."
                        );
                    }
                    else
                    {
                        tien += tienDatCuoc;
                        Console.WriteLine(
                            $"Bạn thắng! Bạn được thưởng {tienDatCuoc} đồng."
                        );
                    }
                    Console.WriteLine($"Số tiền hiện tại: {tien} đồng.");
                }
                else
                {
                    tien -= tienDatCuoc;
                    soLanThua++;
                    Console.WriteLine("Bạn thua!");
                    Console.WriteLine($"Số tiền hiện tại: {tien} đồng.");
                }
                if (tien <= 0)
                {
                    Console.WriteLine("\nBạn đã hết tiền.");
                    break;
                }
                string input;
                do
                {
                    Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
                    input = Console.ReadLine()?.ToLower();
                    if (input != "c" && input != "k")
                    {
                        Console.WriteLine("Vui lòng nhập C hoặc K.");
                    }
                }
                while (input != "c" && input != "k");
                if (input == "k")
                {
                    continuePlaying = false;
                }
            } while (continuePlaying);
            Console.WriteLine("\nTrò chơi kết thúc!");
            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
            Console.WriteLine($"Tổng số lần thắng: {soLanThang}");
            Console.WriteLine($"Tổng số lần thua: {soLanThua}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {soLanDacBiet}");
            Console.WriteLine($"Số tiền còn lại: {tien} đồng.");
        }
    }
}*/

    /*internal class baitap2
    {
        static void Main()
        {
            Random random = new Random();
            int money = 100000;
            bool play = true;
            Console.WriteLine("=================================");
            Console.WriteLine("       GAME DOAN SO 1 - 100");
            Console.WriteLine("=================================");
            Console.WriteLine("Tien ban dau: " + money + " dong");
            while (play && money > 0)
            {
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("So tien hien tai: " + money + " dong");
                Console.WriteLine("Chon muc do:");
                Console.WriteLine("1. De       - 9 lan doan  - Thuong 1/2 tien cuoc");
                Console.WriteLine("2. Trung binh - 6 lan doan - Thuong 1 lan tien cuoc");
                Console.WriteLine("3. Kho       - 4 lan doan - Thuong 3 lan tien cuoc");
                Console.Write("Lua chon cua ban: ");
                int level;
                while (!int.TryParse(Console.ReadLine(), out level) ||
                       level < 1 || level > 3)
                {
                    Console.Write("Vui long chon 1, 2 hoac 3: ");
                }
                int maxGuess = 0;
                double reward = 0;
                if (level == 1)
                {
                    maxGuess = 9;
                    reward = 0.5;
                }
                else if (level == 2)
                {
                    maxGuess = 6;
                    reward = 1;
                }
                else
                {
                    maxGuess = 4;
                    reward = 3;
                }
                Console.Write("\nNhap tien cuoc: ");
                int bet;
                while (!int.TryParse(Console.ReadLine(), out bet) ||
                       bet <= 0 || bet > money)
                {
                    Console.WriteLine("Tien cuoc khong hop le!");
                    Console.Write("Nhap lai tien cuoc: ");
                }
                money -= bet;
                int secretNumber = random.Next(1, 101);
                bool win = false;
                Console.WriteLine("\nMay da chon mot so tu 1 den 100.");
                Console.WriteLine("Ban co " + maxGuess + " lan doan.");
                for (int i = 1; i <= maxGuess; i++)
                {
                    Console.Write("\nLan doan " + i + "/" + maxGuess + ": ");
                    int guess;
                    while (!int.TryParse(Console.ReadLine(), out guess) ||
                           guess < 1 || guess > 100)
                    {
                        Console.Write("Nhap mot so tu 1 den 100: ");
                    }
                    if (guess == secretNumber)
                    {
                        win = true;
                        int prize = (int)(bet * reward);
                        money += bet + prize;
                        Console.WriteLine("\n*** CHUC MUNG! BAN DA DOAN DUNG! ***");
                        Console.WriteLine("So dung la: " + secretNumber);
                        Console.WriteLine("Tien thuong: " + prize + " dong");
                        Console.WriteLine("Tien hien tai: " + money + " dong");
                        break;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("So can tim LON HON " + guess);
                    }
                    else
                    {
                        Console.WriteLine("So can tim NHO HON " + guess);
                    }
                }
                if (!win)
                {
                    Console.WriteLine("\n*** BAN DA THUA! ***");
                    Console.WriteLine("So dung la: " + secretNumber);
                    Console.WriteLine("Ban mat " + bet + " dong.");
                    Console.WriteLine("Tien con lai: " + money + " dong");
                }
                if (money <= 0)
                {
                    Console.WriteLine("\n=================================");
                    Console.WriteLine("BAN DA HET TIEN!");
                    Console.WriteLine("GAME KET THUC!");
                    Console.WriteLine("=================================");
                    break;
                }
                Console.Write("\nBan co muon choi tiep? (Y/N): ");
                string answer = Console.ReadLine().ToUpper();
                if (answer != "Y")
                {
                    play = false;
                }
            }
        }

    }*/
}