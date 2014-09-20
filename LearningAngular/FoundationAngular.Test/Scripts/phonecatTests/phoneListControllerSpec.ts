///<reference path="../../../FoundationAngular/Scripts/app/interfaces.ts"/>
///<reference path="../../../FoundationAngular/Scripts/app/classes.ts"/>
///<reference path="../../../FoundationAngular/Scripts/app/controllers.ts"/>

describe('PhonecatAppController', () => {

    it('should create "phones" model with 3 phones', () => {
    //Dont fold
        var scope: IPhonecatScope;
        scope = <IPhonecatScope>{};
        var controller: PhonecatAppController;
        controller = new PhonecatAppController(scope);
        expect(scope.phones.length).toBe(3);
    }); })
