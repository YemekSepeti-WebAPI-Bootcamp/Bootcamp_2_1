using Abstract_Interface.Abstract.Sample1;
using Abstract_Interface.Abstract.Sample2;
using Abstract_Interface.Abstract.Sample3;
using Abstract_Interface.Abstract.Sample3.Abstract;
using Abstract_Interface.Abstract.Sample3.Factory;
using Abstract_Interface.Interface.Sample3.Factory;
using Abstract_Interface.Interface.Sample3.Interface;
using System;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Sample1

            BaseNoteBook macBook = new MacBook();

            BaseNoteBook micsoroftBook = new MicrosoftBook();


            #endregion Sample1

            Console.Clear();

            #region Sample2

            BasePhone android = new Android();
            BasePhone iphone = new IPhone();


            #endregion Sample2

            Console.Clear();

            #region Sample3

            //LogBase sqlLog1 = new SqlLog();
            //sqlLog1.WriteLog();

            var logType = LogType.Sql; // Configden okundu..


            LoggerFactory factory = new LoggerFactory();
            var logInstance = factory.CreateLogger(logType);


            logInstance.WriteLog();

            #endregion  Sample3


            #region Interface

            ICreateLoggerFactory lFactory = new CreateLoggerFactory(LogType.Sql);
            ILog logItem =  lFactory.CreateLogger();

            logItem.ReadLog();
            logItem.WriteErrorLog();


            #endregion Interface

            Console.ReadLine();
        }
    }
}