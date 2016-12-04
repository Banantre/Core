/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Runtime.Deployments
{
    /// <summary>
    /// Defines a system for getting <see cref="IDeployer">deployers</see> in memory
    /// </summary>
    public interface IDeployers
    {
        /// <summary>
        /// Get a deployer based on its typename
        /// </summary>
        /// <param name="typeName">Name of the deployer</param>
        /// <returns><see cref="IDeployer"/> found</returns>
        IDeployer   GetByTypeName(string typeName);
    }
}