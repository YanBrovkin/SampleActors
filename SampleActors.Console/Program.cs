using Akka.Actor;
using SampleActors.Actors;
using System;

namespace SampleActors.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("MySystem");

            var informer = system.ActorOf<InfoActor>("informer");

            informer.Tell(new InfoActor.Info("First"));
            informer.Tell(new InfoActor.Info("Next"));

            Console.ReadLine();
        }
    }
}
