using System;

namespace aula04
{
    class Program
    {   static int num = 10; //Essa variavel é considera global, isso porque todos seus metodos podem utilizar desde que sejam do mesmo tipo
    //se ela static, public e etc....
        static void Main(string[] args)
        {
            //Nesta aula vamos entender um pouco do escopo da variavel
            int num1 = 0;
            Console.WriteLine(num);
            Console.WriteLine(num1);
            //Pegamos como exemplo a variavel acima e vamos tentar printrar em outro escopo
            
            /*void testes (){
            Console.WriteLine(num1);
        }*/
            //Neste caso a variavel não pode ser mostrada já que ela esta gravada no escopo do metodo principal
            //Logo aparecerá um erro no terminal... E para consertar  este erro temos que declarar a variavel dentro
            //do escopo 
            /*void testes (){
                int num1 = 0;
            Console.WriteLine(num1);
        }*/
        }
        
    }
}
