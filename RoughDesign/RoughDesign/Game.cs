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
    interface IAbilitiesOnYourself
    {
        void Abilitie(Charter userCharter);
    }
    interface IAbilitiesAnotherCharter
    {
        void Abilitie(Charter mainUserCharter, Charter anotherUserCharter);
    }

    public abstract class Abilities
    {
        double mpCost;
    }
    public class FireBall : Abilities, IAbilitiesAnotherCharter
    {
        double xpDamage;
        public void Abilitie(Charter mainUserCharter, Charter anotherUserCharter)
        {
        }
    }
    public class Lightning : Abilities, IAbilitiesAnotherCharter
    {
        double xpDamage;
        public void Abilitie(Charter userCharter, Charter anotherUserCharter)
        {
        }
    }
    public class WindFlow : Abilities, IAbilitiesAnotherCharter
    {
        double xpDamage;
        public  void Abilitie(Charter userCharter, Charter anotherUserCharter)
        {
        }
    }
    public class Regeneration : Abilities, IAbilitiesOnYourself
    {   
        double xpRegen;
        double mpRegen;
        public void Abilitie(Charter userCharter)
        {
        }
    }
}
