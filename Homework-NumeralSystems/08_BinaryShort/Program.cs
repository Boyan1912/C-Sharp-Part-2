using System;
using System.Text;

class BinaryShort
    {
        // Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
        static void Main()
        {
            Console.WriteLine("Please enter a 16-bit signed integer number: ");
            string number = Console.ReadLine();
            
            if (number[0] != '-')
            {
                string result = PositiveToBinary(number);
                Console.WriteLine("The binary representation of {0} is {1}", number, result.PadLeft(16, '0'));
            }
            else
            {
                short negative = short.Parse(number);
                negative *= -1;
                string negativeInput = PositiveToBinary(negative.ToString());
                string result = NegativeToBinary(negativeInput);
                Console.WriteLine("The binary representation of {0} is {1}", number, result);
            }

        }
    
    static string PositiveToBinary (string input)
        {
            short number = short.Parse(input);
            var binaryNumber = new StringBuilder();
            while (number > 0)
            {
                int remainder = number % 2;
                binaryNumber.Insert(0, remainder);
                number /= 2;
            }
            return binaryNumber.ToString();
        }

    static string NegativeToBinary (string input)
       {
           int index = 16;                                  // Правя чар масив от 16 елемента колкото бита има short и започвам да го попълвам
           char[] arr = new char[index];
           
           for (int i = input.Length - 1; i >= 0; i--)
			{
                if (input[i] == '0')                        // първо вкарвам най-отзад на масива числото като положително обърнато в двоична чрез предишния метод
                {                                           // вкарвам го наопаки - еквивалентно на побитово ~ 
                    arr[index - 1] = '1';
                }
		        else if (input[i] == '1')
                {
                    arr[index - 1] = '0';
                }
                index--;
           }

            index = Array.LastIndexOf(arr, '0');            // ако се използва побитово преобръщане в отрицателно число трябва след като се обърне с ~ , да се събере с 1
            if (index >= 0)                                 // това се случва тука : ако последният бит е 1 , събрано с 1 ще стане 0, предпоследния отново и т.н. докато не стигнем 0 - тя става на 1
            {                                                  // ako няма 0  Array.LastIndexOf(arr, '0') ще върне -1.
                arr[index] = '1';                        
            }                                            
                     
            if (index < arr.Length - 1 && index >= 0)                     
            {
                for (int i = index + 1; i < arr.Length; i++)
                {                                           // битовете след променената 0 също се променят - от 1 на 0, както пише отгоре
                    arr[i] = '0';
                }
            }

            index = arr.Length - input.Length;              // запълвам всичко отпред с единици
            for (int i = 0; i < index; i++)
            {
                arr[i] = '1';
            }

            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;

       }
}

