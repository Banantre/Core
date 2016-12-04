/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using Runtime.Services;

namespace Runtime.Deployments
{
    /// <summary>
    /// Defines a deployer - something that knows about and is capable of deploying <see cref="IArtefacts"/>
    /// </summary>
    public interface IDeployer
    {
        /// <summary>
        /// Name of the deployer
        /// </summary>
        /// <returns></returns>
        string Name { get; }

        /// <summary>
        /// Gets all the steps for a specific <see cref="IServiceManifest"/>
        /// </summary>
        /// <returns><see cref="IEnumerable{IDeploymentStep}">Deployment steps</see> </returns>
        IEnumerable<IDeploymentStep>    GetStepsFor(IServiceManifest manifest);
    }
}