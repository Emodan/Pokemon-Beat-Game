using UnityEngine;

public class GameController : MonoBehaviour
{
    public StatCard statCard; // Reference to the StatCard script

    void Start()
    {
        // Set initial stats
        statCard.UpdateStats(100, 50, 20, 10);
    }

    void Update()
    {
        // Example: Press "Space" to update stats
        if (Input.GetKeyDown(KeyCode.Space))
        {
            statCard.UpdateStats(80, 40, 15, 12); // Change stats dynamically
        }
    }
}
