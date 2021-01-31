using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Sample1
{
    public abstract class BaseNoteBook
    {

        public BaseNoteBook()
        {
            Console.WriteLine("BaseClass syas ; Hello , I'm Base");
        }
    }

    public class MacBook : BaseNoteBook
    {

        public MacBook()
        {
            Console.WriteLine("Drived Class says ; Hi, I'm Mac Drived");

        }
    }

    public class MicrosoftBook : BaseNoteBook
    {

        public MicrosoftBook()
        {
            Console.WriteLine("Drived Class says ; Hi, I'm Microsoft Drived");

        }
    }


}
