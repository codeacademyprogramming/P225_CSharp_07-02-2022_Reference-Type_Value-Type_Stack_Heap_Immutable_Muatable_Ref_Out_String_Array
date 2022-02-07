using System;

namespace P225HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home Work - 1
            //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve
            //gonderilmis char deyeri gonderilmis string deyerinde necenci indexde yerlesirse
            //hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir. Misal ucun metodu call
            //ederken "alama" ve 'c' deyerlerini gondersek metod bize -1, "alma" ve 'a'
            //deyerlerini gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib
            //isledeceksiniz.Metodu call ederken gondereceyiniz deyerleri Main metodunda
            //console-dan istifadeci daxil etmelidir.
            //Console.WriteLine("Herfi daxil edin");
            //char c;
            //char.TryParse(Console.ReadLine(), out c);
            //Console.WriteLine("Sozu daxil edin");
            //string temp_word = Console.ReadLine();
            //Console.WriteLine(FindCharIndex(temp_word, c));
            #endregion

            #region Home Work - 2
            //IsPrime metodu - parametr olaraq ineteger value qebul edir.
            //Gonderilims integer deyerin sade olub olmadigini qaytarir.
            //Eded sadedirse true, deyilse false qayitmalidir
            //Console.WriteLine(IsPrime(29));

            #endregion

            #region Home Work - 3
            //CalcAvg metodu - Gondeirlmis imtahanlar qiymeti siyahisina
            //(integer array) esasen hemin qiymetlerin ortalamasini qaytaran
            //metod yazin. Main metodunda bu metodu call edib, burdan qayidan
            //deyere esasen ortalama 60-dan boyukdursa console-da "mezun oldunuz"
            //eks halda "mezun ola bilmediniz" yazisi yazdirin
            //int[] arr = { 32, 5, 98, 6, 22 };
            //double netice = CalcAvg(arr);
            //if(netice>60)
            //{
            //    Console.WriteLine("mezun oldun");
            //}
            //else
            //{
            //    Console.WriteLine("mezun ola bilmedin");
            //}
            #endregion
        }

        #region Home Work - 1
        //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve
        //gonderilmis char deyeri gonderilmis string deyerinde necenci indexde yerlesirse
        //hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir. Misal ucun metodu call
        //ederken "alama" ve 'c' deyerlerini gondersek metod bize -1, "alma" ve 'a'
        //deyerlerini gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib
        //isledeceksiniz.Metodu call ederken gondereceyiniz deyerleri Main metodunda
        //console-dan istifadeci daxil etmelidir.
        static int FindCharIndex(string temp_word ,char c)
        {
            for (int i = 0; i < temp_word.Length; i++)
            {
                if (c == temp_word[i])
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Home Work - 2
        //IsPrime metodu - parametr olaraq ineteger value qebul edir.
        //Gonderilims integer deyerin sade olub olmadigini qaytarir.
        //Eded sadedirse true, deyilse false qayitmalidir
        static bool IsPrime(int a)
        {
            if (a < 2)
            {
                return false;
            }

            int count = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                return true;
            }
            return false;

        }
        #endregion

        #region Home Work - 3
        //CalcAvg metodu - Gondeirlmis imtahanlar qiymeti siyahisina
        //(integer array) esasen hemin qiymetlerin ortalamasini qaytaran
        //metod yazin. Main metodunda bu metodu call edib, burdan qayidan
        //deyere esasen ortalama 60-dan boyukdursa console-da "mezun oldunuz"
        //eks halda "mezun ola bilmediniz" yazisi yazdirin
        static double CalcAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum +=arr[i];
            }
           return  (double)sum / arr.Length;
           
        } 
        #endregion

    }
}
