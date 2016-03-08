using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_oefeningen
{
    class GumballMachine
    {
        readonly static int SOLD_OUT = 0;
        readonly static int NO_QUARTER = 1;
        readonly static int HAS_QUARTER = 2;
        readonly static int SOLD = 3;

        int state = SOLD_OUT;
        int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }
        public void insertQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("You can't insert another quarter.");
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You inserted a quarter.");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't insert another quarter the machine is sold out.");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball.");
            }
        }

        public void ejectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned.");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter.");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank.");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
            }
        }

        public void turnCrank()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned.");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter.");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank.");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
            }
        }
    }
}
