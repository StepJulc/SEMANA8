using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject skinsPanel;
    private bool inDoor = false; 
    public GameObject player;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    public void OnTriggerExit(Collider collison)
    {
        skinsPanel.gameObject.SetActive(false);
        inDoor = false;
    }

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected","Frog");
        ResetPlayerSkin();
    }
    public void SetPlayerNinja()
    {
        PlayerPrefs.SetString("PlayerSelected","Ninja");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
    
}
