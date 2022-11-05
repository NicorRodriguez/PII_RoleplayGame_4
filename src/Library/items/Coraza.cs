namespace RoleplayGame.Items
{
    /// <summary>
    /// Permite defender.
    /// </summary>
    public class Coraza : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}