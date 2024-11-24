using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public StatCard statCard;

    void Start()
    {
        // Example: Load character stats
        int health = 100;
        int actionPoints = 10;
        int defense = 5;
        int speed = 20;

        // Update the stat card
        statCard.UpdateStats(health, actionPoints, defense, speed);
    }
}
