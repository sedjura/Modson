using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ModsonDbAccessorService
{
    public partial class ModsonDbAccessorService : ServiceBase
    {
        private ServiceHost myServiceHost;

        public ModsonDbAccessorService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (myServiceHost != null)
            {
                if (myServiceHost.State == CommunicationState.Opened) myServiceHost.Close();
            }

            try
            {
                myServiceHost = new ServiceHost(typeof(ModsonDbAccessorService));
                myServiceHost.Open();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.ServiceName, ex.Message);
            }
        }

        protected override void OnStop()
        {
            if (myServiceHost != null)
            {
                myServiceHost.Close();
                myServiceHost = null;
            }
        }
    }
}
