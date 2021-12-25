public abstract class PlayerCommand
{
    public abstract void Execute(IWeaponSnow weapon);
}

public class AttackWhiteSnow : PlayerCommand
{
    public override void Execute(IWeaponSnow weapon)
    {
        weapon.AttackWhiteSnow();
    }
}

public class AttackRedSnow : PlayerCommand
{
    public override void Execute(IWeaponSnow weapon)
    {
        weapon.AttackRedSnow();
    }
}

public class AttackBlueSnow : PlayerCommand
{
    public override void Execute(IWeaponSnow weapon)
    {
        weapon.AttackBlueSnow();
    }
}

public class AttackGreySnow : PlayerCommand
{
    public override void Execute(IWeaponSnow weapon)
    {
        weapon.AttackGreySnow();
    }
}

public abstract class MenuCommand
{
    public abstract void Execute(IUserInterface field);
}

public class ClickInMenuField : MenuCommand
{
    public override void Execute(IUserInterface filed)
    {
        filed.ClickAtField();
    }
}