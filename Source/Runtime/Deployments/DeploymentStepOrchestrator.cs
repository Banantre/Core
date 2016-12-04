/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace Runtime.Deployments
{
    /// <summary>
    /// /// Represents an implementation of <see cref="IDeploymentStepOrchestrator"/>
    /// </summary>
    public class DeploymentStepOrchestrator : IDeploymentStepOrchestrator
    {
#pragma warning disable 1591 // Xml Comments
        public void Orchestrate(IEnumerable<IDeploymentStep> steps)
        {
            throw new NotImplementedException();
        }
#pragma warning restore 1591 // Xml Comments        
    }
}