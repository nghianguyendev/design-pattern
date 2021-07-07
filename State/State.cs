using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Switch
    {
        public State state = new OffState();
        public void On() { state.On(this); }
        public void Off() { state.Off(this); }
    }

    abstract class State
    {
        public virtual void On(Switch sw)
        {
            Console.WriteLine("Light is already on");
        }
        public virtual void Off(Switch sw)
        {
            Console.WriteLine("Light is already off");
        }
    }

    class OnState: State
    {
        public OnState()
        {
            Console.WriteLine("Light turned on");
        }

        public override void Off(Switch sw)
        {
            Console.WriteLine("Turning light off");
            sw.state = new OffState();
        }
    }

    class OffState : State
    {
        public OffState()
        {
            Console.WriteLine("Light turned off");
        }

        public override void On(Switch sw)
        {
            Console.WriteLine("Turning light on");
            sw.state = new OnState();
        }
    }

}
