# Funções de strings

O C# disponibiliza algumas métodos para manipular strings, funcionalidades comuns que facilitam a vida do desenvolvedor. Nesse artigo vamos conhecer algumas destas funcionalidades.

## Trim

Esse método remove todos os espaçoes em branco do **início** e do **final** de uma string, caso exista espaço em branco no meio da string o ``Trim()`` não remove esses casos.
O método ``Trim()`` é muito utilizado quando recebemos uma string de alguma fonte de dados que não conseguimos garantir sua formatação, como dados de arquivos de texto, arquivos CSV ou arquivos Excel.

```C#
    var  observacao = " Charizard cospe fogo que é quente o suficiente para derreter pedregulhos. ";

    Console.WriteLine($"Observação com espaço: {observacao}");
    Console.WriteLine($"Observação sem espaço: {observacao.Trim()}");
```

![img-01](Img\img-01.png)

## Length

Quando queremos saber o tamanho de uma string utilizamos ``Length`` que retorna a quantidade de caracteres a string possui incluindo os espaços em branco em toda a expressão.
``Length`` é utilizado por exemplo para validar quantos caracteres foram digitados por um usuário, pode tambem ajudar na hora de obter uma parte especifica de uma string.

```C#
    var nome = "Charizard";

    Console.WriteLine(&"O nome {nome}, tem {nome.Length} caracteres.");
```

![img-02](Img\img-02.png)

## ToUpper

Podemos utilizar ``ToUpper()`` para transformar todos os caracteres de uma string em letras maiúsculas. Pode ser aplicado quando precisamos de uma formatação específica, ou para não diferenciar palavras com letras maiusculas e minusculas transformando todas em maiusculas e comparando.

```C#
    var tipo = "fogo";

    Console.WriteLine($"Charizard é um pokémon do tipo: {tipo.ToUpper()}");
```

![img-03](Img\img-03.png)

## ToLower

O método ToLower faz exatamente o contrário do ToUpper, transforma todos os caracteres de uma string em letras minúsculas.

```C#
    var tipoSecundario = "VOADOR";

    Console.WriteLine($"Charizard é um pokémon do tipo: {tipoSecundario.ToLower()}");
```

![img-04](Img\img-04.png)

## Remove

O método ``Remove()`` é utilizado para obter parte de uma string considerando apenas os caracteres à esquerda de uma expressão. Podemos utilizar para remover partes que não são necessárias em uma string, é necessário informar quantos caracteres serão considerados.

```C#
    var nome = "Charizard";

    Console.WriteLine($"Eu chamo meu {nome} de {nome.Remove(5)}.");
```

![img-5](Img/img-05.png)

## Replace

O metódo ``Replace()`` é utilizado para substituir expressões de uma string, é necessário informar o texto a ser substituido, e o novo texto. Pode ser utilizado quando há a necessidade de subistituir expressões para um valor padrão, ou que faça sentido para contexto do seu sistema/apicação.

```C#
    var  observacao = " Charizard cospe fogo que é quente o suficiente para derreter pedregulhos. ";

    Console.WriteLine(observacao.Replace("Charizard", "Meu Pokémon"));
```

![img-6](Img/img-06.png)

## Split

## Substring

## IsNullOrEmpty