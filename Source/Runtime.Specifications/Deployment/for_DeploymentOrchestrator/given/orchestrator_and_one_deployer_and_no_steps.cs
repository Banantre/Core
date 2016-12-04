using System.Collections.Generic;
using Runtime.Deployments;
using Machine.Specifications;
using Moq;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator.given
{
    public class orchestrator_and_one_deployer_and_no_steps : all_dependencies
    {
        protected static Mock<IDeployer>  deployer_mock; 
        protected static DeploymentOrchestrator orchestrator;

        protected static IEnumerable<IDeploymentStep> deployment_steps;

        Establish context = () => 
        {
            deployment_steps = new IDeploymentStep[0];
            deployer_mock = new Mock<IDeployer>();
            deployer_mock.SetupGet(d => d.Steps).Returns(deployment_steps);
            deployers_mock.SetupGet(d=>d.All).Returns(new[] { deployer_mock.Object });
            orchestrator = new DeploymentOrchestrator(deployers_mock.Object, deployment_step_orchestrator_mock.Object); 
        };
    }
}