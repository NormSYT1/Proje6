using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuControl : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void StartSurvey()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Quit()
    {
        Application.Quit();
        print("Çýkýþ yapýldý");
    }
}
