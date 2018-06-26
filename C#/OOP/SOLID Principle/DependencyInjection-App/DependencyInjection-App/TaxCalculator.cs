using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_App
{
    class TaxCalculator
    {
        ILog log;
        public TaxCalculator(ILog log)
        {
            this.log = log;
        }


        public int calculate(int salary, int r)
        {
            int c = 0;
            try
            {
                c = salary / r;

            }
            catch (Exception e)
            {
                log.Log(e.Message);
                //throw e;
            }
            return c;
        }
    }
}
