using System;
using System.IO;
using System.Reflection;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var couldBeAnInt = 94;
            Console.WriteLine($"Hello Gary! {couldBeAnInt}");
            Console.WriteLine($"And show this once more {couldBeAnInt}");
            var oneSomeDataEntity=new SomeDataEntity(23);
            Console.WriteLine(oneSomeDataEntity.Info);
            Console.WriteLine(oneSomeDataEntity.Version);
        }
    }

    class SomeDataEntity
    {

        public SomeDataEntity(int anyCount)
        {
            this.AnyCount = anyCount;
            this.creationDateTime = DateTime.Now;
        }

        private string buildTime()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            FileInfo fi = new FileInfo(asm.Location);
            return $"Created: {fi.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")}, Last build: {fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")}" ;
        }

        private DateTime creationDateTime;
        public int AnyCount { get; }
        public string Info => $"{this.GetType().ToString()} Created: {this.creationDateTime} AnyCount: {this.AnyCount}  {this.buildTime()}";

        public string Version => this.buildTime();

        private readonly bool monica = true;
    }
}

