namespace AddTransientvsScoped.Services
{


    public interface IAddTransientService
    {
        Guid OperationId { get; }
    }

    public class AddTransientService:IAddTransientService
    {
        public Guid OperationId { get; private set; }


        public AddTransientService()
        {
            OperationId = Guid.NewGuid();

            Console.WriteLine("Hello");

        }


    }
}
