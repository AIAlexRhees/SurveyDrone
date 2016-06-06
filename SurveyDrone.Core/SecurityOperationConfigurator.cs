using System;

namespace SurveyDrone.Core
{
    public abstract class SecurityOperationConfigurator
    {
        public abstract SecurityOperationConfigurator LogonWith<TLogonOperationConfigurator>(Action<TLogonOperationConfigurator> config) where TLogonOperationConfigurator : LoginOperationConfigurator;
        public abstract SecurityOperationConfigurator LogoutWith<TLogoutOperationConfigurator>(Action<TLogoutOperationConfigurator> config) where TLogoutOperationConfigurator : LogoutOperationConfigurator;
        public abstract SecurityOperationConfigurator GenericOperation<TGenericSecurityOperationConfigurator>(Action<GenericSecurityOperationConfigurator> config) where TGenericSecurityOperationConfigurator : GenericSecurityOperationConfigurator;
    }
}