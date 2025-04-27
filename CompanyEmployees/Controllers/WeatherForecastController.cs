using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    //public class WeatherForecastController : ControllerBase
    //{
    //    private ILoggerManager _logger;
    //    public WeatherForecastController(ILoggerManager logger)
    //    {

    //        _logger = logger;
    //    }
    //    [HttpGet]
    //    public IEnumerable<string> Get()
    //    {
    //        _logger.LogInfo("��� �������������� ��������� �� ������ ����������� ��������.");

    //        _logger.LogDebug("��� ���������� ��������� �� ������ ����������� ��������.");

    //        _logger.LogWarn("��� ��������� �������������� �� ������ ����������� ��������.");

    //        _logger.LogError("��� ��������� �� ������ �� ������ ����������� ��������.");
    //        return new string[] { "value1", "value2" };
    //    }
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
    

