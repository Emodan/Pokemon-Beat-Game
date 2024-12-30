using UnityEngine;

public class MoveHandler : MonoBehaviour
{
    private int baseDamage;

    public int calcDamage(int power, Pokemon attacker, Pokemon defender)
    {
        baseDamage = power * (attacker.getAttack() / defender.getDefense());
        return baseDamage;
    }
}
