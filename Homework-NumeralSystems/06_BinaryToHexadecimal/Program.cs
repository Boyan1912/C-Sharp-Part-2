using System;
using System.Text;


class BinaryToHexadecimal
    {
        static void Main()
        {
            // Write a program to convert binary numbers to hexadecimal numbers (directly).

            string number = Console.ReadLine();
            
            StringBuilder binaryNumber = new StringBuilder();

            for (int i = 1; i < number.Length; i++)
            {
                string partial = "";
                if (((number.Length) - 4 * i >= 0))
                {
                    partial = number.Substring((number.Length) - 4 * i, 4);
                    
                    switch (partial)
                    {
                        case "0000": binaryNumber.Insert(0, '0'); break; //Inserts the string representation of a specified Unicode character into this instance at the specified character position.
                        case "0001": binaryNumber.Insert(0, '1'); break;
                        case "0010": binaryNumber.Insert(0, '2'); break;
                        case "0011": binaryNumber.Insert(0, '3'); break;
                        case "0100": binaryNumber.Insert(0, '4'); break;
                        case "0101": binaryNumber.Insert(0, '5'); break;
                        case "0110": binaryNumber.Insert(0, '6'); break;
                        case "0111": binaryNumber.Insert(0, '7'); break;
                        case "1000": binaryNumber.Insert(0, '8'); break;
                        case "1001": binaryNumber.Insert(0, '9'); break;
                        case "1010": binaryNumber.Insert(0, 'A'); break;
                        case "1011": binaryNumber.Insert(0, 'B'); break;
                        case "1100": binaryNumber.Insert(0, 'C'); break;
                        case "1101": binaryNumber.Insert(0, 'D'); break;
                        case "1110": binaryNumber.Insert(0, 'E'); break;
                        case "1111": binaryNumber.Insert(0, 'F'); break;

                    }
                
                }
                else
                {
                    partial = number.Substring(0, number.Length - 4 * (i - 1)); // В случай, че остават по-малко от 4 символа отпред
                                                                                // number.Length - 4 * (i - 1) ще покаже дължината на оставащия събстринг
                    switch (partial)
                    {
                        case "1": binaryNumber.Insert(0, '1'); break;
                        case "10": binaryNumber.Insert(0, '2'); break;
                        case "11": binaryNumber.Insert(0, '3'); break;
                        case "100": binaryNumber.Insert(0, '4'); break;
                        case "101": binaryNumber.Insert(0, '5'); break;
                        case "110": binaryNumber.Insert(0, '6'); break;
                        case "111": binaryNumber.Insert(0, '7'); break;

                    }

                    break;
                }
                
            }
            Console.WriteLine("The hexadecimal representation of the binary number {0} is {1}", number, binaryNumber.ToString());
        }
    
   

}

