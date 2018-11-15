using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Converter
    {
        double arq_usd, arq_eur, arq_rub, vach_usd, vach_eur, vach_rub;
        public Converter(double arq_usd, double vach_usd, double arq_eur, double vach_eur, double arq_rub, double vach_rub)
        {
            this.arq_usd = arq_usd;
            this.vach_usd = vach_usd;

            this.arq_eur = arq_eur;
            this.vach_eur = vach_eur;

            this.arq_rub = arq_rub;
            this.vach_rub = vach_rub;
        }

        public void ToUsd(double dram)
        {
            Console.WriteLine("dzer mutqagrac dram@ hamarjeq e {0} dollari", dram / vach_usd);
        }
        public void FromUsd(double usd)
        {
            Console.WriteLine("dzer mutqagrac dollar@ hamarjeq e {0} drami", usd * arq_usd);
        }
        public void ToEur(double dram)
        {
            Console.WriteLine("dzer mutqagrac dram@ hamarjeq e {0} evroi", dram / vach_eur);
        }
        public void FromEur(double eur)
        {
            Console.WriteLine("dzer mutqagrac evron hamarjeq e {0} drami", eur * arq_eur);
        }
        public void ToRub(double dram)
        {
            Console.WriteLine("dzer mutqagrac dram@ hamarjeq e {0} rublu", dram / vach_rub);
        }
        public void FromRub(double rub)
        {
            Console.WriteLine("dzer mutqagrac rublin hamarjeq e {0} drami", rub * arq_rub);
        }
    }
}
