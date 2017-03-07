using System.ServiceModel;
using System.ServiceProcess;
using WcfJobsLibrary;

namespace JobsService
{
    public partial class Service1 : ServiceBase
    {
        private ServiceHost sHost;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            sHost = new ServiceHost(typeof(Jobs));
            sHost.Open();
        }

        protected override void OnStop()
        {
            sHost.Close();
        }
    }
}
