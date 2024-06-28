using InjecaoDP.Interfaces;

namespace InjecaoDP.Service
{
    public class SingletonService : ISingleton
    {
        public SingletonService()
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
