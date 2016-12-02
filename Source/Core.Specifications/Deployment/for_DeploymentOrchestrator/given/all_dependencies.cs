using Core.Deployments;
using Machine.Specifications;
using Moq;

namespace Core.Specifications.Deployment.for_DeploymentOrchestrator.given
{
    public class all_dependencies
    {
        protected static Mock<IDeployers> deployers_mock;

        Establish context = () => deployers_mock = new Mock<IDeployers>();
    }
}