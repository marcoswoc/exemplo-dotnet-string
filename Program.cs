// Trim
Console.WriteLine("==== Trim ====");
var  observacao = " Charizard cospe fogo que é quente o suficiente para derreter pedregulhos. ";

Console.WriteLine($"Observação com espaço: {observacao}");
Console.WriteLine($"Observação sem espaço: {observacao.Trim()}");

Console.WriteLine("");

// Length
Console.WriteLine("==== Length ====");
var nome = "Charizard";

Console.WriteLine($"O nome {nome}, tem {nome.Length} caracteres.");

Console.WriteLine("");
//ToUpper
Console.WriteLine("==== ToUpper ====");
var tipo = "fogo";

Console.WriteLine($"Charizard é um pokémon do tipo: {tipo.ToUpper()}");

Console.WriteLine("");
//ToLower
Console.WriteLine("==== ToLower ====");
var tipoSecundario = "VOADOR";

Console.WriteLine($"Charizard é um pokémon do tipo: {tipoSecundario.ToLower()}");

Console.WriteLine("");
//Remove
Console.WriteLine("==== Remove ====");
Console.WriteLine($"Eu chamo meu {nome} de {nome.Remove(5)}.");

Console.WriteLine("");
// Replace
Console.WriteLine("==== Replace ====");
Console.WriteLine(observacao.Replace("Charizard", "Meu Pokémon"));

Console.WriteLine("");
// Split
Console.WriteLine("==== Split ====");
var pokemons = " Charmander, Charmeleon, Charizard";
string[] listaDePokemons = pokemons.Split(',');

foreach (var pokemon in listaDePokemons)
    Console.WriteLine(pokemon);

Console.WriteLine("");
// Substring
Console.WriteLine("==== Substring ====");
Console.WriteLine(observacao.Substring(11,10));

Console.WriteLine("");
// IsNullOrEmpty
Console.WriteLine("==== IsNullOrEmpty ====");
string nomeDoPokemon = "";

if (String.IsNullOrEmpty(nomeDoPokemon))
    Console.WriteLine("O nome do Pokémon não pode ser nulo ou vazio");

Console.WriteLine("");