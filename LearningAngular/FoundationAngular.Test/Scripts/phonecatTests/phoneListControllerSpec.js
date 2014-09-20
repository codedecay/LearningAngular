///<reference path="../../../FoundationAngular/Scripts/app/interfaces.ts"/>
///<reference path="../../../FoundationAngular/Scripts/app/classes.ts"/>
///<reference path="../../../FoundationAngular/Scripts/app/controllers.ts"/>
describe('PhonecatAppController', function () {
    it('should create "phones" model with 3 phones', function () {
        //Dont fold
        var scope;
        scope = {};
        var controller;
        controller = new PhonecatAppController(scope);
        expect(scope.phones.length).toBe(3);
    });
});
//# sourceMappingURL=phoneListControllerSpec.js.map
