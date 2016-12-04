/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import * as Context from "./given/nothing";
import {Deployer} from "../../../Runtime.JavaScript/Deployments/Deployer";

describe("when doing nothing", () => {
    let context = null;
    let deployer = null;

    beforeEach(() => {
        context = new Context.default();
        deployer = new Deployer();

        (becauseOf => {

        })();
    });

    it("should do absolutely nothing", () => true.should.be.true);
});