using System;
using System.Runtime.InteropServices;

namespace Lab1
{
    public class Musician
    {
        private readonly string instrument;

        public Musician(string instrument)
        {
            this.instrument = instrument;
        }

        public void Play()
        {
            Console.WriteLine("Musician is playing the " + instrument);
        }
    }
}