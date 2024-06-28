using InjecaoDP.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDP.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DIController : ControllerBase
    {
        private readonly ISingleton _singletonService;
        private readonly ISingleton _singletonService2;
        private readonly ITransient _transientService;
        private readonly ITransient _transientService2;
        private readonly IScoped    _scopedService;
        private readonly IScoped    _scopedService2;

        public DIController(ISingleton singletonService, ISingleton singletonService2, 
            ITransient transientService, ITransient transientService2,
            IScoped scopedService, IScoped scopedService2)
        {
            _singletonService = singletonService;
            _singletonService2 = singletonService2;
            _transientService = transientService;
            _transientService2 = transientService2;
            _scopedService = scopedService;
            _scopedService2 = scopedService2;
        }

        [HttpGet]
        public IActionResult GetInstanceSingleton()
        {
            var result = _singletonService.ReturnId();
            var result2 = _singletonService2.ReturnId();

            var resultConcatened = $"SINGLETON:\nPrimeira instancia: {result}\n" + $"Segunda instancia: {result2}";

            return Ok(resultConcatened);
        }

        [HttpGet]
        public IActionResult GetInstanceScoped()
        {
            var result = _scopedService.ReturnId();
            var result2 = _scopedService2.ReturnId();

            var resultConcatened = $"SCOPED:\nPrimeira instancia: {result}\n" + $"Segunda instancia: {result2}";
            return Ok(resultConcatened);
        }

        [HttpGet]
        public IActionResult GetInstanceTransient()
        {
            var result = _transientService.ReturnId();
            var result2 = _transientService2.ReturnId();

            var resultConcatened = $"TRANSIENT:\nPrimeira instancia: {result}\n" + $"Segunda instancia: {result2}";

            return Ok(resultConcatened);
        }
    }
}
