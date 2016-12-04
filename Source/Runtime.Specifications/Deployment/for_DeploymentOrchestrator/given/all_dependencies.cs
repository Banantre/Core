/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Runtime.Deployments;
using Machine.Specifications;
using Moq;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator.given
{
    public class all_dependencies
    {
        protected static Mock<IDeployers> deployers_mock;
        protected static Mock<IDeploymentStepOrchestrator> deployment_step_orchestrator_mock;

        Establish context = () => 
        {
            deployers_mock = new Mock<IDeployers>();
            deployment_step_orchestrator_mock = new Mock<IDeploymentStepOrchestrator>();
        };
    }
}