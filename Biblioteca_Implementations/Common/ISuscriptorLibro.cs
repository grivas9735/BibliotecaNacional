using Biblioteca_Common.DTO;

namespace Biblioteca_Implementations.Common
{
    public interface ISuscriptorLibro
    {
        void Notify(DTOLibro libro);
    }
}
