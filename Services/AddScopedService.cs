namespace AddTransientvsScoped.Services
{

    //will give you the same value 
    public interface IAddScopedService
    {
        Guid OperationId { get; }


    }

    public class AddScopedService : IAddScopedService
    {
        public Guid OperationId { get; private set; }


        public AddScopedService() {
        
        
            OperationId = Guid.NewGuid();
            Console.WriteLine("Hello");

        }

    }
}
