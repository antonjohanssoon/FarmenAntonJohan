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
        
        public Entity(int _id ,string _name) 
        {
            Id = _id;
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
