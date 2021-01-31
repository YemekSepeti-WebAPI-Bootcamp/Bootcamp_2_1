

namespace Abstract_Interface.Interface.Sample3.Interface
{
    public interface ILog : IReadLog, IWriteLog
    {
    }

    public interface IReadLog
    {
        void ReadLog();
    }

    public interface IWriteLog
    {
        void WriteLog();
        void WriteErrorLog();
    }
}
