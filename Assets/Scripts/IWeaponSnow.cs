public interface IWeaponSnow : IAttackWhiteSnow, IAttackRedSnow, IAttackBlueSnow, IAttackGreySnow
{
}

public interface IAttackWhiteSnow
{
    public void AttackWhiteSnow();
}


public interface IAttackRedSnow
{
    public void AttackRedSnow();
}

public interface IAttackBlueSnow
{
    public void AttackBlueSnow();
}

public interface IAttackGreySnow
{
    public void AttackGreySnow();
}