using System;
using Machine.Specifications;
using Moq;
using Runtime.Deployments;
using Runtime.Services;
using It = Machine.Specifications.It;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator
{
    public class when_orchestrating_without_known_deployer : given.an_orchestrator
    {
        const string deployer_type = "SomeDeployerType";
        static Mock<IServiceManifest>   service_manifest_mock;
        static Exception exception; 

        Establish context = () => 
        {
            service_manifest_mock = new Mock<IServiceManifest>();
            service_manifest_mock.SetupGet(s => s.DeployerType).Returns(deployer_type);
            deployers_mock.Setup(d => d.GetByTypeName(deployer_type)).Returns((IDeployer)null);
        };

        Because of = () => exception = Catch.Exception(() => orchestrator.Orchestrate(service_manifest_mock.Object));

        It should_throw_unknown_deployer_exception = () => exception.ShouldBeOfExactType<DeployerTypeDoesNotExist>(); 

        
    }
}