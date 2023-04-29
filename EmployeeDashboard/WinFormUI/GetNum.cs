using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI
{
     
    public class GetNum : SubnetForm
                    
    {
        
        public static int GetNetAddress(int incrementNum, int oct1)
        {

            List<int> numList = new List<int>();
            int num;
            for (int i = 0; i <= 255; i++)
            {

                numList.Add(i * incrementNum);
                if (numList.LastOrDefault() >= 255)
                {
                    i = 255;
                }

            }
            for (int i = 0; i < numList.Count - 1; i++)
            {
                if (oct1 == numList[i])
                {
                    num = numList[i];
                    return num;
                }
                if (oct1 > numList[i] && oct1 < numList[i + 1] )
                {
                    num = numList[i];

                    return num;
                }
                 

            }
            return 0;
        }
    }
}
