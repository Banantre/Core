/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Machine.Specifications;
using Moq;
using Runtime.Deployments;
using Runtime.Services;
using It = Machine.Specifications.It;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator
{
    public class when_orchestrating_with_known_deployer : given.an_orchestrator
    {
        const string deployer_type = "SomeDeployerType";
        static Mock<IServiceManifest>   service_manifest_mock;
        static Mock<IDeployer> deployer_mock;

        Establish context = () => 
        {
            service_manifest_mock = new Mock<IServiceManifest>();
            service_manifest_mock.SetupGet(s => s.DeployerType).Returns(deployer_type);

            deployer_mock = new Mock<IDeployer>();
            deployers_mock.Setup(d => d.GetByTypeName(deployer_type)).Returns(deployer_mock.Object);
        };

        Because of = () => orchestrator.Orchestrate(service_manifest_mock.Object);

        It should_get_steps_for_the_service_manifest = () => deployer_mock.Verify(d => d.GetStepsFor(service_manifest_mock.Object), Times.Once());
    }
}