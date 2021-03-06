![banner](Img/Banner.png)
# Funções de string

O C# disponibiliza alguns métodos para manipular strings, funcionalidades comuns que facilitam a vida do desenvolvedor. Nesse artigo vamos conhecer algumas destas funcionalidades.

## Trim

Esse método remove todos os espaços em branco do **início** e do **final** de uma string, caso exista espaço em branco no meio da string o **``Trim()``** não remove esses casos.
O método **``Trim()``** é muito utilizado quando recebemos uma string de alguma fonte de dados que não conseguimos garantir sua formatação, como dados de arquivos de texto, arquivos CSV ou arquivos Excel.

```C#
    Console.WriteLine("==== Trim ====");
    var  observacao = " Charizard cospe fogo que é quente o suficiente para derreter pedregulhos. ";

    Console.WriteLine($"Observação com espaço: {observacao}");
    Console.WriteLine($"Observação sem espaço: {observacao.Trim()}");
```

![img-01](Img/img-01.png)

## Length

Quando queremos saber o tamanho de uma string utilizamos **``Length``** que retorna a quantidade de caracteres a string possui incluindo os espaços em branco em toda a expressão.
``Length``** é utilizado por exemplo para validar quantos caracteres foram digitados por um usuário, pode também ajudar na hora de obter uma parte específica de uma string.

```C#
    Console.WriteLine("==== Length ====");
    var nome = "Charizard";

    Console.WriteLine($"O nome {nome}, tem {nome.Length} caracteres.");
```

![img-02](Img/img-02.png)

## ToUpper

Podemos utilizar **``ToUpper()``** para transformar todos os caracteres de uma string em letras maiúsculas. Pode ser aplicado quando precisamos de uma formatação específica, ou para não diferenciar palavras com letras maiúsculas e minúsculas transformando todas em maiúsculas e comparando.

```C#
    Console.WriteLine("==== ToUpper ====");
    var tipo = "fogo";

    Console.WriteLine($"Charizard é um pokémon do tipo: {tipo.ToUpper()}");
```

![img-03](Img/img-03.png)

## ToLower

O método **``ToLower()``** faz exatamente o contrário do ToUpper, transforma todos os caracteres de uma string em letras minúsculas.

```C#
    Console.WriteLine("==== ToLower ====");
    var tipoSecundario = "VOADOR";

    Console.WriteLine($"Charizard é um pokémon do tipo: {tipoSecundario.ToLower()}");
```

![img-04](Img/img-04.png)

## Remove

O método **``Remove()``** é utilizado para obter parte de uma string considerando apenas os caracteres à esquerda de uma expressão. Podemos utilizar para remover partes que não são necessárias em uma string, é necessário informar quantos caracteres serão considerados.

```C#
    Console.WriteLine("==== Remove ====");
    var nome = "Charizard";

    Console.WriteLine($"Eu chamo meu {nome} de {nome.Remove(5)}.");
```

![img-5](Img/img-05.png)

## Replace

O método **``Replace()``** é utilizado para substituir expressões de uma string, é necessário informar o texto a ser substituído, e o novo texto. Pode ser utilizado quando há a necessidade de substituir expressões para um valor padrão, ou que faça sentido para contexto do seu sistema/aplicação.

```C#
    Console.WriteLine("==== Replace ====");
    var  observacao = " Charizard cospe fogo que é quente o suficiente para derreter pedregulhos. ";

    Console.WriteLine(observacao.Replace("Charizard", "Meu Pokémon"));
```

![img-6](Img/img-06.png)

## Split

O método **``Split()``** é muito utilizado quando queremos separar uma string utilizando um caractere chave. Esse recurso funciona bem no tratamento de arquivos CSV, onde o caractere **``;``** é usado com chave para separar a string. O resultado é retornado em um array de string.

```C#
    Console.WriteLine("==== Split ====");
    var pokemons = " Charmander, Charmeleon, Charizard";
    string[] listaDePokemons = pokemons.Split(',');

    foreach (var pokemon in listaDePokemons)
        Console.WriteLine(pokemon);
```

![img-07](Img/img-07.png)

## Substring

O método **``Substring()``** é utilizado para obter parte de um texto a partir de uma posição inicial,podemos informar um segundo parâmetro que representa quantos caracteres vão ser considerados após a posição inicial, esse parâmetro pode ou não ser informado, caso não seja,  será considerado todo o texto a partir da posição inicial.

```C#
    Console.WriteLine("==== Substring ====");
    var  observacao = " Charizard cospe fogo que é quente o suficiente para derreter pedregulhos. ";

    Console.WriteLine(observacao.Substring(11,10));
```
![img-8](Img/img-08.png)

## IsNullOrEmpty

O método **`` IsNullOrEmpty()``** verifica se uma string é nula ou vazia, essa funcionalidade é muito utilizada em validações de dados que dependem da interação com o usuário

```C#
    Console.WriteLine("==== IsNullOrEmpty ====");
    string nomeDoPokemon = "";

    if (String.IsNullOrEmpty(nomeDoPokemon))
        Console.WriteLine("O nome do Pokémon não pode ser nulo ou vazio");
```

![img-9](Img/img-09.png)

# Conclusão
Essas funções foram apenas algumas que estão disponíveis no C# e podem ser utilizadas e combinadas para limpar espaços em branco, obter a quantidade de caracteres, transformar tudo para maiúscula ou minúscula, trocar o conteúdo, enfim, facilitar o trabalho do desenvolvedor. Para conhecer mais métodos consulte a [documentação oficial](https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=net-6.0#methods).
