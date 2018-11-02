using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationMvvm.ViewModels
{
    public class MainWindowViewModel
    {
        long n1 = 0, n2 = 0;
        string opr = "";

        public void numaraYaz(long x)
        {
            if (opr == "")
            {
                n1 = n1 * 10 + x;
                Result = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + x;
                Result = n2.ToString();
            }
        }

        public void opsel()
        {
            switch (opr)
            {
                case "+":
                    n1 += n2; n2 = 0; opr="";
                    Result = n1.ToString();
                    break;
                case "-":
                    n1 -= n2; n2 = 0; opr="";
                    Result = n1.ToString();
                    break;
                case "*":
                    n1 *= n2; n2 = 0; opr="";
                    Result = n1.ToString();
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        n1 /= n2; n2 = 0; opr = "";
                        Result = n1.ToString();
                    }
                    else
                    {
                        Result = "error!";
                        n1 = 0; n2 = 0; opr = "";
                    }
                    break;
            }
        }


        public MainWindowViewModel()
        {
            Result = "0";
        }

        public virtual string Result { get; set; }  

        public void Negate()
        {
            if (opr == "")
            {
                n1 = n1 * -1;
                Result = n1.ToString();
            }
            else
            {
                n2 = n2 * -1;
                Result = n2.ToString();
            }
        }

        public void Zeroes()
        {
            if (opr == "")
            {
                n1 = n1 * 100;
                Result = n1.ToString();
            }
            else
            {
                n2 = n2 * 100;
                Result = n2.ToString();
            }
        }

        public void Zero(string content)
        {

            long c = Convert.ToInt64(content);
            numaraYaz(c);
        }

        public void Plus(string content)
        {
            opsel();
            opr = Convert.ToString(content);
        }

        public void Equal()
        {
            opsel();
        }

        public void Back()
        {
            if (opr == "")
            {
                n1 = n1 / 10;
                Result = n1.ToString();
            }
            else
            {
                n2 = n2 / 10;
                Result = n2.ToString();
            }
        }

        public void CE()
        {
            if (opr == "")
            {
                n1 = 0;
                Result = n1.ToString();
            }
            else
            {
                n2 = 0;
                Result = n2.ToString();
            }
        }

        public void C()
        {
            n1 = 0; n2 = 0; opr = "";
            Result = "0";
        }

    }
}
