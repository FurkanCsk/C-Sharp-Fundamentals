Console.WriteLine("Hangi programı çalıştırmak istersiniz ?\n1- Rastgele Sayı Bulma Oyunu\n2- Hesap Makinesi\n3- Ortalama Hesaplama");
int choosen = Convert.ToInt32(Console.ReadLine());

switch (choosen)       // Programın çalıştığı asıl kısım. Metot kullanılarak temiz bir görünüm elde edildi.
{
    case 1:
        {
            RandomNumGuessGame();
            break;
        }

    case 2:
        {
            CalcProgram();
            break;

        }

    case 3:
        {
            AverageCalcProgram();
            break;
        }

    default:
        Console.WriteLine("Geçersiz seçim. Lütfen 1, 2 veya 3 seçin.");
        break;
}


static void RandomNumGuessGame()
{
    Random rnd = new Random();
    int rndnum = rnd.Next(1, 101); // Burada bilgisayardan random 1 - 100 arası bir sayı alıyoruz.
    int count = 5;
    Console.WriteLine("Rastgele Sayı Bulma Oyununu Seçtiniz.\nBilgisayar rastgele bir sayı seçti tahmin etme zamanı!");

    while (count > 0)   // Burada kullanıcının canı 0 olana kadar devam etmesi için döngü koşulu count > 0 yapıldı.
    {
        Console.WriteLine("Tahmininizi girin: ");
        string guess = Console.ReadLine();

        if (int.TryParse(guess, out int number))   // Tahmin girişinin sayı olup olmadığının kontrolü yapıldı.
        {

            if (number == rndnum)
            {
                Console.WriteLine("BRAVO! Sayıyı buldunuz.");
                break;
            }
            else if (number > rndnum)
            {
                count--;
                Console.WriteLine($"Girdiğiniz sayı daha büyük.\nKalan tahmin hakkınız : {count}");
            }
            else
            {
                count--;
                Console.WriteLine($"Girdiğiniz sayı daha küçük.\nKalan tahmin hakkınız : {count}");
            }

        }
        else
        {
            Console.WriteLine("Yanlış bir giriş yaptınız.");
        }

        if (count == 0) // Kullanıcının tahmin için canı kalmadığında ekrana gelecek olan ve doğru sayı çıktısı.
        {
            Console.WriteLine($"Başka tahmin hakkınız kalmadı ve elendiniz.\nDoğru sayı : {rndnum}");
        }
    }
}

static void CalcProgram()  // Hesap makinesi programı için yazılmış method
{

    Console.WriteLine("Lütfen birinci sayıyı giriniz");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Lütfen ikinci sayıyı giriniz");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Lütfen yapmak istediğiniz işlemin sembolünü giriniz.\nToplama İşlemi (+)\nÇıkarma İşlemi (-)\nÇarpma İşlemi(*)\nBölme İşlemi(/)");
    string symbol = Console.ReadLine();

    double result = Calc(num1, num2, symbol);
    Console.WriteLine($"Yapmak istediğiniz işlemin sonucu : {result}");

}


static double Calc(double num1, double num2, string symbol) // Hesap makinesinin işlemleri için yazılmış method
{
    switch (symbol)
    {
        case "+":
            return num1 + num2;
        case "-":
            return num1 - num2;
        case "*":
            return num1 * num2;
        case "/":
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Sıfıra bölünemez.");
                    return double.NaN;
                }
                return num1 / num2;
            }

        default:
            Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen yapmak istediğiniz işlemin sembolünü giriniz.");
            return double.NaN;
    }
}


static void AverageCalcProgram() // Ortalama hesaplama programı
{
    Console.WriteLine("Lütfen 1.Sınav notunuzu giriniz.");
    int grade1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen 2.Sınav notunuzu giriniz.");
    int grade2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen 3.Sınav notunuzu giriniz.");
    int grade3 = Convert.ToInt32(Console.ReadLine());

    double average = AverageCalc(grade1, grade2, grade3);

    Console.WriteLine($"Sınav notlarınızın ortalaması : {average}");
}


static double AverageCalc(int grade1, int grade2, int grade3) // Ortalama hesabının yapıldığı method
{
    double average = (grade1 + grade2 + grade3) / 3;

    Console.Write("Ortalama harf notunuz : ");

    if ((grade1 >= 0 && grade1 <= 100) && (grade2 >= 0 && grade2 <= 100) && (grade3 >= 0 && grade3 <= 100))
    {
        if (average >= 90)
        {
            Console.WriteLine("AA Derece");
        }
        else if (average >= 85 && average <= 89)
        {
            Console.WriteLine("BA Derece");
        }
        else if (average >= 80 && average <= 84)
        {
            Console.WriteLine("BB Derece");
        }
        else if (average >= 75 && average <= 79)
        {
            Console.WriteLine("CB Derece");
        }
        else if (average >= 70 && average <= 74)
        {
            Console.WriteLine("CC Derece");
        }
        else if (average >= 65 && average <= 69)
        {
            Console.WriteLine("DC Derece");
        }
        else if (average >= 60 && average <= 64)
        {
            Console.WriteLine("DD Derece");
        }
        else if (average >= 55 && average <= 59)
        {
            Console.WriteLine("FD Derece");
        }
        else if (average >= 0 && average <= 54)
        {
            Console.WriteLine("FF Derece");
        }
    }
    else
    {
        Console.WriteLine("Girilen notlar 0 - 100 arası olmalıdır. Yanlış giriş yaptınız.");
        return 0;
    }

    return average;
}
