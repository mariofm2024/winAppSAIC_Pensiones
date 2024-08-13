using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace winAppSAIC.NominaCFDI
{
    public partial class frmxLINQ2XML : DevExpress.XtraEditors.XtraForm
    {
        private string pathXmlRequestFiles;

        public frmxLINQ2XML()
        {
            InitializeComponent();
        }

        public static IPAddress GetIPAddress(string hostName)
        {
            Ping ping = new Ping();
            var replay = ping.Send(hostName);

            if (replay.Status == IPStatus.Success)
            {
                return replay.Address;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pathXmlRequestFiles = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\";

            XDocument xmlDoc = XDocument.Load(pathXmlRequestFiles + @"\NominaCFDI\sites.xml");
            var q = from c in xmlDoc.Descendants("site")


                    select (string)c.Element("name") + " -- " + (string)c.Element("url");

            foreach (string name in q)
            {
                Console.WriteLine("Site: " + name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pathXmlRequestFiles = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\";

            XDocument xmlDoc = XDocument.Load(pathXmlRequestFiles + @"\NominaCFDI\sites.xml");
            var q = from c in xmlDoc.Descendants("site")
                    where c.Attribute("technical").Value == "true"
                    select new
                    {
                        name = c.Element("name").Value,
                        url = c.Element("url").Value
                    };


            foreach (var obj in q)
            {
                Console.WriteLine(String.Format("Site: {0} -- {1}", obj.name, obj.url));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tempString = @"<PipeUnit><Step><Pipelist><NamedPipe><NameOfPipe>12345</NameOfPipe><PipeData>Data</PipeData></NamedPipe></Pipelist></Step></PipeUnit>";

            XDocument xdoc = XDocument.Parse(tempString);
            var lang = from d in xdoc.Elements("PipeUnit").Elements("Step").Elements("Pipelist").Elements("NamedPipe").Elements("NameOfPipe") select d;

            Console.WriteLine(lang.First().Value);

            foreach (var item in lang) 
            {
                Console.WriteLine(item.Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Dns.GetHostName());
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine(addr);
                }
            }

            //Ejemplo 2
            Console.WriteLine("Local IP Address: " + GetIPAddress(Dns.GetHostName()));
            Console.WriteLine("Google IP:" + GetIPAddress("google.com"));
            Console.ReadLine();
        }
    }
}