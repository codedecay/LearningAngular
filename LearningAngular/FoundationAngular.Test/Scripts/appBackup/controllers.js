///<reference path="classes.ts"/>
// ReSharper disable InconsistentNaming
var phonecatApp = module('phonecatApp', []);

var PhonecatAppController = (function () {
    function PhonecatAppController($scope) {
        $scope.phones = [
            new Phone('Nexus S', 'Fast just got faster with Nexus S.'),
            new Phone('Motorola XOOM™ with Wi-Fi', 'The Next, Next Generation tablet.'),
            new Phone('MOTOROLA XOOM™', 'The Next, Next Generation tablet.')];
    }
    return PhonecatAppController;
})();
// ReSharper restore InconsistentNaming
//# sourceMappingURL=controllers.js.map
