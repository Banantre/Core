/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Runtime.Deployments
{
    /// <summary>
    /// Defines a system for getting <see cref="IDeployer">deployers</see> in memory
    /// </summary>
    public interface IDeployers
    {
        /// <summary>
        /// Get all deployers in memory
        /// </summary>
        /// <returns><see cref="IEnumerable{IDeployer}">All deployers</see> in memory </returns>
        IEnumerable<IDeployer> All { get; }
    }
}