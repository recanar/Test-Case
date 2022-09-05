using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    private bool isCloseButton;
    [SerializeField] private GameObject nextLevelPanel;

    private void Update()
    {
        CheckButtonClick();//check if clicked next level button while player close to button
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCloseButton = true;
            nextLevelPanel.SetActive(true);
        }
    }//button clickable
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCloseButton = false;
            nextLevelPanel.SetActive(false);
        }
    }//can't click

    private void CheckButtonClick()
    {
        if (isCloseButton&& Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(2);
        }
    }
}
