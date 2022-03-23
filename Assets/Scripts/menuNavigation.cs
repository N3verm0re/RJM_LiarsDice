using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuNavigation : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject[] menuPanels;
    private GameObject currentActivePanel;

    private void Awake()
    {
        startPanel.SetActive(true);
        currentActivePanel = startPanel;
        foreach (GameObject panel in menuPanels)
        {
            panel.SetActive(false);
        }
    }

    public void SetActivePanel(GameObject panel)
    {
        currentActivePanel.SetActive(false);
        panel.SetActive(true);
        currentActivePanel = panel;
    }

    public void ExitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
