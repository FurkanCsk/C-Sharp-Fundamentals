Console.WriteLine("Çok Amaçlı Programa Hoş Geldiniz!");
bool isValidChoise = false;
int choosen = 1;

while (!isValidChoise)
{
    Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu\n2 - Hesap Makinesi\n3 - Ortalama Hesaplama\n Hangi programı çalıştırmak istiyorsunuz ? (1 / 2 / 3)");
    string input = Console.ReadLine();

    if (int.TryParse(input, out choosen) && choosen >= 1 && choosen <= 3)
    {
        isValidChoise = true;
    }
    else
        Console.WriteLine("Geçersiz bir giriş denediniz. Lütfen tekrar deneyiniz. (1 / 2 / 3)");
}

switch (choosen)
{
    case 1:
        {
            RandomNumGuessGame(); // Calls the method that includes the random number guessing game.
            break;
        }

    case 2:
        {
            CalcProgram();    // Calls the method that includes the Calculator Program
            break;

        }

    case 3:
        {
            AverageCalcProgram(); // Calls the method that includes the Average Calculator Program.
            break;
        }

    default:
        Console.WriteLine("Geçersiz seçim. Lütfen 1, 2 veya 3 seçin.");
        break;
}


static void RandomNumGuessGame()
{
    Random rnd = new Random();
    int rndNum = rnd.Next(1, 101); // Generates a random number between 1 and 100.
    int count = 5;  // The number of guesses the user has.
    Console.WriteLine("Rastgele Sayı Bulma Oyununu Seçtiniz.\nBilgisayar rastgele bir sayı seçti tahmin etme zamanı!\nSeçilen sayı 1 ile 100 arasındadır.");

    while (count > 0)   // The user have 5 chance to guess the number. "Count" variable check this situation.
    {
        Console.WriteLine("Tahmininizi girin: ");
        string guess = Console.ReadLine();

        if (int.TryParse(guess, out int number))   // Checks if the input is a number.
        {

            if (number == rndNum)
            {
                Console.WriteLine("BRAVO! Sayıyı buldunuz.");   // Congrats! Correct guess
                break;
            }
            else if (number > rndNum)
            {
                count--;
                Console.WriteLine($"Girdiğiniz sayı daha büyük. Daha düşük bir sayı denemelisin\nKalan tahmin hakkınız : {count}");  // Guess is too high
            }
            else
            {
                count--;
                Console.WriteLine($"Girdiğiniz sayı daha küçük. Daha yüksek bir sayı denemelisin.\nKalan tahmin hakkınız : {count}"); // Guess is too low
            }

        }
        else
        {
            Console.WriteLine("Yanlış bir giriş yaptınız.");
        }

        if (count == 0) // Displays this message when the user runs out of guesses.
        {
            Console.WriteLine($"Başka tahmin hakkınız kalmadı ve elendiniz.\nDoğru sayı : {rndNum}");
        }
    }
}

static void CalcProgram()  // Defines the input and operation for the Calculator Program
{

    Console.WriteLine("Lütfen birinci sayıyı giriniz");
    double num1;

    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyiniz.");
    }

    Console.WriteLine("Lütfen ikinci sayıyı giriniz");
    double num2;

    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyiniz.");
    }

    Console.WriteLine("Lütfen yapmak istediğiniz işlemin sembolünü giriniz.\nToplama İşlemi (+)\nÇıkarma İşlemi (-)\nÇarpma İşlemi(*)\nBölme İşlemi(/)");
    string symbol = Console.ReadLine();

    double result = Calc(num1, num2, symbol);
    if (!double.IsNaN(result))
    {
        Console.WriteLine($"Yapmak istediğiniz işlemin sonucu : {result}");
    }

}


static double Calc(double num1, double num2, string symbol) // Defines the operations of the calculator
{
    switch (symbol)
    {
        case "+":
            return num1 + num2; // Addition
        case "-":
            return num1 - num2; // Subtraction
        case "*":
            return num1 * num2; // Multiplication
        case "/":
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Sıfıra bölünemez.");
                    return double.NaN; // Returns NaN if division by zero is attempted.
                }
                return num1 / num2; // Division
            }

        default:
            Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen yapmak istediğiniz işlemin sembolünü giriniz.");
            return double.NaN; // Returns NaN for invalid operation symbols.
    }
}


static void AverageCalcProgram() // Defines the input and operations for the Average Calculator Program.
{
    Console.WriteLine("Lütfen 1.Sınav notunuzu giriniz.");
    double grade1;

    while (!double.TryParse(Console.ReadLine(), out grade1) || grade1 < 0 || grade1 > 100)
    {
        Console.WriteLine("Geçersiz bir not girdiniz. Lütfen 0 ile 100 arasında bir değer giriniz.");  // Ensures the grade is between 0 and 100.
    }

    Console.WriteLine("Lütfen 2.Sınav notunuzu giriniz.");
    double grade2;

    while (!double.TryParse(Console.ReadLine(), out grade2) || grade2 < 0 || grade2 > 100)
    {
        Console.WriteLine("Geçersiz bir not girdiniz. Lütfen 0 ile 100 arasında bir değer giriniz."); 
    }

    Console.WriteLine("Lütfen 3.Sınav notunuzu giriniz.");
    double grade3;

    while (!double.TryParse(Console.ReadLine(), out grade3) || grade3 < 0 || grade3 > 100)
    {
        Console.WriteLine("Geçersiz bir not girdiniz. Lütfen 0 ile 100 arasında bir değer giriniz.");
    }

    double average = AverageCalc(grade1, grade2, grade3);
    Console.WriteLine($"Sınav notlarınızın ortalaması : {average}");

}


static double AverageCalc(double grade1, double grade2, double grade3) // Calculates the average and determines the letter grade.
{
    double average = (grade1 + grade2 + grade3) / 3;

    Console.Write("Ortalama harf notunuz : ");

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
    else
    {
        Console.WriteLine("FF Derece");
    }

    return average;
}
