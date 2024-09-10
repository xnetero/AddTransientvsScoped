using AddTransientvsScoped.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddTransientvsScoped.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AddTransientController :ControllerBase
    {

        private readonly IAddTransientService _transientOperation1;
        private readonly IAddTransientService _transientOperation2;
        private readonly Guid _transientOperation3;


        public AddTransientController(IAddTransientService transientOperation1 ,
            IAddTransientService transientOperation3 , 
            IAddTransientService transientOperation2)
        {
            _transientOperation1 = transientOperation1; 
            _transientOperation2=transientOperation2;
            _transientOperation3 = Guid.NewGuid(); ;


        }

        [HttpGet(Name = "AddTransientEndpoint")]
        public IActionResult GetOperations()
        {
            var response = new
            {
                Transient1 = _transientOperation1.OperationId,
                Transient2 = _transientOperation2.OperationId , 
                Transient3 = _transientOperation3

            };

            return Ok(response);
        }




    }
}
