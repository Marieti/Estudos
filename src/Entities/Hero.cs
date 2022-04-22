namespace POO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType){
        this.Name = Name;
        this.Level = Level;
        this.Herotype = HeroType;
    } 
    public Hero (){

    }
        public string Name;
        public int Level;
        public string Herotype;

        public override string ToString(){
            return this.Name +" "+ this.Level+" " + this.Herotype;
            
        }
        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

    }
}