using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    public class ComputeCheckDigit
    {
        public static int computeCheckStringDigit(string identificationNumber)
        {
            int sommePositionPaires = 0;
            int sommePositionInpaires =0;
            int resultat =0;
            //List<int> listIdentificationNumber = new List<int>();

            //for (int i = 0; i < identificationNumber.Length; i++)
            //{
            //    listIdentificationNumber.Add(identificationNumber[i]);
            //}
            for (int i = 0; i < identificationNumber.Length; i++)
            {
                if ((i % 2) == 0)
                    sommePositionPaires += int.Parse(identificationNumber[i].ToString());
                else
                    sommePositionInpaires += int.Parse(identificationNumber[i].ToString());
            }


            resultat= sommePositionPaires * 3 + sommePositionInpaires;

            string resultatstr = resultat.ToString();

            if (!resultatstr.EndsWith('0'))
                resultat = 10 - int.Parse(resultatstr.Substring(resultatstr.Length-1));

            return resultat;
        }
    }
}
