using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
using RoleplayGame.Scenarios;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Program
{
    /// <summary>
    /// Este escenario permite crear personajes, items y encuentros
    /// desde la terminal en forma dinámica.
    /// </summary>
    public class ClassRoomScenario: IScenario
    {
        /// <summary>
        /// Los personajes creados
        /// </summary>
        /// <typeparam name="Character"></typeparam>
        /// <returns></returns>
        protected List<Character> characters = new List<Character>();

        /// <summary>
        /// Código de inicialización del escenario.
        /// </summary>
        public virtual void Setup()
        {
            this.BuildCharacters();
        }

        /// <summary>
        /// Código de ejecución del escenario.
        /// </summary>
        public virtual void Run()
        {
            this.RunEncounters();
        }

        /// <summary>
        /// Ejecución de un encuentro. Se construye de forma
        /// dinámica mediante interacción con el usuario.
        /// </summary>
        protected virtual void RunEncounters()
        {
            Encounter encounter = this.BuildEncounter();
            while (encounter != null)
            {
                encounter.DoEncounter();
                this.RemoveDeadCharacters();
                encounter = this.BuildEncounter();
                if(this.characters.Count==1){
                    Console.WriteLine(this.characters[0].Name + " is victorious of the Tierra Media.");
                }
            }
        }

        /// <summary>
        /// Construcción de un encuentro mediante entrada por la
        /// terminal.
        /// 
        /// Si quedan menos de dos personajes, la función retorna null.
        /// Si la entrada es vacía se retorna null.
        /// </summary>
        /// <returns>El encuentro creado</returns>
        protected virtual Encounter BuildEncounter()
        {
            if (this.LessThanTwoCharactersLeft)
            {
                return null;
            }

            Character character1 = this.characters[0];
            Character character2 = this.characters[1];
            Encounter encounter = EncounterFactory.GetEncounter(EncounterType.Attack, character1, character2);
            
            encounter.Reporter = new ConsoleReporter();
            
            return encounter;
        }

        protected bool LessThanTwoCharactersLeft
        {
            get
            {
                return characters.Count < 2;
            }
        }

        /// <summary>
        /// Construcción de los personajes mediante interacción por
        /// la terminal.
        /// 
        /// La función termina cuando la entrada de usuario es vacía.
        /// </summary>
        protected virtual void BuildCharacters()
        {
            List<IItem> items = new List<IItem>();
            Character character = CharacterFactory.GetCharacter(CharacterType.Elf, "niko");
            Array values = Enum.GetValues(typeof(ItemType));
            Random random = new Random();
            IItem item = ItemFactory.GetItem((ItemType)values.GetValue(random.Next(values.Length)));
            items.Add(item);
            random = new Random();
            item = ItemFactory.GetItem((ItemType)values.GetValue(random.Next(values.Length)));
            items.Add(item);
            character.AddItems(items);
            this.characters.Add(character);

            character = CharacterFactory.GetCharacter(CharacterType.Wizard, "pedro");
            random = new Random();
            item = ItemFactory.GetItem((ItemType)values.GetValue(random.Next(values.Length)));
            items.Add(item);
            random = new Random();
            item = ItemFactory.GetItem((ItemType)values.GetValue(random.Next(values.Length)));
            items.Add(item);
            character.AddItems(items);
            this.characters.Add(character);

            character = CharacterFactory.GetCharacter(CharacterType.Troll, "guillermo");
            random = new Random();
            item = ItemFactory.GetItem((ItemType)values.GetValue(random.Next(values.Length)));
            items.Add(item);
            random = new Random();
            item = ItemFactory.GetItem((ItemType)values.GetValue(random.Next(values.Length)));
            items.Add(item);
            character.AddItems(items);
            this.characters.Add(character);
        }

        /// <summary>
        /// Quita personajes muertos (vida = 0) de la lista de personajes.
        /// </summary>
        private void RemoveDeadCharacters()
        {
            List<Character> dead = new List<Character>();
            foreach(Character character in this.characters)
            {
                if (character.IsDead)
                {
                    dead.Add(character);
                }
            }
            foreach (Character deadCharacter in dead)
            {
                this.characters.Remove(deadCharacter);
            }
        }

    }
}