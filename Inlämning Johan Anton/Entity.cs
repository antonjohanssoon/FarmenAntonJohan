using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm.anton.johan
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private static int NextId = 1;
        public Entity(string _name) 
        {
            Id = NextId++;
            Name = _name;
        }
        
        
        //Funktionen ger tillbaka information om entiteten(alltså en abstrakt-Klass)
        //Denna funktion skall overrideas vid alla olika entiteter och visa upp just den entitetens egenskaper.
        //Virtual tillåter att man overridear funktionen.

        public virtual string GetDescription()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
