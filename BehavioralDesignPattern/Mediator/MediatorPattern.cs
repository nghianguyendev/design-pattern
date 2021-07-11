namespace MediatorPattern
{
    internal interface IDevTeam
    {
        string AskQuestion(string question);
    }

    internal interface ICustomer
    {
        string AnswerQuestion(string question);
    }

    internal class DevTeam : IDevTeam
    {
        private readonly IMediator _mediator;

        public DevTeam(IMediator mediator)
        {
            _mediator = mediator;
        }

        public string AskQuestion(string question)
        {
            var answer = _mediator.RequestAnswerFromClient(question);
            return answer;
        }
    }

    internal class Customer : ICustomer
    {
        public string AnswerQuestion(string question)
        {
            return "An answer";
        }
    }

    internal interface IMediator
    {
        string RequestAnswerFromClient(string question);

    }

    internal class SampleMediator : IMediator
    {
        public ICustomer Customer;

        public string RequestAnswerFromClient(string question)
        {
            return Customer.AnswerQuestion(question);
        }
    }
}