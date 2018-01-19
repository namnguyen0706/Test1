using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Bai 1: tinh giai thua cua so nhap vao:
                //Factorial();

                //bai2: 
                //CountSum();

                // bai 3
                 stringToUpper();

                // bai 4:
                // SecondLargest();

                //bai 5:
                //QuadraticFunc();

                
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
        }

        // bai1: tinh giai thua cua 1 so
        static void Factorial()
        {
                System.Console.WriteLine("nhap vao so can tinh: ");
                int number = int.Parse(Console.ReadLine());
                int i = 0;
                int result =1;
                for(i = 1; i<=number; i++)
                {
                    result = result *i;
                }
                System.Console.WriteLine("Giai thua la: "+ result);
        }

        //bai 2: dem tong cac chu so cua 1 so:
        static void CountSum()
        {
            System.Console.WriteLine("nhap vao so: ");
            int number = int.Parse(Console.ReadLine());
            int temp;
            int sum = 0;
            while(number >0)
            {
                temp = number%10; // phep chia de lay tung chu so
                sum = sum + temp;
                number = number/10;
            }
            System.Console.WriteLine("Tong cac chu so cua so do la: "+sum);
        }

        // bai 3: Viết hoa chữ cái đầu tiên của các từ trong 1 chuỗi
        static void stringToUpper()
        {
            System.Console.WriteLine("nhap vao chuoi: ");
            string str = Console.ReadLine(); 

            string result = "";
            string[] word = str.Split(' '); // tach chuoi thanh cac tu
            foreach (string item in word)
            {
                if(item.Trim()!="")
                {
                    if(word.Length>1)
                        result =result + item.Substring(0,1).ToUpper() + item.Substring(1).ToLower() +" "; // ky tu dau tien viet hoa, cac ky tu sau viet thuong
                    else
                        result = result + item.ToUpper() + " ";    
                }
            }
            System.Console.WriteLine(result.Trim()); 
        }

        // Bai 4: tim so lon thu 2 trong mang
        static void SecondLargest()
        {
            int[] arrayNum = new int[10];
            int input,i,j,temp;
            System.Console.WriteLine("nhap so phan tu cua mang: ");
            input = int.Parse(Console.ReadLine());
            // nhap phan tu vao trong mang:
            for(i=0;i<input;i++)
            {
                Console.Write("phan tu thu {0}: ",i);
                arrayNum[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<input;i++)
            {
                for(j=i+1; j<input;j++)
                {
                    // sap xep mang giam dan
                    if(arrayNum[j] > arrayNum[i])
                    {
                          temp      = arrayNum[i];
                        arrayNum[i] = arrayNum[j];
                        arrayNum[j] = temp;
                    }
                }
            }
            System.Console.WriteLine("so lon thu 2 cua mang la:"+ arrayNum[1]);
            
        }

        // bai 5: giai phuong trinh bac 2 : ax2 + bx + c
        static void QuadraticFunc()
        {
            System.Console.WriteLine("nhap vao he so a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("nhap vao he so b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("nhap vao he so c: ");
            int c = int.Parse(Console.ReadLine());
            double delta, x1, x2;
            delta = b*b - 4*a*c;
            if(delta == 0)
            {
                System.Console.WriteLine("PT co 1 nghiem duy nhat");
                x1 = -b/(2*a);
                x2 = x1;
                System.Console.WriteLine("nghiem cua PT la: "+ x1);
            }
            else if(delta>0)
            {
                x1 = (-b + Math.Sqrt(delta))/(2*a);
                x2 = (-b - Math.Sqrt(delta))/(2*a);
                System.Console.WriteLine("nghiem thu nhat: "+ x1);
                System.Console.WriteLine("nghiem thu 2: "+x2);
            }else
                System.Console.WriteLine("PT vo nghiem");

        }

        
    }
}
