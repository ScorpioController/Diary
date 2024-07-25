namespace DesignPattern;

public class Monster
{
    public string id;
    public string name;
    public string race;

    // for external builder
    public Monster() {}

    // for config
    public Monster(MonsterConfig config)
    {
        id = config.id;
    }
    
    public static MonsterConfig WithConfig()
    {
        return new MonsterConfig();
    }

    public sealed class MonsterConfig
    {
        private string _id;
        private string _name;
        private string _race;
        
        public MonsterConfig BuildID(string id)
        {
            _id = id;
        }
        
        public MonsterConfig BuildName(string name)
        {
            _name = name;
        }
        
        public MonsterConfig BuildRace(string race)
        {
            _race = race;
        }

        public Monster Build()
        {
            return new Monster(this);
        }
    }
}