namespace RoleplayGame.Items
{
    /// <summary>
    ///  Permite atacar y dañar enemigos
    /// </summary>
    public class BowAndArrow : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
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
        public int DefensePower
        {
            get
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Bow and Arrow";
        }
    }
}