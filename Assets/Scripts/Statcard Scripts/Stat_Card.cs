using UnityEngine;
using TMPro; // If using TextMeshPro

public class StatCard : MonoBehaviour
{
    // References to UI Text elements
    public TMP_Text healthText;
    public TMP_Text actionPointsText;
    public TMP_Text defenseText;
    public TMP_Text speedText;

    // Stats
    private int health;
    private int actionPoints;
    private int defense;
    private int speed;

    // Method to update stats
    public void UpdateStats(int newHealth, int newActionPoints, int newDefense, int newSpeed)
    {
        health = newHealth;
        actionPoints = newActionPoints;
        defense = newDefense;
        speed = newSpeed;

        // Update UI
        healthText.text = "Health: " + health;
        actionPointsText.text = "Action Points: " + actionPoints;
        defenseText.text = "Defense: " + defense;
        speedText.text = "Speed: " + speed;
    }
}

