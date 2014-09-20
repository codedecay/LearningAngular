///<reference path="classes.ts"/>

// ReSharper disable InconsistentNaming



var phonecatApp = angular.module('phonecatApp', []);

class PhonecatAppController {
    constructor($scope:IPhonecatScope) {
        $scope.phones = [new Phone('Nexus S', 'Fast just got faster with Nexus S.'),
                         new Phone('Motorola XOOM™ with Wi-Fi', 'The Next, Next Generation tablet.'),
                         new Phone('MOTOROLA XOOM™','The Next, Next Generation tablet.')];

    }
}










// ReSharper restore InconsistentNaming