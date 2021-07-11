using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LegacyOldCar
    {
        public string GetName()
        {
            return "Legacy Old Car";
        }

        public double GetCost()
        {
            return 1000;
        }
    }

    // Adding new functionality to LegacyOldCar

    public interface ICar
    {
        string GetName();
        double GetCost();
    }
    public class LegacyOldCarDecorator : ICar
    {
        private LegacyOldCar _legacyOldCar;

        public LegacyOldCarDecorator(LegacyOldCar legacyOldCar)
        {
            this._legacyOldCar = legacyOldCar;
        }

        public virtual double GetCost()
        {
            return _legacyOldCar.GetCost();
        }

        public virtual string GetName()
        {
            return _legacyOldCar.GetName();
        }
    }

    public class LegacyOldCarWithNewIndicator : LegacyOldCarDecorator
    {
        public LegacyOldCarWithNewIndicator(LegacyOldCar legacyOldCar) : base(legacyOldCar)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 100;
        }

        public override string GetName()
        {
            return base.GetName() + " with new indicator";
        }

    }

    public class LegacyOldCarWithNewIndicatorAndWheel : LegacyOldCarWithNewIndicator
    {
        public LegacyOldCarWithNewIndicatorAndWheel(LegacyOldCar legacyOldCar) : base(legacyOldCar)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 200;
        }

        public override string GetName()
        {
            return base.GetName() + " with new wheel";
        }

    }

}
