﻿using OsnovnaSkolaPL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaUI
{
    public class Channel
    {
        public IZaposleni ZaposleniProxy { get; set; }
        public IUcenici UceniciProxy { get; set; }
        public IOdeljenja OdeljenjaProxy { get; set; }

        public IPredmeti PredmetiProxy { get; set; }
        public IOblast OblastiProxy { get; set; }


        private static Channel instance;

        public static Channel Instance
        {
            get
            {
                if (instance == null)
                    instance = new Channel();
                return instance;
            }
        }

        public Channel()
        {
            NetTcpBinding binding = new NetTcpBinding();
            binding.Security.Mode = SecurityMode.None;
            //binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;

            binding.MaxReceivedMessageSize = 1000000;
            binding.OpenTimeout = TimeSpan.FromMinutes(2);
            binding.SendTimeout = TimeSpan.FromMinutes(2);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);

            ChannelFactory<IZaposleni> channelFactoryZaposleni = new ChannelFactory<IZaposleni>(binding, new EndpointAddress("net.tcp://localhost:11001/IZaposleni"));
            ZaposleniProxy = channelFactoryZaposleni.CreateChannel();

            ChannelFactory<IUcenici> channelFactoryUcenici = new ChannelFactory<IUcenici>(binding, new EndpointAddress("net.tcp://localhost:11001/IUcenici"));
            UceniciProxy = channelFactoryUcenici.CreateChannel();

            ChannelFactory<IOdeljenja> channelFactoryOdeljenja = new ChannelFactory<IOdeljenja>(binding, new EndpointAddress("net.tcp://localhost:11001/IOdeljenja"));
            OdeljenjaProxy = channelFactoryOdeljenja.CreateChannel();

            ChannelFactory<IPredmeti> channelFactoryPredmeti = new ChannelFactory<IPredmeti>(binding, new EndpointAddress("net.tcp://localhost:11001/IPredmeti"));
            PredmetiProxy = channelFactoryPredmeti.CreateChannel();

            ChannelFactory<IOblast> channelFactoryOblast = new ChannelFactory<IOblast>(binding, new EndpointAddress("net.tcp://localhost:11001/IOblast"));
            OblastiProxy = channelFactoryOblast.CreateChannel();
        }




    }
}
