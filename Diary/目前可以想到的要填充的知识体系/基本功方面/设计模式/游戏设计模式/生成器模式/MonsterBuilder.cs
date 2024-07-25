namespace DesignPattern;

public class MonsterBuilder
{
    private Monster _monster;

    public MonsterSpawner BuildID(string id)
    {
        _monster.id = id;
        return this;
    }

    public MonsterSpawner BuildName(string name)
    {
        _monster.name = name;
        return this;
    }

    public MonsterSpawner BuildRace(string race)
    {
        _monster.race = race;
        return this;
    }

    public Monster GetMonster()
    {
        return _monster;
    }
    
    public static MonsterBuilder CreateMonster()
    {
        return new MonsterBuilder
        {
            _monster = new Monster();
        }
    }
}