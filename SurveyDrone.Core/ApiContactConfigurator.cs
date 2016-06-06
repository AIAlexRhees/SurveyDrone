namespace SurveyDrone.Core
{
    public abstract class ApiContactConfigurator
    {
        public abstract ApiContactConfigurator SetName(string name);
        public abstract ApiContactConfigurator SetTel(string tel);
        public abstract ApiContactConfigurator SetEmail(string email);
        public abstract ApiContactConfigurator SetUrl(string url);
    }
}