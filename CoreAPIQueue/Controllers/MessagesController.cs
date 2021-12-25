using CoreAPIQueue.Model;
using CoreAPIQueue.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIQueue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private const string QUEUE_NAME = "pkqueue";
        private readonly IQueueService _queueService;
        public MessagesController(IQueueService queueService)
        {
            _queueService = queueService ?? throw new ArgumentNullException(nameof(queueService));
        }
        [HttpPost]
        public IActionResult Send([FromBody] QueueMessage queueMessage)
        {
            _queueService.SendMessage(QUEUE_NAME, queueMessage.Message);
            return Ok();
        }
    }
}
