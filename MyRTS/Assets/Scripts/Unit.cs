﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

 namespace GadeAssignment1
{
    abstract class Unit
    {

        // Properties
        protected int x;
        protected int y;
        protected int health;
        protected int speed;
        protected bool attack;
        protected int attackRange;
        protected string faction;
        protected string symbol;
        protected string name;

        // Constructor
        public Unit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol, string name)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
            this.name = name;
        }

        // Destructor
        ~Unit()
        {
        }

        // Accessors

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void move(int x, int y);
        public abstract void combat(Unit enemy);
        public abstract bool isInRange(Unit enemy);
        public abstract Unit nearestUnit(List<Unit> u);
        public abstract bool isAlive();
        public abstract string toString();
        public abstract void save();
    }
} 
