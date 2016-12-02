/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Linq;

namespace Core.Deployments
{
    /// <summary>
    /// Represents an implementation of <see cref="IDeploymentOrchestrator"/>
    /// </summary>
    public class DeploymentOrchestrator : IDeploymentOrchestrator
    {
         IDeployers _deployers;

        /// <summary>
        /// Initializes an instance of <see cref="DeploymentOrchestrator"/>
        /// </summary>
        /// <param name="deployers">Deployers to work with</param>
        
        public DeploymentOrchestrator(IDeployers deployers)
        {
            _deployers = deployers;
        }

#pragma warning disable 1591 // Xml Comments
        public void Orchestrate()
        {
            foreach( var deployer in _deployers.All ) 
            {
                var steps = deployer.Steps;
            }
        }
#pragma warning restore 1591 // Xml Comments        
    }
}