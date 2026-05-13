using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Personagem
    {
        // criar as propriedades da classe automovel
        public string Nome { get; set; }
        public string Jogos { get; set; }
        public string Idade { get; set; }
        public virtual string Imagem()
        {

            return @"../../img1/re.jpg";
        }
    }

    class Joel : Personagem
    {
        public Joel()
        {
            Nome = "Joel";
            Jogos = "TLOU1, TLOU2";
            Idade = "50";
        }

        public override string Imagem()
        {
            return @"""C:\Users\LabInfo\Downloads\DS_2bi-main\POO\img1\joel.jpg""";
        }
    }
    class Ellie : Personagem
    {
        public Ellie()
        {
            Nome = "Ellie Williams";
            Jogos = "TLOU1, TLOU2";
            Idade = "18";
        }
        public override string Imagem()
        {
            return @"C:\Users\LabInfo\Downloads\oiki-main\oiki-main\DS_2bi-main\POO\img1\ellie.jpg";
        }
    }
    class Dina : Personagem
    {
        public Dina()
        {
            Nome = "Dina";
            Jogos = "TLOU2";
            Idade = "18";
        }
        public override string Imagem()
        {
            return @"C:\Users\LabInfo\Downloads\oiki-main\oiki-main\DS_2bi-main\POO\img1\dina.jpg";
        }
    }
    class Abby : Personagem
    {
        public Abby()
        {
            Nome = "Abby";
            Jogos = "TLOU 2";
            Idade = "18";
        }
        public override string Imagem()
        {
            return "C:\Users\LabInfo\Downloads\oiki-main\oiki-main\DS_2bi-main\POO\img1\abby.jpg"
        }
    }
    class Lev : Personagem
    {
        public Lev()
        {
            Nome = "Lev";
            Jogos = "TLOU 2";
            Idade = "14";
        }
        public override string Imagem()
        {
            return "C:\Users\LabInfo\Downloads\oiki-main\oiki-main\DS_2bi-main\POO\img1\lev.jpg";
        }
    }

}