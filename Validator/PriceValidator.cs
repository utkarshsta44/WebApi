using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PizzaApi.Validator
{
    public class PriceValidator : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            var price = (int)value;
            if (price < 100)
            {
                return false;
            }
            return true;
        }

    }
}
