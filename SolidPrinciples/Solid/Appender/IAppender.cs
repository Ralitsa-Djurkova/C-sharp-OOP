
namespace Solid.Appender
{
    public interface IAppender
    {
        void Append(string data, ReportLevel reportLevel, string message);
        void Append(string date, ReportLevel reportLevel, string message);
    }
}
