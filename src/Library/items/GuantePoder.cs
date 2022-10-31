
using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class GuantePoder : IAttackItem, IDefenseItem
    {
        private int TotalDamage = 0;
        private List<Gema> gemas = new List<Gema>();
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return TotalDamage;
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

        public void AddGema(Gema myGema){
            this.TotalDamage+=10;
            this.gemas.Add(myGema);
        }

        public override string ToString()
        {
            return "Guante de Poder";
        }
    }
}