using InjecaoDP.Interfaces;

namespace InjecaoDP.Service
{
    public class TransientService : ITransient
    {
        public TransientService()
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
