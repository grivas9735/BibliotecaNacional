namespace Biblioteca_Implementations.BussinesLogic
{
    public interface IPrestacionBL
    {
        bool RetirarLibro(int lectorId, int libroId);
        void DevolverLibro(int lectorId, int libroId);
    }
}