/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Runtime.Deployments;
using Machine.Specifications;

namespace Runtime.Specifications.Deployment.for_DeploymentOrchestrator.given
{
    public class an_orchestrator : all_dependencies
    {
        protected static DeploymentOrchestrator orchestrator;

        Establish context = () => 
        {
            orchestrator = new DeploymentOrchestrator(deployers_mock.Object, deployment_step_orchestrator_mock.Object); 
        };
    }
}