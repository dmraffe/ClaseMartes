namespace Modulo6.Models
{
    public interface IFormatNumber
    {
        string GetFormattedNumber(int number);
    }

    public class FormatNumber : IFormatNumber
    {
        public string GetFormattedNumber(int number)
        {
            return string.Format("{0:n0}", number);
        }
    }

}
