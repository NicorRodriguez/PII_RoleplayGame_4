namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Clothes = 3,
        Coraza = 4,
        Baston = 5,
        BastonMagico = 6,
        GuantePoder = 7,
        Gema = 8,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Clothes: return new Clothes();
                case ItemType.Coraza: return new Coraza();
                case ItemType.Baston: return new Baston();
                case ItemType.BastonMagico: return new BastonMagico();
                case ItemType.GuantePoder: return new GuantePoder();
                case ItemType.Gema: return new Gema();

                default: return null;
            }
        }
    }
}