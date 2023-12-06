using Microsoft.Extensions.Hosting.Internal;

namespace Visitas.Models
{
    public class LibrioVisitasAdm
    {
        public void GuardarVisitas(string nombre,string comentario)
        {
            StreamWriter streamWriter = new StreamWriter($"{Directory.GetCurrentDirectory()}/datos.text", true);
            streamWriter.WriteLine($"Nombre: {nombre} <br> Comentarios: {comentario} <hr>");
            streamWriter.Close();
        }

        public string LeerVisitas()
        {
       
            StreamReader streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}/datos.text");
            var data = streamReader.ReadToEnd();
            streamReader.Close();
            return data;
            
        }
    }
}
