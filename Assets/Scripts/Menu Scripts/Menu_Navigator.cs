using UnityEngine;

public class MenuNavigator : MonoBehaviour
{
    public GameObject menuUp;    // Reference to the "Up" menu
    public GameObject menuRight; // Reference to the "Right" menu
    public GameObject menuDown;  // Reference to the "Down" menu
    public GameObject menuLeft;  // Reference to the "Left" menu

    private GameObject currentMenu; // The currently active menu

    void Start()
    {
        // Set the initial active menu
        currentMenu = menuUp;
        ActivateMenu(menuUp);
    }

    void Update()
    {
        // Handle input for menu navigation
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SwitchMenu(menuUp);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SwitchMenu(menuRight);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SwitchMenu(menuDown);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SwitchMenu(menuLeft);
        }
    }

    void SwitchMenu(GameObject newMenu)
    {
        if (newMenu != null && newMenu != currentMenu)
        {
            // Deactivate the current menu
            currentMenu.SetActive(false);

            // Activate the new menu
            currentMenu = newMenu;
            currentMenu.SetActive(true);
        }
    }

    void ActivateMenu(GameObject menu)
    {
        // Ensure only the specified menu is active
        menuUp.SetActive(false);
        menuRight.SetActive(false);
        menuDown.SetActive(false);
        menuLeft.SetActive(false);

        if (menu != null)
        {
            menu.SetActive(true);
        }
    }
}
