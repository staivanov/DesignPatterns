namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
          => _mediator = mediator;

        public virtual void Send(string message)
          => _mediator.Send(message, this);

        public abstract void HandleNotification(string message);
    }
}