class Animal{
    makeSound(){
        console.log(`Animal Make Sound`)
    }
}

class Dog extends Animal{
    makeSound(){
        console.log(`Dog Barks`);
    }
}

class Cat extends Animal{
    makeSound(){
        console.log(`cat Meow`);
    }
}

class Cow extends Animal{
    makeSound(){
        console.log( `Cow Amba`);
    }
}

let animals=[new Dog(), new Cat(), new Cow()];
animals.forEach(a=>a.makeSound());