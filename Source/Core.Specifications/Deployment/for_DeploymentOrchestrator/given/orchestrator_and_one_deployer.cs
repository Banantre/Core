using Core.Deployments;
using Machine.Specifications;
using Moq;

namespace Core.Specifications.Deployment.for_DeploymentOrchestrator.given
{
    public class orchestrator_and_one_deployer : all_dependencies
    {
        protected static Mock<IDeployer>  deployer_mock; 
        protected static DeploymentOrchestrator orchestrator;

        Establish context = () => 
        {
            deployer_mock = new Mock<IDeployer>();
            deployers_mock.SetupGet(d=>d.All).Returns(new[] { deployer_mock.Object });
            orchestrator = new DeploymentOrchestrator(deployers_mock.Object); 
        };
    }
}