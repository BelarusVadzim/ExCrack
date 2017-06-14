using System;
using System.Collections.Generic;
using System.Text;

namespace ExCrack
{
    class Crack
    {
        public string Transform(string inputString)
        {
            string outString = "";
            int[] inputInt = new int[22];
            int[] outputInt = new int[18];
            string[] outputText = new string[18];


            for (int i = 0; i < inputString.Length; i++)
            {
                try
                {
                    inputInt[i] = Convert.ToByte(Convert.ToString(inputString[i]), 16);
                }
                catch
                {
                    Exception exception = new Exception(string.Format(@"Не могу обработать символ № {0}", i+1));
                    throw exception;
                }
            }

            outputInt[0] = Convert.ToByte(Convert.ToString("B"), 16);
            outputInt[1] = Convert.ToByte(Convert.ToString("2"), 16);
            outputInt[2] = Convert.ToByte(Convert.ToString("1"), 16);
            outputInt[3] = inputInt[5] - 6;
            outputInt[4] = Convert.ToByte(Convert.ToString("3"), 16);
            outputInt[5] = Convert.ToByte(Convert.ToString("3"), 16);
            outputInt[6] = inputInt[10] + 5;
            outputInt[7] = inputInt[18] +5;
            outputInt[8] = inputInt[17] +5;
            outputInt[9] = inputInt[14] +5;
            outputInt[10] = inputInt[15] +5;
            outputInt[11] = inputInt[7] +5;
            outputInt[12] = inputInt[8] +5;
            outputInt[13] = inputInt[9] +5;
            outputInt[14] = inputInt[6] - 3;
            outputInt[15] = inputInt[13] - 3;
            outputInt[16] = inputInt[16] - 3;
            outputInt[17] = Convert.ToByte(Convert.ToString("D"), 16);

            for (int i = 0; i < outputText.Length; i++)
            {
                if (outputInt[i] > 15)
                    outputInt[i] = outputInt[i] - 16;
                if (outputInt[i] < 0)
                    outputInt[i] = outputInt[i] + 16;
            }

            for (int i = 0; i < outputInt.Length; i++)
            {
                if (outputInt[i] < 10)
                    outputText[i] = outputInt[i].ToString();
                else
                {
                    switch (outputInt[i])
                    {
                        case 10:
                            outputText[i] = "A";
                            break;
                        case 11:
                            outputText[i] = "B";
                            break;
                        case 12:
                            outputText[i] = "C";
                            break;
                        case 13:
                            outputText[i] = "D";
                            break;
                        case 14:
                            outputText[i] = "E";
                            break;
                        case 15:
                            outputText[i] = "F";
                            break;
                        default:
                            break;
                    }
                }
                    
            }



            foreach (string s in outputText)
            {
                outString = string.Format(@"{0}{1}", outString, s);
            }
            return outString;
        }
    }
}
