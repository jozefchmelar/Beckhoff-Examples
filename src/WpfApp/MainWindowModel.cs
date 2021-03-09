using Plc;
using PlcConnector.Secret;
using System;

namespace WpfApp
{
    public class MainWindowModel
    {
        public MainWindowModel()
        {
            MAIN = Entry.Plc.MAIN;
            Console.WriteLine(Secrets.Instance);
        }

        public MAIN MAIN { get; set; }
    }
}