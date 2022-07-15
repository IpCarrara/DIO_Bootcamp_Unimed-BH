namespace Desafio_Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_sharp.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
                return this.Name + " lançou uma maldição MACABRA com bonus de ataque de " + Bonus;
            } else{
                return this.Name + " lançou um pequeno feitiço com bonus de ataque de " + Bonus;
            }
            
        }
    }
}