using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Interface.Sample1
{

    public class Computer : IComputer
    {
        public void Compile()
        {
            throw new NotImplementedException();
        }
    }

    public class PersonalComputer : IComputer, IPersonalComputer
    {
        public void Compile()
        {
            throw new NotImplementedException();
        }

        public void SayHello()
        {
            Console.WriteLine("Hi");
        }
    }

    public interface IPersonalComputer
    {
        void SayHello();
    }


    public interface IComputer
    {
        void Compile();
    }
}
