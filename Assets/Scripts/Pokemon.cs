using UnityEngine;

public class Pokemon : MonoBehaviour
{
    private int health;
    private string type;
    private int actionPoints;
    private int attack;
    private int defense;
    private int speed;

    public Pokemon(string t)
    {
        type = t;

        //Example stats for each elemental type
        if (type == "Water")
        {
            health = 100;
            actionPoints = 4;
            attack = 15;
            defense = 5;
            speed = 20;
        }
        else if (type == "Fire")
        {
            health = 100;
            actionPoints = 4;
            attack = 10;
            defense = 4;
            speed = 15;
        }
        else if (type == "Earth")
        {
            health = 80;
            actionPoints = 4;
            attack = 5;
            defense = 6;
            speed = 25;
        }
        else if (type == "Air")
        {
            health = 50;
            actionPoints = 3;
            attack = 10;
            defense = 5;
            speed = 20;
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
}
