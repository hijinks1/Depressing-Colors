using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Camera mainCamera;
    public Color newColor;
    public TextMeshProUGUI buttonText;
    public Color newTextColor;
    
   //make it so when button is pressed, everything goes grayscale before fading into gameplay
    
    public void ChangeBG()
    {
        mainCamera.backgroundColor = newColor;
    }

    public void NewText()
    {
        buttonText.color = Color.gray;
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Game");
    }
}
