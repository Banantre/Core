/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Runtime.Services
{
    /// <summary>
    /// Defines a configuration for a deployment
    /// </summary>
    public interface IServiceManifest
    {
        /// <summary>
        /// Gets the type of deployer of the 
        /// </summary>
        /// <returns></returns>
        string DeployerType { get; }

        /// <summary>
        /// Gets the artefacts for the deploiyment
        /// </summary>
        /// <returns></returns>
        IEnumerable<IArtefact> Artefacts { get; }
    }
}