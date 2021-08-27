using System;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis e seus tipos

        //tipo da Variavel     //nome da variavel        //valor recebido da Variavel
            string                     nome             =          "Wellington" ;
            int                        num              =           31;
            float                      valor            =           5.3f;
            char                       letra            =           'w';
            bool                       sera             =           true;

            var                        auxiliar         =           nome;

            // A liguagem C# é fortemente tipada exigindo na declaração o seu tipo, nome (variavel) e valor recebido...

            /*int representa o tipo inteiro
            float são numeros flutuantes, aqueles que recebem numeros após a virgula
            bool são as condições de true(verdadeiro) ou false(falso)... exemplo amarelo é cor primaria = true;
            char recebe apenas um caracter 'a' ou '8' ou '#' e etc..
            string é uma cadeia de caracteres ou seja se você utilizar mais que um caracter utilize o tipo string;

            Existem muitos tipos de variaveis deixo aqui uma breve leitura na documentação para o conhecimento
            https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/
            */

            // podemos declara tambem um tipo de variavel VAR no qual recebe o tipo após a compilação
            // ou seja o proprio programa identifica o tipo da variavel na hora da execução.
            // O sinal de = significa que a variavel esta recebendo um valor.

            // Para mostrar para o sistema a variavel usamos o metodo Console.Write (); Exemplo abaixo
            //Colocamos dentro do () o nome da variavel

            Console.WriteLine(nome);
            Console.WriteLine(num);
            Console.WriteLine(valor);
            Console.WriteLine(letra);
            Console.WriteLine(sera);
            Console.WriteLine(auxiliar);

            //Podemos tambem usar conctenação mas o que é isso?
            //Cocatenar no dicionario significa: ligar(-se), juntar(-se) numa cadeia ou sequência lógica ou orgânica.
            // vamos ver na pratica como funciona:

            Console.WriteLine("Eu sou " + nome + "tenho " + num + "anos de idade");

            //Percebe que podemos usar um tipo string dentro do metodo console sem precisar declarar
            //precisamos apenas colocar os " " (aspas duplas) para que o programa entenda.
            // o sinal de mais (+) representa junção e sinal o que ja conhecemos que é a soma
            //ou seja e esta juntando tudo e ao ser executado voce vera o resultado

            //Eu sou Wellington e tenho 31 anos de idade

            Console.WriteLine("Essa afirmação está correta? " + sera);

        }
    }
}
