using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWindowsService.JobsServiceReference;

namespace TestWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new JobsClient();
            Job job = test.GetJobInfo(1);
            Console.WriteLine(job.Description);

        }
    }
}
