
using Solid.Layout;

namespace Solid.Appender
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }
        public abstract void Append(string data, ReportLevel reportLevel, string message);
        
        
    }
}
