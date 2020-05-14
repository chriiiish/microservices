using Amazon.CDK;
using Amazon.CDK.AWS.SSM;

namespace Infrastructure
{
    public class InfrastructureStack : Stack
    {
        internal InfrastructureStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // Parameters
            var domainName = new Amazon.CDK.AWS.SSM.CfnParameter(scope, "DomainNameParameter", new Amazon.CDK.AWS.SSM.CfnParameterProps(){
                Name = $"/{id}/DomainName",
                Description = "The Domain Name the application is running on",
                Type = "String",
                Value = ""
            });
        }
    }
}
