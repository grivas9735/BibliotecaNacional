using System.Collections.Generic;
using System.Linq;

namespace BibliotecaAPI.Gestores
{
    internal class Suscription
    {
        public Suscription(int lectorId, int libroId)
        {
            LectorId = lectorId;
            LibroId = libroId;
        }

        public int LectorId { get; set; }

        public int LibroId { get; set; }
    }

    public class Biblioteca
    {
        private static Biblioteca biblioteca;

        private IList<Suscription> Suscribers;

        private Biblioteca() 
        {
            Suscribers = new List<Suscription>();
        }

        public static Biblioteca GetInstance()
        {
            if (biblioteca == null)
                biblioteca = new Biblioteca();

            return biblioteca;
        }

        public void Suscribe(int lectorId, int libroId)
        {
            if (!Suscribers.Any(x => x.LectorId == lectorId && x.LibroId == libroId))
            {
                Suscribers.Add(new Suscription(lectorId, libroId));
            }
        }

        public void UnSuscribe(int lectorId, int libroId)
        {
            var toRemove = Suscribers.FirstOrDefault(x => x.LectorId == lectorId && x.LibroId == libroId);

            if (toRemove != null)
                Suscribers.Remove(toRemove);
        }

        public void NotifyLectores(int libroId)
        {
            foreach (var suscription in Suscribers.Where(x => x.LibroId == libroId))
            {
                // Notificar a todos los lectores que se puso a disposición el libro "libroId"
            }
        }
    }
}
