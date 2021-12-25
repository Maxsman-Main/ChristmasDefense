public interface IPlayer : IScore, IHealth
{
    
}
public interface IScore
{
    public void TakeScorePoints(int points);
}

public interface IHealth
{
    public void TakeDamage(int damage);
}
