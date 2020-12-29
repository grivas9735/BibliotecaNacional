using AutoMapper;

namespace Biblioteca_BussinesLogic.BL
{
    public abstract class BaseBL
    {
        protected readonly IMapper Mapper;

        protected BaseBL(IMapper _mapper)
        {
            Mapper = _mapper;
        }
    }
}
