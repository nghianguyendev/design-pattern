using System;

namespace ChainOfResponsibility
{
    internal abstract class BaseApprover
    {
        private BaseApprover next;

        public void Approve(int days)
        {
            if (CanApprove(days))
            {
                Console.WriteLine($"Your submit leave has been approved by {this.GetType().Name}!");
            }
            else
            {
                if (next != null)
                {
                    next.Approve(days);
                }
                else
                {
                    Console.WriteLine("Your submit leave can not be approved!");
                }
            }
        }

        protected abstract bool CanApprove(int days);

        public void SetNextApprover(BaseApprover approver)
        {
            next = approver;
        }
    }

    internal class TeamLeadApprover : BaseApprover
    {
        protected override bool CanApprove(int days)
        {
            return days <= 3;
        }
    }

    internal class ProjectManagerApprover : BaseApprover
    {
        protected override bool CanApprove(int days)
        {
            return days <= 7;
        }
    }

    internal class DeliveryManagerApprover : BaseApprover
    {
        protected override bool CanApprove(int days)
        {
            return days <= 10;
        }
    }

    internal class CEOManagerApprover : BaseApprover
    {
        protected override bool CanApprove(int days)
        {
            return days <= 15;
        }
    }
}