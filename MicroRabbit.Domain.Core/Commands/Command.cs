using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestap { get; protected set; }

        protected Command() 
        { 
            Timestap = DateTime.Now;
        }
    }
}
