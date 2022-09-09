using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Xml;


namespace Configurator
{
    internal class PC
    {
        public string ? CPU { get; set; }
        public string ? MB { get; set; }
        public string ? RAM { get; set; }
        public string ? GPU { get; set; }
        public string ? HD { get; set; }
        public string ? PSU { get; set; }
        public string ? Body { get; set; }

        public PC(string? cpu, string? mb, string? ram, string ? gpu, string ? hd, string ? psu, string ? body)
        {
            this.CPU = cpu;
            this.MB = mb;
            this.RAM = ram;
            this.GPU = gpu;
            this.HD = hd;
            this.PSU = psu;
            this.Body = body;
        }

        public void CreatePC()
        {

        }

        public void PCs()
        {
            WriteLine($"CPU: {CPU}\n MB: {MB}\n RAM: {RAM}\n GPU: {GPU}\n HD: {HD}\n PSU: {PSU}\n Body: {Body}\n");

        }

        public void Components()
        {
           string line;
           try
           {
               StreamReader sr = new StreamReader("/Users/artemmlnchk/Desktop/component.txt");
               line = sr.ReadLine();
               while (line != null)
               {
                   Console.WriteLine(line);
                   line = sr.ReadLine();
               }
               sr.Close();
               Console.ReadLine();
           }
           catch (Exception e)
           {
               Console.WriteLine("Exception: " + e.Message);
           }

            
        }

        public void Order()
        {

        }

        public void PrintInfo()
        {
        }
    }
}
