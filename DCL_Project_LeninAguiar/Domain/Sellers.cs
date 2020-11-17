using DCL_Project_LeninAguiar.Models;
using DCL_Project_LeninAguiar.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DCL_Project_LeninAguiar.Domain
{
    public class Sellers
    {
        public static double GetEndSalary(double fixedsalary,double fixedbysellnumber, List<SellViewModel> cars)
        {
            //Obter salario fixo
            double result = fixedsalary;
            //Obtenho percentagem por venda
            double percent_sell = Double.Parse(ConfigurationManager.AppSettings[GeneralData.PercentValue.PercentSellByValue.ToString()].ToString());
            result += fixedbysellnumber * cars.Count();//somo o salario base com a multiplicacao da comissao fixa por venda
            //agora calculo os 5% em cima de cada venda
            cars.ForEach(car =>
            {
                result += car.price * (percent_sell / 100);
            });
            return result;
        }

    }
}