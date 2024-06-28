using InjecaoDP.Interfaces;

namespace InjecaoDP.Service
{
    public class ScopedService : IScoped
    {
        public ScopedService()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid ReturnId()
        {
            return Id;
        }
    }
}
