/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Runtime.Deployments
{
    /// <summary>
    /// /// Represents a null implementation of <see cref="IDeployer"/>
    /// </summary>
    public class NullDeployer : IDeployer
    {

#pragma warning disable 1591 // Xml Comments        
        public string Name { get { return "Null"; } }

        public IEnumerable<IDeploymentStep> Steps { get { return new IDeploymentStep[0]; } }
#pragma warning restore 1591 // Xml Comments
    }
}