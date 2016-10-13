using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughDesign
{
   public class Charter
    {
        public string charterName { get; set; }
        public double xp { get; protected set; }
        public double mp { get; protected set; }
        public double maxXP { get; protected set; }
        public double maxMP { get; protected set; }
        public double speedOfRegenXP { get; protected set; }
        public double speedOfRegenMP { get; protected set; }
        public List<Abilities> listOfAbilities{ get; protected set; }
        void UseAbilitie(Charter userCharterr,int numberOfAbilitie)
        {
        }
    }
    public abstract class Abilities 
    {
       public virtual void Abilitie(Charter userCharter) { }
    }
    public class FireBall: Abilities
    {
        double xpDamage;
        double mpCost;
        readonly bool useOnYourself = false;
        readonly bool useOnAnotherCharter = true;
        public override void Abilitie(Charter userCharter)
        {
        }
    }
    public class Lightning : Abilities
    {
        double xpDamage;
        double mpCost;
        readonly bool useOnYourself = false;
        readonly bool useOnAnotherCharter = true;
        public override void Abilitie(Charter userCharter)
        {
        }
    }
    public class WindFlow : Abilities
    {
        double xpDamage;
        double mpCost;
        readonly bool useOnYourself = false;
        readonly bool useOnAnotherCharter = true;
        public override void Abilitie(Charter userCharter)
        {
        }
    }
    public class Regeneration : Abilities
    {
        double xpRegen;
        double mpRegen;
        readonly bool useOnYourself = true;
        readonly bool useOnAnotherCharter = false;
        public override void Abilitie(Charter userCharter)
        {
        }
    }
}
