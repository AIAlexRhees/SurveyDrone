using System;

namespace SurveyDrone.Core
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PermissionAttribute : Attribute
    {
        
    }
}