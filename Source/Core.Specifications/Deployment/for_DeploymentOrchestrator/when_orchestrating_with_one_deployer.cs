using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Core.Specifications.Deployment.for_DeploymentOrchestrator
{
    public class when_orchestrating_with_one_deployer : given.orchestrator_and_one_deployer_and_no_steps
    {
        Because of = () => orchestrator.Orchestrate();

        It should_get_all_the_steps = () => deployer_mock.VerifyGet(d=>d.Steps, Times.Once);
        It should_forward_the_steps_to_steps_orchestrator = () => deployment_step_orchestrator_mock.Verify(d => d.Orchestrate(deployment_steps), Times.Once);
    }
}