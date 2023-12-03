/*
//EX1
Cachorro cachorro1 = new Cachorro {Nome = "Bolinha", Idade = 3}; //cria o animal e da Nome e idade a eles
cachorro1.emitirSom();

Gato gato1 = new Gato {Nome = "cebola", Idade = 4}; //cria o animal e da Nome e idade a eles
gato1.emitirSom();


//EX2
Cachorro cachorro1 = new Cachorro("Bolinha", 3); //cria o animal e da Nome e idade a eles
Console.WriteLine(cachorro1.emitirSom());  //chama o metodo para o objeto

Gato gato1 = new Gato("Cebola", 4); //cria o animal e da Nome e idade a eles
Console.WriteLine(gato1.emitirSom()); //chama o metodo para o objeto

*/
//EX3
Cachorro cachorro1 = new Cachorro("Bolinha", 3); //cria o animal e da Nome e idade a eles
cachorro1.emitirSom();

Gato gato1 = new Gato("Cebola", 4); //cria o animal e da Nome e idade a eles
gato1.emitirSom();
/*
//EX4

List<Animal> animais = new List<Animal>(); //cria a lista de animais

animais.Add(new Cachorro("Bolinha", 4));
animais.Add(new Cachorro("Smurf", 5));
animais.Add(new Gato("lua", 10));


foreach (Animal _ in animais){
    Console.WriteLine(_.emitirSom());
}

*/