namespace AddTransientvsScoped.Services
{


    public interface IAddSingletonService
    {
        Guid OperationId { get; }
    }

    public class AddSingletonService : IAddSingletonService
    {
        public Guid OperationId { get; private set; }
        public AddSingletonService() {

            OperationId= Guid.NewGuid();    


        }
    }

   


}
