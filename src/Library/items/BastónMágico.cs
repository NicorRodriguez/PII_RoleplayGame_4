namespace RoleplayGame.Items
{
/// <summary>
/// Magia. Permite atacar y defender.
/// </summary>

public class BastonMagico : Baston
{
/// <summary>
/// Atributo para utilizar composición
/// </summary>
/// <value></value>
public Magic Magic;
/// <summary>
/// Llamo al constructor y compongo BastonMagico, con composición
/// </summary>
/// <value></value>
public BastonMagico()
{
this.Magic = new Magic();
}
/// <summary>
/// override sobre el método padre y sumo los ataques
/// </summary>
/// <value></value>

public override int AttackPower
{
    get { 
        return base.AttackPower + Magic.AttackPower;
        }
}

/// <summary>
/// override sobre el método padre y sumo las defensas
/// </summary>
/// <value></value>
public override int DefensePower
{
    get
    {
        return base.AttackPower + Magic.AttackPower;
    }
}
}
}
