using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





   public class Ineventários
{
    public string pocao, bolsa, chapeu, carteira, celular, dinheiro, oitao, casaco, ak47, oculos;
    public Ineventários next = null;
    public Ineventários previous = null;
 

    public Ineventários(string pocao)
    {
        this.pocao = pocao;
    }
}

namespace Lista_Encadeada_Edilson_Matheus_Gustavo
{
    
    internal class Program
    {
       private static void Main(string[] args)
        {
            int posicao = 0;

            Ineventários pocao = new Ineventários("Vida");
            Ineventários bolsa = new Ineventários("Gucci");
            Ineventários chapeu = new Ineventários("Lambreta");
            Ineventários carteira = new Ineventários("couro");
            Ineventários celular = new Ineventários("roubado");
            Ineventários dinheiro = new Ineventários("tbm_roubado");
            Ineventários oitao = new Ineventários("carregado");
            Ineventários casaco = new Ineventários("GAP");
            Ineventários ak47 = new Ineventários("estraçalha_ladrao_que_nem_papel");
            Ineventários oculos = new Ineventários("rift");

            pocao.next = bolsa;
            bolsa.next = chapeu;
            chapeu.next = carteira;
            carteira.next = celular;
            celular.next = dinheiro;
            dinheiro.next = oitao;
            oitao.next = casaco;
            casaco.next = ak47;
            ak47.next = oculos;
            oculos.next = null;

            oculos.previous = ak47;
            ak47.previous = casaco;
            casaco.previous = oitao;
            oitao.previous = dinheiro;
            dinheiro.previous = celular;
            celular.previous = carteira;
            carteira.previous = chapeu;
            chapeu.previous = bolsa;
            bolsa.previous = pocao;
            pocao.previous = null;


            Ineventários element = pocao;

            

            Console.WriteLine("Insira um elemento de 1 a 10");
            int nome = Convert.ToInt32(Console.ReadLine());

            if (nome >= 11 || nome <= 0)
            {
                Console.WriteLine("Não existe");
            }

            while (element.next != null)
            {
                posicao += 1;
                //Console.WriteLine("item: " + element.pocao + " / Posição: " + posicao);

                if(nome == 10)
                {
                    Console.WriteLine("Item: " + element.oculos + " / Posição: " + posicao);
                }
                if (nome == posicao)
                {
                    Console.WriteLine("item: " + element.pocao + " / Posição: " + posicao);
                }
               


                element = element.next;
            }

         

            
            Console.ReadLine();
                

        }
    }
}
