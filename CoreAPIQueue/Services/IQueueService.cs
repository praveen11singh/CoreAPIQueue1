using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIQueue.Services
{
    public interface IQueueService
    {
        void SendMessage(string queueName, string message);
    }
}
