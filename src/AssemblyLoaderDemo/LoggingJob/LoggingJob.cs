using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingJob
{
    public class LoggingJob:Job.IJob
    {
        public LoggingJob() { }
        public string Perform(string jobId)
        {
            throw new NotImplementedException();
        }
    }
}
