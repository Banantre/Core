/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Runtime.Deployments
{
    /// <summary>
    /// Defines a step that can be performed during a deployment
    /// </summary>
    public interface IDeploymentStep
    {
        /// <summary>
        /// Perform the <see cref="IDeploymentStep"/>
        /// </summary>
        void Perform();

        /// <summary>
        /// Rollback the <see cref="IDeploymentStep"/>
        /// </summary>
        void Rollback();

        /// <summary>
        /// Commit the <see cref="IDeploymentStep"/>
        /// </summary>
        void Commit();
    }
}