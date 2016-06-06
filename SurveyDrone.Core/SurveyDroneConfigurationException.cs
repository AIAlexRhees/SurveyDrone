using System;

namespace SurveyDrone.Core
{
    public class SurveyDroneConfigurationException : Exception
    {
        public int Code { get; }

        public SurveyDroneConfigurationException(int code, string message) : base(message)
        {
            Code = code;
        }
    }
}