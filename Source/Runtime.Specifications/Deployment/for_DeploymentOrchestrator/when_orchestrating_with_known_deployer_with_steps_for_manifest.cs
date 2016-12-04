/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using Machine.Specifications;
using Moq;
using Runtime.Deployments;
using Runtime.Services;
using It = Machine.Specifications.It;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator
{
    public class when_orchestrating_with_known_deployer_with_steps_for_manifest : given.an_orchestrator
    {
        const string deployer_type = "SomeDeployerType";
        static Mock<IServiceManifest>   service_manifest_mock;
        static Mock<IDeployer> deployer_mock;
        static Mock<IDeploymentStep> deployment_step_mock;
        static IEnumerable<IDeploymentStep> deployment_steps;

        Establish context = () => 
        {
            service_manifest_mock = new Mock<IServiceManifest>();
            service_manifest_mock.SetupGet(s => s.DeployerType).Returns(deployer_type);

            deployer_mock = new Mock<IDeployer>();
            deployment_step_mock = new Mock<IDeploymentStep>();
            deployment_steps = new IDeploymentStep[] {
                deployment_step_mock.Object
            };
            deployer_mock.Setup(d => d.GetStepsFor(service_manifest_mock.Object)).Returns(deployment_steps);
            deployers_mock.Setup(d => d.GetByTypeName(deployer_type)).Returns(deployer_mock.Object);
        };

        Because of = () => orchestrator.Orchestrate(service_manifest_mock.Object);

        It should_forward_steps_to_steps_orchestrator = () => deployment_step_orchestrator_mock.Verify(d => d.Orchestrate(deployment_steps));
    }
}