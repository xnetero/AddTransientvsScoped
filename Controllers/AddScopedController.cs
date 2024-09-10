using AddTransientvsScoped.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddTransientvsScoped.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class AddScopedController : ControllerBase
    {

        private readonly IAddScopedService _transientOperation1;
        private readonly IAddScopedService _transientOperation2;

        
        public AddScopedController(IAddScopedService transientOperation1, IAddScopedService transientOperation2)
        {
            _transientOperation1 = transientOperation1;
            _transientOperation2 = transientOperation2;


        }


        [HttpGet(Name = "AddScopedEndpoint")]
        public IActionResult GetOperations()
        {
            var response = new
            {
                Transient1 = _transientOperation1.OperationId,
                Transient2 = _transientOperation2.OperationId
            };

            return Ok(response);
        }

    }
}
