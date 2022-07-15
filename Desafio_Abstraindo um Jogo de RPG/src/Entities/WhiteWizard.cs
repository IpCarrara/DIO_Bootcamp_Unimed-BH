namespace Desafio_Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_sharp.src.Entities
{
    public class WhiteWizard : Wizard
    {
        public WhiteWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
                return this.Name + " lançou uma SUPER magia branca com bonus de ataque de " + Bonus;
            } else{
                return this.Name + " lançou uma magia branca fraca com bonus de ataque de " + Bonus;
            }
            
        }

    }
}