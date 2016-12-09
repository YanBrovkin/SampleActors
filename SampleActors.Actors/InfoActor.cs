using Akka.Actor;
using System;

namespace SampleActors.Actors
{
    public class InfoActor: ReceiveActor
    {
        public class Info
        {
            public Info(string from)
            {
                Informer = from;
            }
            public string Informer { get; }
        }

        public InfoActor()
        {
            //Receive<Info>(info => Sender.Tell("Hello " + info.Informer, Self));
            Receive<Info>(info => Console.WriteLine("Hello {0}", info.Informer));
        }
    }
}
