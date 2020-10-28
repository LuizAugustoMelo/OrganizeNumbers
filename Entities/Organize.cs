using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Organize
    {
        public int Number { get; protected set; }

        public Organize(int number)
        {
            if (number <= 0)
            {
                throw new OrganizeExceptions("O numero digitado deve ser maior que zero.");
            }
            Number = number;
        }

        public string MinorNumber()
        {
            string numReturn = "";
            int index = -1, lowestValue = -1;
            List<char> charNumber = new List<char>();
            List<int> tempNum = new List<int>();

            for (int i = 0; i < Number.ToString().Length; i++)
            {
                charNumber.Add(char.Parse(Number.ToString().Substring(i, 1)));
            }

            while(charNumber.Count > 0)
            {
                for (int i = 0; i < charNumber.Count; i++)
                {
                    int value = int.Parse(charNumber[i].ToString());

                    if (i == 0)
                    {
                        lowestValue = value;
                        index = i;
                    }
                    else if (value < lowestValue)
                    {
                        index = i;
                        lowestValue = value;
                    }
                }

                tempNum.Add(lowestValue);
                charNumber.RemoveAt(index);
            }

            for (int i = 0; i < tempNum.Count; i++)
            {
                numReturn += tempNum[i].ToString();
            }

            return numReturn;
        }

        public string MajorNumber()
        {
            string numReturn = "";
            int index = -1, highestValue = -1;
            List<char> charNumber = new List<char>();
            List<int> tempNum = new List<int>();

            for (int i = 0; i < Number.ToString().Length; i++)
            {
                charNumber.Add(char.Parse(Number.ToString().Substring(i, 1)));
            }

            while (charNumber.Count > 0)
            {
                for (int i = 0; i < charNumber.Count; i++)
                {
                    int value = int.Parse(charNumber[i].ToString());

                    if (i == 0)
                    {
                        highestValue = value;
                        index = i;
                    }
                    else if (value > highestValue)
                    {
                        index = i;
                        highestValue = value;
                    }
                }

                tempNum.Add(highestValue);
                charNumber.RemoveAt(index);
            }

            for (int i = 0; i < tempNum.Count; i++)
            {
                numReturn += tempNum[i].ToString();
            }

            return numReturn;
        }
    }
}
