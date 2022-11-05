namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Baston : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public virtual int AttackPower
        {
            get
            {
                return 40;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public virtual int DefensePower
        {
            get
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Baston";
        }
    }
}