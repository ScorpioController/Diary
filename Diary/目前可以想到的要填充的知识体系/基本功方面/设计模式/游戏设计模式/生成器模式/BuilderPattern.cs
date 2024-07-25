namespace DesignPattern;

public class BuilderPattern
{
    public void BuildMonster()
    {
        // 1
        var monster1 = MonsterBuilder.CreateMonster()
            .BuildID("1")
            .BuildName("monster 1")
            .BuildRace("")
            .GetMonster();
        
        // 2
        var monster = Monster.WithConfig()
            .BuildID("2")
            .BuildName("monster 2")
            .BuildRace("")
            .Build();
    }
}