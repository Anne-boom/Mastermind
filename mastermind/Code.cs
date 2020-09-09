using System;
using System.Collections.Generic;
using System.Text;

namespace mastermind
{
    public class Code
    {

        string[] pinValues = { "a", "b", "c", "d", "e", "f" };
        int[] pinPosition = { 0, 1, 2, 3 };
        public List<Pin> codeList = new List<Pin>();
        

     
public Code()
        {


            foreach (int position in pinPosition) {
                var rand = new Random();
                int randomPlaceValue = rand.Next(6);
                string pinValue = pinValues[randomPlaceValue];
                Pin pinCode = new Pin(pinValue, position);
                codeList.Add(pinCode);
        }
            
    }

        

        
       
        public void PrintCode()
        {
            foreach (Pin pin in codeList)
            {
                Console.WriteLine(pin.Value);
            }
            
        }

    }
}

