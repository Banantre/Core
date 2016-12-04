/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Runtime.Deployments
{
    /// <summary>
    /// The exception that gets thrown if the <see cref="Deployer">deployer type<see> is wrong
    /// </summary>
    public class DeployerTypeDoesNotExist : ArgumentException
    {
        public DeployerTypeDoesNotExist(string deployerType)
            :base($"Deployer of type '{deployerType}' does not exist")
        {
        }
    }
}