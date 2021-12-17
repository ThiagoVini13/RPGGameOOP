namespace ConsoleApplicationVSCode.scr.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
        }

        public override string Attack() //Polimorfismo
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " Lançou uma Magia Super Efetiva com Bônus de Ataque de " + Bonus;
            } else {
                return this.Name + " Lançou uma Magia com Força Fraca com Bônus de " + Bonus;
            }
        }
    }
}