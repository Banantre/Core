/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

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
        /// Gets all the steps
        /// </summary>
        /// <returns><see cref="IEnumerable{IDeploymentStep}">Deployment steps</see> </returns>
        IEnumerable<IDeploymentStep>    Steps { get; }
    }
}