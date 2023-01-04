using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencies
{
    abstract class DynamicArray
    {
        //Variavel constante, o tamanho do array vai ser dobrado sempre que necessario
        const int ExpandFactor = 2;
        //Array nulo, cria um endereço no heap
        protected int[] items;
        //Quantidade de elementos no meu array
        protected int count;


        //Construtor
        protected DynamicArray()
        {
            //Reservar previamente um espaço na memoria para guardar 4 numeros inteiros
            items = new int[4];
            //Iniciar contagem
            count = 0;
        }

        //Propriedade para returnar a minha contagem de numero de elementos
        public int Count
        {
            get { return count; }
        }

        //Metodos que cada classe vai implementar, cada um da sua maneira
        public abstract void Add(int item);
        public abstract bool Remove(int item);
        public abstract int IndexOf(int item);

        //Todos os elementos do array passam a ser invalidos
        public void Clear()
        {
            count = 0;
        }

        //Apresentar cada elemento do array em string
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                str.Append(items[i]);
                //Passar uma virgula para separar cada numero
                if (i < count - 1)
                {
                    str.Append(",");

                }
            }

            return str.ToString();
        }

        protected void Expand()
        {
            //Novo array do tamanho resultante entre a mutiplicaçao de dois numeros inteiros(* 2)
            int[] newItems = new int[items.Length * ExpandFactor];

            //Copiar tudo para este novo array, cada elemento na mesma posiçao
            for(int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            //Passo a apontar para o novo endereço
            items = newItems;

        }

    }
}
