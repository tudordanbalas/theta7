﻿using Persistence;
using Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class StartServer
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                while (true)
                {
                    using (var context = new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()))
                    {
                        //context.automaticJob();
                    }
                    Thread.Sleep(1000*60*60*24);
                }
            }).Start();

            Persistence.Repository.RepoAvailableRoomDB repoAR = new Persistence.Repository.RepoAvailableRoomDB(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoConference repoC = new Persistence.Repository.RepoConference(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoMessageDB repoM = new Persistence.Repository.RepoMessageDB(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoPaperDB repoPap = new Persistence.Repository.RepoPaperDB(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoParticipantDB repoPar = new Persistence.Repository.RepoParticipantDB(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoPayment repoPay = new Persistence.Repository.RepoPayment(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoUserDB repoU = new Persistence.Repository.RepoUserDB(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));
            Persistence.Repository.RepoSessionDB repoS = new Persistence.Repository.RepoSessionDB(new ISSEntities2(Persistence.Util.ConnectionStringWithPassword.doIt()));

            BinaryServerFormatterSinkProvider servProv = new BinaryServerFormatterSinkProvider();
            servProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 11111;
            TcpChannel channel = new TcpChannel(props, clientProv, servProv);
            ChannelServices.RegisterChannel(channel, false);

            var server = new ServerImplementation(repoU, repoAR, repoC, repoM, repoPap, repoPar, repoPay, repoS);

            RemotingServices.Marshal(server, "Conferences");

            Console.WriteLine("Server go");
            Console.ReadLine();
        }
    }
}
