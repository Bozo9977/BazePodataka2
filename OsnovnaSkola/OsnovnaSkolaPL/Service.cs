using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL
{
    public class Service
    {
        private static ServiceHost ZaposleniServiceHost;
        private static ServiceHost UceniciServiceHost;
        private static ServiceHost OdeljenjaServiceHost;
        private static ServiceHost PredmetiServiceHost;
        private static ServiceHost OblastiServiceHost;
        private static ServiceHost PredavanjaServiceHost;
        private static ServiceHost CasoviServiceHost;
        private static ServiceHost KTServiceHost;

        public Service()
        {
            NetTcpBinding binding = new NetTcpBinding();
            binding.Security.Mode = SecurityMode.None;
            //binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;

            binding.MaxReceivedMessageSize = 1000000;
            binding.OpenTimeout = TimeSpan.FromMinutes(2);
            binding.SendTimeout = TimeSpan.FromMinutes(2);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);

            ZaposleniServiceHost = new ServiceHost(typeof(ZaposleniService));
            ZaposleniServiceHost.AddServiceEndpoint(typeof(IZaposleni), binding, new Uri("net.tcp://localhost:11001/IZaposleni"));

            UceniciServiceHost = new ServiceHost(typeof(UceniciService));
            UceniciServiceHost.AddServiceEndpoint(typeof(IUcenici), binding, new Uri("net.tcp://localhost:11001/IUcenici"));

            OdeljenjaServiceHost = new ServiceHost(typeof(OdeljenjaService));
            OdeljenjaServiceHost.AddServiceEndpoint(typeof(IOdeljenja), binding, new Uri("net.tcp://localhost:11001/IOdeljenja"));

            PredmetiServiceHost = new ServiceHost(typeof(PredmetiService));
            PredmetiServiceHost.AddServiceEndpoint(typeof(IPredmeti), binding, new Uri("net.tcp://localhost:11001/IPredmeti"));

            OblastiServiceHost = new ServiceHost(typeof(OblastService));
            OblastiServiceHost.AddServiceEndpoint(typeof(IOblast), binding, new Uri("net.tcp://localhost:11001/IOblast"));

            PredavanjaServiceHost = new ServiceHost(typeof(PredavanjaService));
            PredavanjaServiceHost.AddServiceEndpoint(typeof(IPredavanja), binding, new Uri("net.tcp://localhost:11001/IPredavanja"));

            CasoviServiceHost = new ServiceHost(typeof(CasService));
            CasoviServiceHost.AddServiceEndpoint(typeof(ICasovi), binding, new Uri("net.tcp://localhost:11001/ICasovi"));

            KTServiceHost = new ServiceHost(typeof(KontrolneTackeService));
            KTServiceHost.AddServiceEndpoint(typeof(IKontrolneTacke), binding, new Uri("net.tcp://localhost:11001/IKontrolneTacke"));
        }

        public void Open()
        {
            ZaposleniServiceHost.Open();
            UceniciServiceHost.Open();
            OdeljenjaServiceHost.Open();
            PredmetiServiceHost.Open();
            OblastiServiceHost.Open();
            PredavanjaServiceHost.Open();
            CasoviServiceHost.Open();
            KTServiceHost.Open();
            Console.WriteLine("Service hosts open at: " + DateTime.Now);
        }

        public void Close()
        {
            ZaposleniServiceHost.Close();
            UceniciServiceHost.Close();
            OdeljenjaServiceHost.Close();
            PredmetiServiceHost.Close();
            OblastiServiceHost.Close();
            PredavanjaServiceHost.Close();
            CasoviServiceHost.Close();
            KTServiceHost.Close();
            Console.WriteLine("Service hosts closing at: " + DateTime.Now);
        }
    }
}
