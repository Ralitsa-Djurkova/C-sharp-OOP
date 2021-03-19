
namespace Solid.Loggers
{
    public interface ILogger
    {
        void Info(string date, string message);
        void Error(string date, string message);
    }
}
