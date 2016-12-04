using System.Collections.Generic;
using Runtime.Deployments;
using Machine.Specifications;
using Moq;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator.given
{
    public class an_orchestrator : all_dependencies
    {
        protected static Mock<IDeployer>  deployer_mock; 
        protected static DeploymentOrchestrator orchestrator;

        protected static IEnumerable<IDeploymentStep> deployment_steps;

        Establish context = () => 
        {
            deployment_steps = new IDeploymentStep[0];
            deployer_mock = new Mock<IDeployer>();
            orchestrator = new DeploymentOrchestrator(deployers_mock.Object, deployment_step_orchestrator_mock.Object); 
        };
    }
}