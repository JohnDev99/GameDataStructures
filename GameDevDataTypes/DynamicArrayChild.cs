using Dependencies;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevDataTypes
{
    internal class DynamicArrayChild : DynamicArray
    {
        //Construtor desta classe herda da superClasse
        public DynamicArrayChild() : base()
        {
        }

        public override void Add(int item)
        {
            //Se o meu numero de elementos do array for igual ao da contagem, aumentar o array para poder adicionar novos elementos
            if (count == items.Length)
            {
                Expand();
            }

            //Adicionar o novo elemento ao espaço livre
            items[count] = item;
            count++;//Passar para o proximo espaço livre do array
        }

        public override int IndexOf(int item)
        {
            //i == quantidade de elementos do array
            for(int i = 0; i < count; i++)
            {
                //se o numero passado no argumento for igual a um dos elementos do array
                if (items[i] == item)
                {
                    return i;//Returna o numero de indice do elemento no array
                }
            }

            return -1;//Se nao retorna um valor negativo
        }

        public override bool Remove(int item)
        {
            int itemLocation = IndexOf(item);
            if (itemLocation == -1)
            {
                return false;
            }
            else
            {
                items[itemLocation] = items[count - 1];
                count--;
                return true;
            }
        }
    }
}
