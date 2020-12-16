using System;
using System.Collections.Generic;
using ListaObjetos.classes;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone Asus", 2522.87f));
            produtos.Add(new Produto(4, "Sansung", 2522.87f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.87f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.45f;

            produtos.Add(iphone);

            foreach (Produto item in produtos){
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }

            produtos.RemoveAt(3);

            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista alterada");

            foreach (Produto item in produtos){
                Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
            }
        }
    }
}
