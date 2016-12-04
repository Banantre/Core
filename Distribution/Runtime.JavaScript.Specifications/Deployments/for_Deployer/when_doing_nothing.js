"use strict";

var _nothing = require("./given/nothing");

var Context = _interopRequireWildcard(_nothing);

var _Deployer = require("../../../Runtime.JavaScript/Deployments/Deployer");

function _interopRequireWildcard(obj) { if (obj && obj.__esModule) { return obj; } else { var newObj = {}; if (obj != null) { for (var key in obj) { if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key]; } } newObj.default = obj; return newObj; } }

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Banantre. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
describe("when doing nothing", function () {
    var context = null;
    var deployer = null;

    beforeEach(function () {
        context = new Context.default();
        deployer = new _Deployer.Deployer();

        (function (becauseOf) {})();
    });

    it("should do absolutely nothing", function () {
        return true.should.be.true;
    });
});
//# sourceMappingURL=when_doing_nothing.js.map
