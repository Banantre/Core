/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;

namespace Runtime.Deployments
{
    /// <summary>
    /// Represents an implementation of <see cref="IDeployers"/>
    /// </summary>
    public class Deployers : IDeployers
    {

#pragma warning disable 1591 // Xml Comments        
        public IDeployer GetByTypeName(string typeName)
        {
            throw new NotImplementedException();
        }
#pragma warning restore 1591 // Xml Comments        
    }
}