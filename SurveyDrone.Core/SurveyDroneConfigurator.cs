using System;

namespace SurveyDrone.Core
{
    public abstract class SurveyDroneConfigurator
    {
        public abstract SurveyDroneConfigurator SetApiInformation(Action<ApiInformationConfigurator> config);
        public abstract SurveyDroneConfigurator SetBaseUri(Uri uri);
        public abstract SurveyDroneConfigurator SetDataDirectory(string path);
        public abstract SurveyDroneConfigurator SecurityOperation(Action<SecurityOperationConfigurator> config);
        public abstract SurveyDroneConfigurator SetExternalDocument(ExternalDocumentType docType, string path);
    }
}