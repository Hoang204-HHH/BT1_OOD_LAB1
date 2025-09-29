using System;

namespace HuynhHuuHoang_1150080095_Lab1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Gọi bài 1
            Bai1.Run();
            Bai2.Run();
            Bai3.Run();
            Bai4.Run();
            Bai5.Run();
            Bai6.Run();
            Bai7.Run();
            Bai8.Run();
            Bai9.Run();
            Bai10.Run();
        }
    }
    internal class Bai1
    {
        public static void Run()
        {
            Console.Write("Nhập chiều dài a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập chiều rộng b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double P = (a + b) * 2;
            double S = a * b;

            Console.WriteLine("Chu vi = " + P);
            Console.WriteLine("Diện tích = " + S);
        }
    }

    //// BÀI 2 ////////


    internal class Bai2
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine("Số lớn hơn trong 2 số là: " + max);
        }
    }


    ///// BÀI 3 ////////////


    internal class Bai3
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số nguyên c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a; // giả sử a lớn nhất ban đầu

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("Số lớn nhất trong 3 số là: " + max);
        }
    }

    //////// BÀI 4 ////////////

    internal class Bai4
    {
        public static void Run()
        {
            Console.Write("Nhập năm: ");
            int nam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int thang = Convert.ToInt32(Console.ReadLine());

            int soNgay;

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgay = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = 30;
                    break;

                case 2:
                    if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                        soNgay = 29;
                    else
                        soNgay = 28;
                    break;

                default:
                    soNgay = 0;
                    break;
            }

            if (soNgay == 0)
            {
                Console.WriteLine("Tháng không hợp lệ!");
            }
            else
            {
                Console.WriteLine($"Tháng {thang} năm {nam} có {soNgay} ngày.");
            }
        }
    }


    //////// BÀI 5 ////////////

    internal class Bai5
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra chẵn/lẻ
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ");
            }

            // Kiểm tra âm / không âm
            if (n < 0)
            {
                Console.WriteLine($"{n} là số âm");
            }
            else
            {
                Console.WriteLine($"{n} là số không âm");
            }
        }
    }

    ///////// BÀI 6 ////////////

    internal class Bai6
    {
        public static void Run()
        {
            Console.Write("Nhập chiều dài (số thực dương): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập chiều rộng (số thực dương): ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                double P = (a + b) * 2;
                double S = a * b;

                Console.WriteLine($"Chu vi = {P}");
                Console.WriteLine($"Diện tích = {S}");
            }
            else
            {
                Console.WriteLine("Chiều dài và chiều rộng phải là số thực dương!");
            }
        }
    }

    /////// BÀI 7 ////////////
    internal class Bai7
    {
        public static void Run()
        {
            Console.Write("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Kiểm tra điều kiện tam giác
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                double P = a + b + c;            // Chu vi
                double p = P / 2;               // Nửa chu vi
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Công thức Heron

                Console.WriteLine($"Chu vi tam giác = {P}");
                Console.WriteLine($"Diện tích tam giác = {S}");
            }
            else
            {
                Console.WriteLine("Ba cạnh nhập vào không lập thành tam giác!");
            }
        }
    }

    ///////// BÀI 8 ////////////

    internal class Bai8
    {
        public static void Run()
        {
            Console.Write("Nhập hệ số a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                // Trường hợp phương trình bậc 1: bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phương trình có nghiệm duy nhất: x = {x}");
                }
            }
            else
            {
                // Phương trình bậc 2
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
            }
        }
    }

    ///////// BÀI 9 ////////////

    internal class Bai9
    {
        public static void Run()
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            // Nhập mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử arr[{i}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Tính tổng
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
            }

            Console.WriteLine("Tổng các phần tử trong mảng = " + tong);
        }
    }

    ///////// BÀI 10 ////////////

    internal class Bai10
    {
        public static void Run()
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            // Nhập mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử arr[{i}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sắp xếp chọn (Selection Sort)
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Hoán đổi
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            // Xuất mảng sau khi sắp xếp
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}







