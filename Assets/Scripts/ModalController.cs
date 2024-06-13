using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalController : MonoBehaviour
{
    [SerializeField]
    private GameObject modalPanel; // Reference to the ModalPanel GameObject

    [SerializeField]
    private GameReset gameResetController; // Reference to the GameResetController

    // Method to show the modal
    public void ShowModal()
    {
        if (modalPanel != null)
        {
            modalPanel.SetActive(true);
        }
    }

    // Method to hide the modal
    public void HideModal()
    {
        if (modalPanel != null)
        {
            modalPanel.SetActive(false);
        }
    }

    // Method to confirm reset
    public void ConfirmReset()
    {
        HideModal();
        gameResetController.ResetGame();
    }
}
