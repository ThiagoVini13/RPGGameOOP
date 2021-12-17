namespace ConsoleApplicationVSCode.scr.entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
        }
        public string Name = null!;
        public int Level;
        public string HeroType = null!;
        
        public Hero()
        {
            
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}