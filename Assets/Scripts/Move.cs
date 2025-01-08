using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private string name;
    private string category;
    private int basePower;
    private int accuracy;
    private int powerPoints;

    public Move(string name, string category, int basePower, int accuracy, int powerPoints)
    {
        this.name = name;
        this.category = category;
        this.basePower = basePower;
        this.accuracy = accuracy;
        this.powerPoints = powerPoints;
    }

    public string getName()
    {
        return name;
    }

    public string getCategory()
    {
        return category;
    }

    public int getBasePower()
    {
        return basePower;
    }

    public int getAccuracy()
    {
        return accuracy;
    }

    public int getPowerPoints()
    {
        return powerPoints;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setCategory(string category)
    {
        this.category = category;
    }

    public void setBasePower(int basePower)
    {
        this.basePower = basePower;
    }

    public void setAccuracy(int accuracy)
    {
        this.accuracy = accuracy;
    }

    public void setPowerPoints(int powerPoints)
    {
        this.powerPoints = powerPoints;
    }
}
