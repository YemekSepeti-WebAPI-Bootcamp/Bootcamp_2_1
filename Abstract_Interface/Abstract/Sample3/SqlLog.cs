using Abstract_Interface.Abstract.Sample3.Abstract;
using System;

namespace Abstract_Interface.Abstract.Sample3
{
    public class SqlLog : LogBase
    {
        public override void ReadLog()
        {
            Console.WriteLine("SQL : Read some Log");
        }

        public override void WriteErrorLog()
        {
            Console.WriteLine("SQL : Write Error  Log");

        }

        public override void WriteLog()
        {
            Console.WriteLine("SQL : Write Info  Log");
        }
    }
}
