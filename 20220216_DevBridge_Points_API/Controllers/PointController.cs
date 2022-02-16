using _20220216_DevBridge_Points_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _20220216_DevBridge_Points_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private readonly PointService _pointService;
        public PointController(PointService pointService)
        {
            _pointService = pointService;
        }
    }
}
