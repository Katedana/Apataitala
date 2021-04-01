using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apataitala.Modeli
{
    class Class2
    {
        public bool sorting(string[] name_spisok, int[] time_0, int[] time_a, int[] time_b, int[] time_c, int[] time_d, int[] time_e)
        {
            List<Interface1> Spisok_1 = new List<Interface1>();

            int min = 0;
            int n = 0; int n1, n2;
            {
                //public static List<Airport_class> sorting(string[] name_spisok, int[] time_spisok)
                //{
                /*List<Airport_class> Spisok_1 = new List<Airport_class>();
                List<Airport_class> flight = new List<Airport_class>();

                int Week_time = 7*24; int All_time;
                int n = 0;

                bool Airplane()
                {
                    while (All_time> Week_time)
                    {
                        foreach (Airport_class i in Spisok_1)
                        {
                            All_time = All_time + Spisok_1.Time[i];
                        }
                    }
                    return true;
                }*/

                /*
                foreach (int i in time_0)
                {

                    if (!(time_0[i] == 0))
                    {

                    }
                }


                    foreach (int i_a in time_a)
                    {

                        if (!(time_a[i_a] == 0))
                        {

                        }
                    }



                foreach (int i_b in time_b)
                {

                    if (!(time_b[i_b] == 0))
                    {

                    }
                }

                foreach (int i_c in time_c)
                {

                    if (!(time_c[i_c] == 0))
                    {

                    }
                }

                foreach (int i_d in time_d)
                {

                    if (!(time_d[i_d] == 0))
                    {


                    }
                }

                foreach (int i_e in time_e)
                {
                    if (!(time_e[i_e] == 0))
                    {

                    }
                }

                for (int w = 0; w <= 6; w++)
                {




                    min = Math.Max(time_0[n], time_a[n]);

                    if (!(time_0[n] == 0) )
                        if (time_0[n] <= min)
                        {
                            min = time_0[n];
                            n = 0;
                            Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_0[n]) });
                        }
                    if (!(time_a[n] == 0))
                        if (time_a[n] <= min)
                        {
                            min = time_a[n];
                            n = 1;
                            Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_a[n]) });
                        }
                    if (!(time_b[n] == 0))
                        if (time_b[n] <= min)
                        {
                            min = time_b[n];
                            n = 2;
                            Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_b[n]) });
                        }
                    if (!(time_c[n] == 0))
                        if (time_c[n] <= min)
                        {
                            min = time_c[n];
                            n = 3;
                            Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_c[n]) });
                        }
                    if (!(time_d[n] == 0))
                        if (time_d[n] <= min)
                        {
                            min = time_d[n];
                            n = 4;
                            Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_d[n]) });

                        }
                    if (!(time_e[n] == 0))
                        if (time_e[n] <= min)
                        {
                            min = time_e[n];
                            n = 5;
                            Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_e[n]) });
                        }

                }*/
            }

            for (int w = 0; w <= 5; w++)
            {
                n1 = n;
                min = Math.Max(time_0[n], time_a[n]);

                if (!((time_0[n] == 0) | (n1 == 0)))
                    if (time_0[n] <= min)
                    {
                        if (w == 0) n2 = 0;
                        min = time_0[n];
                        n = 0;
                        Spisok_1.Add(item: new Class1() { name = (name_spisok[n]), time = (time_0[n]) });
                    }
                if (!((time_a[n] == 0) | (n1 == 1)))
                    if (time_a[n] <= min)
                    {
                        if (w == 0) n2 = 1;
                        min = time_a[n];
                        n = 1;
                        Spisok_1.Add(item: new Class1() { name = (name_spisok[n]), time = (time_a[n]) });
                    }
                if (!((time_b[n] == 0) | (n1 == 2)))
                    if (time_b[n] <= min)
                    {
                        if (w == 0) n2 = 2;
                        min = time_b[n];
                        n = 2;
                        Spisok_1.Add(item: new Class1() { name = (name_spisok[n]), time = (time_b[n]) });
                    }
                if (!((time_c[n] == 0) | (n1 == 3)))
                    if (time_c[n] <= min)
                    {
                        if (w == 0) n2 = 3;
                        min = time_c[n];
                        n = 3;
                        Spisok_1.Add(item: new Class1() { name = (name_spisok[n]), time = (time_c[n]) });
                    }
                if (!((time_d[n] == 0) | (n1 == 4)))
                    if (time_d[n] <= min)
                    {
                        if (w == 0) n2 = 4;
                        min = time_d[n];
                        n = 4;
                        Spisok_1.Add(item: new Class1() { name = (name_spisok[n]), time = (time_d[n]) });

                    }
                if (!((time_e[n] == 0) | (n1 == 5)))
                    if (time_e[n] <= min)
                    {
                        if (w == 0) n2 = 5;
                        min = time_e[n];
                        n = 5;
                        Spisok_1.Add(item: new Class1() { name = (name_spisok[n]), time = (time_e[n]) });
                    }

            }
            return true;

        }
    }
}

