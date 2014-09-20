///<reference path="interfaces.ts"/>


class Phone implements IPhone {
    name: string;
    snippet:string;
    constructor(phoneName: string, phoneSnippet: string) {
        this.name = phoneName;
        this.snippet = phoneSnippet;
    }
}