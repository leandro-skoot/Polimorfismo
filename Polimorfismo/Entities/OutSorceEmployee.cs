namespace Polimorfismo.Entities
{
    class OutSorceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSorceEmployee()
        {
        }

        public OutSorceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }


}
