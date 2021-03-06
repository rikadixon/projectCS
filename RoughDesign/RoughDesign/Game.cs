﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughDesign
{
    public interface IFrendlyCharacter
    {

    }
    public interface IEnemyCharacter
    {

    }

    public class Charter
    {
        public string charterName { get; set; }
        public double xp { get; protected set; }
        public double mp { get; protected set; }
        public double maxXP { get; protected set; }
        public double maxMP { get; protected set; }
        public GameField.Point locacion { get; protected set; }
        public double speedOfRegenXP { get; protected set; }
        public double speedOfRegenMP { get; protected set; }
        public List<Abilities> listOfAbilities{ get; protected set; }
        void UseAbilitie(List<Charter> anotherUserCharters, int numberOfAbilitie)
        {
        }
        public void GoToAnotherCell(GameField.Point newLocacion)
        {

        }
        public Charter() { }
        public Charter(List<Abilities> listOfAbilitiesFromUser)
        {
            listOfAbilities = new List<Abilities>();
            listOfAbilities = listOfAbilitiesFromUser;
        }
    }

    public class FrendlyCharters:  IFrendlyCharacter
    {   
        public List<Charter> listOfFrends { get; protected set; }
        FrendlyCharters(List<Charter> listOfFrends)
        {
            listOfFrends = new List<Charter>();
            this.listOfFrends = listOfFrends;
        }
    }

    public class EnemyCharter:IEnemyCharacter
    {
        public List<Charter> listOfEnemis { get; protected set;}
        EnemyCharter(List<Charter> listOfEnemis)
        {
            listOfEnemis = new List<Charter>();
            this.listOfEnemis = listOfEnemis;
        }
    }

    interface IAbilitiesOnYourself
    {
        void Abilitie();
    }

    interface IAbilitiesAnotherCharter
    {
        void Abilitie(GameField.Point location);
    }
    interface IAbilitiesOnFrend
    {
        void Abilitie(GameField.Point location);
    }

    public abstract class Abilities
    {
        double mpCost;
       
    }

    public class FireBall : Abilities, IAbilitiesAnotherCharter
    {
        double xpDamage;
        Charter owner;
        public FireBall(Charter owner)
        {
            this.owner = owner;
        }

        public void Abilitie(GameField.Point location)
        {

        }
        
        
    }

    public class Lightning : Abilities, IAbilitiesAnotherCharter
    {
        double xpDamage;
        Charter owner;
        public Lightning(Charter owner)
        {
            this.owner = owner;

        }
        public void Abilitie(GameField.Point location)
        {

        }
    }

    public class WindFlow : Abilities, IAbilitiesAnotherCharter
    {
        double xpDamage;
        Charter owner;
        public WindFlow(Charter owner)
        {
            this.owner = owner;
            
        }

        public void Abilitie(GameField.Point location)
        {

        }
    }

    public class Healing : Abilities, IAbilitiesOnFrend
    {
        double xpRegen;
        Charter owner;
        public Healing(Charter owner)
        {
            this.owner = owner;
        }

        public void Abilitie(GameField.Point location)
        {

        }
    }
    public class Regeneration : Abilities, IAbilitiesOnYourself
    {   
        double xpRegen;
        double mpRegen;
        Charter owner;
        public Regeneration(Charter owner)
        {
            this.owner = owner;
        }
        public void Abilitie()
        {
        }
    }
    public class GameField
    {
        public struct Point
        {
            public int x;
            public int y;
            public Point(int X, int Y)
            {
                x = X;
                y = Y;
            }
        };
        public List<Charter> allCharters { get; protected set; }
        GameField(int row,int col)
        {

        }
       

    }
}
