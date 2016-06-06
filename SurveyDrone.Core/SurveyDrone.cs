using System;
using System.Threading;

namespace SurveyDrone.Core
{
    public class SurveyDrone
    {
        internal SurveyDrone()
        {
            
        }

        private SurveyDroneCore core { get; set; } = null;
        private object lockObj = new object();

        public void Start(Action<SurveyDroneConfigurator> config)
        {
            Monitor.Enter(lockObj);
            try
            {
                if (core == null)
                {
                    SurveyDroneConfigurator configurator = new CoreSurveyDroneConfigurator(core = new SurveyDroneCore());

                    config(configurator);
                }
                else
                {
                    throw new SurveyDroneConfigurationException(100, "Survey drone has already been initialized and configured.");
                }
            }
            finally
            {
                Monitor.Exit(lockObj);
            }
        }
    }
}