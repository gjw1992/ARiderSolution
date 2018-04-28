﻿using System;
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

            //tack on a tuple
            (int idx, string descr, double amount) aNamedTuple = (12, "Well, easier when you know how", 234.12);

            System.Console.WriteLine($"tuple v1={aNamedTuple.idx} v2={aNamedTuple.descr} v3={aNamedTuple.amount}");
            var aCopy = aNamedTuple;
            aCopy.amount = 2 * aCopy.amount;
            System.Console.WriteLine($"tuple orig v3={aNamedTuple.amount}  copy v3={aCopy.amount}");

        }

        //public static var TupleX(var inP)
        //{
        //    return inP.amount * 10;
        //}
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

        public bool Monica => monica;

        private readonly bool monica = true; // Added on github and added again
    }
}

