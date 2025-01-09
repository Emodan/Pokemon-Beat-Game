using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Pokemon : MonoBehaviour
{
    private int health;
    private string type;
    private int actionPoints;
    private int attack;
    private int defense;
    private int speed;
    private List<Move> waterMoves = new List<Move>();
    private List<Move> fireMoves = new List<Move>();
    private List<Move> earthMoves = new List<Move>();
    private List<Move> airMoves = new List<Move>();

    public Pokemon(string t)
    {
        type = t;

        //Example (more moves to be added)
        if (type == "Water")
        {
            health = 100;
            actionPoints = 4;
            attack = 15;
            defense = 5;
            speed = 20;
            Move water = new Move("Water", "physical", 5, 80, 25);
            waterMoves.Append(water);
        }
        else if (type == "Fire")
        {
            health = 100;
            actionPoints = 4;
            attack = 10;
            defense = 4;
            speed = 15;
            Move fire = new Move("Fire", "physical", 4, 70, 20);
            fireMoves.Append(fire);
        }
        else if (type == "Earth")
        {
            health = 80;
            actionPoints = 4;
            attack = 5;
            defense = 6;
            speed = 25;
            Move earth = new Move("Earth", "special", 2, 10, 2);
            earthMoves.Append(earth);
        }
        else if (type == "Air")
        {
            health = 50;
            actionPoints = 3;
            attack = 10;
            defense = 5;
            speed = 20;
            Move air = new Move("Air", "physical", 5, 70, 35);
            airMoves.Append(air);
        }
    }

    public int getHealth()
    {
        return health;
    }

    public string getType() 
    {
        return type;
    }

    public int getActionPoints()
    {
        return actionPoints;
    }

    public int getAttack()
    {
        return attack;
    }

    public int getDefense()
    {
        return defense;
    }

    public int getSpeed()
    {
        return speed;
    }

    public Move getMove(string elementalType, string moveName)
    {
        if (elementalType == "Water")
        {
            for(int i = 0; i < waterMoves.Count; i++)
            {
                if (waterMoves[i].getName() == moveName)
                {
                    return waterMoves[i];
                }
            }
        }

        if (elementalType == "Fire")
        {
            for (int i = 0; i < fireMoves.Count; i++)
            {
                if (fireMoves[i].getName() == moveName)
                {
                    return fireMoves[i];
                }
            }
        }

        if (elementalType == "Earth")
        {
            for (int i = 0; i < earthMoves.Count; i++)
            {
                if (earthMoves[i].getName() == moveName)
                {
                    return earthMoves[i];
                }
            }
        }

        if (elementalType == "Air")
        {
            for (int i = 0; i < airMoves.Count; i++)
            {
                if (airMoves[i].getName() == moveName)
                {
                    return airMoves[i];
                }
            }
        }

        return null;
    }

    public void setHealth(int health)
    {
        this.health = health;
    }

    public void setType(string type) 
    {
        this.type = type;
    }

    public void setActionPoints(int actionPoints)
    {
        this.actionPoints = actionPoints;
    }

    public void setAttack(int attack)
    {
        this.attack = attack;
    }

    public void setDefense(int defense)
    {
        this.defense = defense;
    }

    public void setSpeed(int speed)
    {
        this.speed = speed;
    }

    public void updatePowerPoints(string elementalType, string moveName, int newPowerPoints)
    {
        if (elementalType == "Water")
        {
            for (int i = 0; i < waterMoves.Count; i++)
            {
                if (waterMoves[i].getName() == moveName)
                {
                    waterMoves[i].setPowerPoints(newPowerPoints);
                }
            }
        }

        if (elementalType == "Fire")
        {
            for (int i = 0; i < fireMoves.Count; i++)
            {
                if (fireMoves[i].getName() == moveName)
                {
                    fireMoves[i].setPowerPoints(newPowerPoints);
                }
            }
        }

        if (elementalType == "Earth")
        {
            for (int i = 0; i < earthMoves.Count; i++)
            {
                if (earthMoves[i].getName() == moveName)
                {
                    earthMoves[i].setPowerPoints(newPowerPoints);
                }
            }
        }

        if (elementalType == "Air")
        {
            for (int i = 0; i < airMoves.Count; i++)
            {
                if (airMoves[i].getName() == moveName)
                {
                    airMoves[i].setPowerPoints(newPowerPoints);
                }
            }
        }
    }
}