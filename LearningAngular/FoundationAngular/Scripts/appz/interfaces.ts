interface IPhone {
    name: string;
    snippet:string;
}


interface IPhonecatScope extends ng.IScope {
    phones: IPhone[]
} 