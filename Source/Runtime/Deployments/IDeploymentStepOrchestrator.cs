/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Core.Deployments
{
    /// <summary>
    /// Represents an orcestrator for <see cref="IDeployementStep">deployment steps</see>
    /// </summary>
    public interface IDeploymentStepOrchestrator
    {
        /// <summary>
        /// Orcestrate the steps
        /// </summary>
        /// <param name="steps"><see cref="IEnumerable{IDeploymentStep}">Steps</see> to orchestrate</param>
        void Orchestrate(IEnumerable<IDeploymentStep> steps);      
    }
}