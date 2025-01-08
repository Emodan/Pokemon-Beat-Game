using UnityEngine;
using System;

public class MoveHandler : MonoBehaviour
{
    private int baseDamage;

    public int calcDamage(Move move, Pokemon attacker, Pokemon defender)
    {
        System.Random rand = new System.Random();
        int randNum = rand.Next(1, 101);

        if(randNum <= move.getAccuracy()) //The move is successful
        {
            baseDamage = move.getBasePower() * (attacker.getAttack() / defender.getDefense());
        }
        else //The move is unsuccessful
        {
            baseDamage = 0;
        }

        //Decrement power points for the attacker for the move used
        int newPowerPoints = attacker.getMove(attacker.getType(), move.getName()).getPowerPoints();
        attacker.updatePowerPoints(attacker.getType(), move.getName(), newPowerPoints);
        
        return baseDamage;
    }
}
