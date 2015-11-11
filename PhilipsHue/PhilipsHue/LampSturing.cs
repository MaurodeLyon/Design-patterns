using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PhilipsHue
{
    class LampSturing
    {
        public TcpClient client;
        private List<lamp> lampen;
       
        public LampSturing(TcpClient client)
        {
            this.client = client;
            lampen = new List<lamp>();
            lampen.Add(new lamp(1));
        }

        public void setLightState(string id, string bri, string hue, string sat)
        {
            foreach (lamp lamp in lampen)
            {
                int idt = Convert.ToInt32(id);
                if (lamp.id == idt)
                {
                    lamp.bri = Convert.ToInt32(bri);
                    lamp.hue = Convert.ToInt32(hue);
                    lamp.sat = Convert.ToInt32(sat);
                    Console.WriteLine($"lamp {lamp.id} set to {lamp.bri} brightness, {lamp.hue} hue and {lamp.sat} saturation");
                }
            }

        }

        public void setBrightness(string id, string bri)
        {
            foreach (lamp lamp in lampen)
            {
                int idt = Convert.ToInt32(id);
                if (lamp.id == idt)
                {
                    lamp.bri = Convert.ToInt32(bri);
                    Console.WriteLine($"lamp {lamp.id} set to {lamp.bri} brightness, {lamp.hue} hue and {lamp.sat} saturation");
                }
            }
        }

        public void setHue(string id, string hue)
        {
            foreach (lamp lamp in lampen)
            {
                int idt = Convert.ToInt32(id);
                if (lamp.id == idt)
                {
                    lamp.hue = Convert.ToInt32(hue);
                    Console.WriteLine($"lamp {lamp.id} set to {lamp.bri} brightness, {lamp.hue} hue and {lamp.sat} saturation");
                }
            }
        }

        public void setSaturation(string id, string sat)
        {
            foreach (lamp lamp in lampen)
            {
                int idt = Convert.ToInt32(id);
                if (lamp.id == idt)
                {
                    lamp.sat = Convert.ToInt32(sat);
                    Console.WriteLine($"lamp {lamp.id} set to {lamp.bri} brightness, {lamp.hue} hue and {lamp.sat} saturation");
                }
            }
        }
    }
    class lamp
    {
        public int id;
        public int bri;
        public int hue;
        public int sat;

        public lamp(int id)
        {
            this.id = id;
            bri = 0;
            hue = 0;
            sat = 0;
        }
    }
}
