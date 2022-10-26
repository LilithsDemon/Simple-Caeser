//Made by LilithsDemon (Lucy Gardener)

/*
The program must
1. Give the user the option to encrypt, decrypt or exit
2. Encrypt - allow the user to enter the plaintext and the shift and then display the ciphertext
3. Decrypt - allow the user to enter the cipher text and the shift and then display the plaintext
4. Exit - stop the program
5. Use sensible variable/function names, have comments and be formatted correctly

It could also
1. Change the ciphertext so that it removes punctuation and put it in blocks of 5 characters
2. Create a brute force decryption algorithm using the attached list of 1000 most common English words
(or using frequency analysis)

This program is made primarily for a CLI. start_cli uses a command line interface to use this caeser chipher
However you can use all other modules in any case including for guis.
*/

/*
Ascii characters
A-Z = 65-90
a-z = 97-122
Space is 32
I would like this to support both upper and lower case characters
if Z has to go up one it will go to a lower case a instead of an upper case A
*/

using System;
using System.Collections.Generic;
using System.Linq; 

namespace CaesarCipher
{
    class Program
    {
        public static char[] split(string word)
        {
            char[] wordArray = word.ToCharArray();
            return wordArray;
        }

        public static string join(char[] wordArray)
        {
            string word = "";
            for (int charNum=0; charNum < wordArray.Length; charNum++)
            {
                word += wordArray[charNum];
            }
            return word;
        }



        public static string simple_shift(string shiftText, int shiftNum)
        {
            string encryptedText = "";
            for(int charNum = 0; charNum < shiftText.Length; charNum++)
            {
                if (((int)Convert.ToChar(shiftText[charNum]) >= 65) && ((int)Convert.ToChar(shiftText[charNum]) <= 90))
                {
                    //this is a capital
                    int letterValue = ((int)Convert.ToChar(shiftText[charNum]));
                    letterValue -= 64;
                    int newValue = letterValue + shiftNum;

                    int div = (int)newValue / 26;
                    newValue = newValue % 26;

                    if (newValue == 0)
                    {
                        newValue += 90;
                    }
                    else if (div%2 == 0)
                    {
                        newValue += 64;
                    }
                    else
                    {
                        newValue += 96;
                    }

                    encryptedText += ((char)newValue).ToString();
                }
                else if (((int)Convert.ToChar(shiftText[charNum]) >= 97) && ((int)Convert.ToChar(shiftText[charNum]) <= 122))
                {
                    int letterValue = ((int)Convert.ToChar(shiftText[charNum]));
                    letterValue -= 96;
                    int newValue = letterValue + shiftNum;

                    int div = (int)newValue / 26;
                    newValue = newValue % 26;

                    if (newValue == 0)
                    {
                        newValue += 122;
                    }
                    else if (div%2 == 1)
                    {
                        newValue += 64;
                    }
                    else
                    {
                        newValue += 96;
                    }

                    encryptedText += ((char)newValue).ToString();
                }
                else
                {
                    encryptedText += shiftText[charNum];
                }
            
            }
            return encryptedText;
        }



        public static string advanced_shift(string shiftText, int shiftNum)
        {
            string encryptedText = "";
            int charNum = 0; 
            while (charNum != shiftText.Length)
            {
                if((charNum%5) == 0 && (charNum != 0))
                {
                    char[] textArray = split(shiftText);
                    List<char> textList = textArray.ToList();
                    textList.Insert(charNum, Convert.ToChar(" "));
                    shiftText = join(textList.ToArray());
                }

                if (((int)Convert.ToChar(shiftText[charNum]) >= 65) && ((int)Convert.ToChar(shiftText[charNum]) <= 90))
                {
                    //this is a capital
                    int letterValue = ((int)Convert.ToChar(shiftText[charNum]));
                    letterValue -= 64;
                    int newValue = letterValue + shiftNum;

                    int div = (int)newValue / 26;
                    newValue = newValue % 26;

                    if (newValue == 0)
                    {
                        newValue += 90;
                    }
                    else if (div%2 == 0)
                    {
                        newValue += 64;
                    }
                    else
                    {
                        newValue += 96;
                    }

                    encryptedText += ((char)newValue).ToString();
                }
                else if (((int)Convert.ToChar(shiftText[charNum]) >= 97) && ((int)Convert.ToChar(shiftText[charNum]) <= 122))
                {
                    int letterValue = ((int)Convert.ToChar(shiftText[charNum]));
                    letterValue -= 96;
                    int newValue = letterValue + shiftNum;

                    int div = (int)newValue / 26;
                    newValue = newValue % 26;

                    if (newValue == 0)
                    {
                        newValue += 122;
                    }
                    else if (div%2 == 1)
                    {
                        newValue += 64;
                    }
                    else
                    {
                        newValue += 96;
                    }

                    encryptedText += ((char)newValue).ToString();
                }
                else if ((int)Convert.ToChar(shiftText[charNum]) == 32)
                {
                    encryptedText += " ";
                }

                charNum += 1;
            }
            return encryptedText;
        }


        
        public static string simple_decryption(string textToDecrypt, int shiftNum)
        {
            return "test";
        }


        public static string advanced_decryption(string textToDecrypt)
        {
            return "test";
        }

        public static void start_cli()
        {
            int option;
            while(true)
            {
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Encypt");
                Console.WriteLine("2. Decrypt");
                Console.WriteLine("3. Exit");
                try 
                {
                    Console.WriteLine("What would you like to do: ");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter an integer Value!\n");
                    continue;
                }

                if(option == 1)
                {
                    int shift;
                    Console.WriteLine("What would you like to encrypt: ");
                    string plainText = Console.ReadLine();
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("What would you like the shift to be: ");
                            shift = Convert.ToInt32(Console.ReadLine());
                            break;
                        }catch
                        {
                            Console.WriteLine("Please enter an integer number\n");
                            continue;
                        }
                    }
                    int shiftOption = 0;
                    string encryptedText = "";
                    Console.WriteLine("\nPlease pick an option\n");
                    Console.WriteLine("Would you like a\n1.Simple Shift\n2.Advanced shift");
                    while (true) {
                        bool exit = false;
                        try
                        {
                            shiftOption = Convert.ToInt32(Console.ReadLine());
                        }catch
                        {
                            Console.WriteLine("Please enter an integer number\n");
                            continue;
                        }
                        finally
                        {
                            if (shiftOption == 1)
                            {
                                encryptedText = simple_shift(plainText, shift);
                                exit = true;
                            }
                            else if (shiftOption == 2)
                            {
                                encryptedText = advanced_shift(plainText, shift);
                                exit = true;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter a number between 1 and 2\n");
                            }
                        }
                        if (exit == true) break;
                    }
                    Console.WriteLine(encryptedText);
                }
                else if (option == 2)
                {
                    int decryptionOption = 0;
                    string decryptedText = "";
                    Console.WriteLine("What woud you like to decrypt: ");
                    string plainText = Console.ReadLine();
                    while(true)
                    {
                        bool exit = false;
                        try
                        {
                            Console.WriteLine("\nPlease pick an option\n");
                            Console.WriteLine("Would you like a\n1. Set shift decryption\n2. Automatic shift");
                            decryptionOption = Convert.ToInt32(Console.ReadLine());

                            int shiftNum = 0;
                            if (decryptionOption == 1)
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("What would you like to shift this by to decrypt it: ");
                                        shiftNum = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nPlease enter an integer number!\n");
                                        continue;
                                    }
                                }
                                decryptedText = simple_decryption(plainText, shiftNum);
                                break;
                            }
                            else if (decryptionOption == 2)
                            {
                                decryptedText = advanced_decryption(plainText);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter a number between 1 and 2\n");
                                continue;
                            }
                        }
                        catch
                        {
                            
                            Console.WriteLine("\nPlease enter an integer number!\n");
                            continue;
                        }
                        
                        
                    }
                    Console.WriteLine(decryptedText);
                }
                else if (option == 3)
                {
                    Console.WriteLine("Closed program");
                }
                else
                {
                    Console.WriteLine("Please enter a value between 1 and 3\n");
                }
            }
        
        }

        static void Main()
        {
            start_cli();
        }
    }
}
