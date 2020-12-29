namespace Biblioteca_Implementations.BussinesLogic
{
    public interface IPrestacionBL
    {
        void RetirarLibro(int lectorId, int libroId);
        void DevolverLibro(int lectorId, int libroId);
    }
}