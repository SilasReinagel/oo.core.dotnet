using OO.Core.Types;

namespace OO.Core.Math
{
    public class Product : Number
    {
        private readonly Number _num1;
        private readonly Number _num2;

        public Product(Number num1, Number num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public override decimal AsReal()
        {
            return _num1.AsReal() * _num2.AsReal();
        }
    }
}
