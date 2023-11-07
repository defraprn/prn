using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WasteMgmtService.Data;
using WasteMgmtService.Data.Dtos;
using WasteMgmtService.Models;

namespace WasteMgmtService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WastesController : ControllerBase
    {
        private readonly ILogger<WastesController> _logger;
        private IWasteRepo _repository;
        private readonly IMapper _mapper;

        public WastesController(IWasteRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WasteReadDto>> GetWastes()
        {
            var wasteItems = _repository.GetAllWastes();
            return Ok(_mapper.Map<IEnumerable<WasteReadDto>>(wasteItems));
        }

    }
}
