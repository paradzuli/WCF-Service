using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfJobsLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJobs" in both code and config file together.
    [ServiceContract]
    public interface IJobs
    {
        [OperationContract]
        DataSet GetJobs();

        [OperationContract]
        Job GetJobInfo(int jobID);
    }
}
