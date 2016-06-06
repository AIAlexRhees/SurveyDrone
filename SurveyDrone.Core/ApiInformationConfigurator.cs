using System;

namespace SurveyDrone.Core
{
    public abstract class ApiInformationConfigurator
    {
        public abstract ApiInformationConfigurator SetName(string name);
        public abstract ApiInformationConfigurator SetDescription(string name);
        public abstract ApiInformationConfigurator SetVersion(int major, int minor, int patch, params string[] releaseTags);
        public abstract ApiInformationConfigurator SetContact(Action<ApiContactConfigurator> config);
    }
}