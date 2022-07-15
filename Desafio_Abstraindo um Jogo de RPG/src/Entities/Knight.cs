namespace Desafio_Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_sharp.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " atacou com sua espada";
        }
    }
}