using UnityEngine;
using TMPro; // If using TextMeshPro

public class StatCard : MonoBehaviour
{
    // References to UI Text elements
    public TMP_Text healthText;
    public TMP_Text actionPointsText;
    public TMP_Text attackText;
    public TMP_Text specialattackText;
    public TMP_Text defenseText;
    public TMP_Text SpecialDefText;
    public TMP_Text speedText;

    // Stats
    private int health;
    private int actionPoints;
    private int defense;
    private int specialDefence
    private int speed;
    private int attackStat
    private int specialStat

    // Method to update stats
    public void UpdateStats(int newHealth, int newActionPoints, int newAttackState, int newSpecialAttackStat, int newSpecialDefence, int newDefense, int newSpeed)
    {
        health = newHealth;
        actionPoints = newActionPoints;

        attackStat = newAttackState;
        specialStat = newSpecialAttackStat;
        specialDefence = newSpecialDefence;
        defense = newDefense;
        speed = newSpeed;

        // Update UI
        healthText.text = "Health: " + health;
        actionPointsText.text = "Action Points: " + actionPoints;

        attackText.text = "Attack: " + attackStat;
        specialattackText.text = "Special ATK: " + specialStat;
        specialDefence.text = "Special DEF: " + specialDefence;
        defenseText.text = "Defense: " + defense;
        speedText.text = "Speed: " + speed;
    }
}

