using System;

namespace SurveyDrone.Core
{
    internal class CoreSurveyDroneConfigurator : SurveyDroneConfigurator
    {
        private readonly SurveyDroneCore _core;

        public CoreSurveyDroneConfigurator(SurveyDroneCore core)
        {
            _core = core;
        }

        public override SurveyDroneConfigurator SetApiInformation(Action<ApiInformationConfigurator> config)
        {
            throw new NotImplementedException();
        }

        public override SurveyDroneConfigurator SetBaseUri(Uri uri)
        {
            throw new NotImplementedException();
        }

        public override SurveyDroneConfigurator SetDataDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public override SurveyDroneConfigurator SecurityOperation(Action<SecurityOperationConfigurator> config)
        {
            throw new NotImplementedException();
        }

        public override SurveyDroneConfigurator SetExternalDocument(ExternalDocumentType docType, string path)
        {
            throw new NotImplementedException();
        }
    }
}