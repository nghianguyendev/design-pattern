using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chain of Responsibility pattern!");

            var tlApprover = new TeamLeadApprover();
            var pmApprover = new ProjectManagerApprover();
            var dmApprover = new DeliveryManagerApprover();
            var ceoApprover = new CEOManagerApprover();

            tlApprover.SetNextApprover(pmApprover);
            pmApprover.SetNextApprover(dmApprover);
            dmApprover.SetNextApprover(ceoApprover);

            tlApprover.Approve(3);
            tlApprover.Approve(7);
            tlApprover.Approve(10);
            tlApprover.Approve(15);

            tlApprover.Approve(30);

        }
    }
}
