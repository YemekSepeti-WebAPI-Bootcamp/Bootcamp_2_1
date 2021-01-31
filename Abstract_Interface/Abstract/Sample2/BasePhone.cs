using System;

namespace Abstract_Interface.Abstract.Sample2
{
    public abstract class BasePhone
    {
        public BasePhone()
        {
            ShowInfo();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("BasePhone");
        }

        public void Test()
        {

        }
    }

    public class IPhone : BasePhone
    {
        public IPhone()
        {
        }

        public override void ShowInfo()
        {
            
            Console.WriteLine("IPhone 12");
        }
    }

    public class Android : BasePhone
    {
        public Android()
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Android Oreo");
        }
    }


}
