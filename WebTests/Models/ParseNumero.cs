using WebTests.Excepciones;

namespace WebTests.Models
{
    public class ParseNumero
    {


        public int Parse(string valor)
        {
            try
            {
                return int.Parse(valor);
            }catch(Exception ex)
            {
                throw  new ParseExcepcion(ex.Message,ex);
            }
           
        }
    }
}
