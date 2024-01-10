using System.ComponentModel.DataAnnotations;

namespace Modulo7.Atributos
{
    public class AllLettersValidationAttribute :  ValidationAttribute
    {
        public override bool IsValid(Object value)
        {
            var result = ((string)value).All(Char.IsLetter);


            return result;
        }

    }
}
