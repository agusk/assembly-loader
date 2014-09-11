using System;

namespace Job
{
    public interface IJob
    {
        string Perform(string jobId);
    }
}
