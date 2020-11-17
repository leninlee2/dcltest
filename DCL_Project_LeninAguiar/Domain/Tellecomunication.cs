using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCL_Project_LeninAguiar.Domain
{
    public class Tellecomunication
    {
        public static double GetPayBill(int duration_seconds)
        {
            double result = 10;//valor minimo em centavos
            if (duration_seconds <= 60)
                return result / 100;//retorno em reais
            else
            {
                double backup = duration_seconds - 60;
                if (backup < 6)
                    backup = 1;
                else
                    backup = (backup / 6) * 1;//obtenho quantas vezes é multiplo de 6, 10 centavos por intervalo
                result += backup;//somo com o valor inicial
                return result / 100;//retorno em reais
            }

        }
    }
}