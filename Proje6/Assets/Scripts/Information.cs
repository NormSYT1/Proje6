using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Information : MonoBehaviour
{
    public GameObject panel;
    public TMP_InputField name, surname;
    public Slider slider;
    public Toggle toggle;
    public TMP_Dropdown dropdown;
    public TMP_Text text1, text2, text3, text4, text5;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void FinishSurvey()
    {
        panel.SetActive(true);
        text1.text = name.text;
        text2.text = surname.text;
        if (dropdown.value == 0)
        {
            text3.text = "Erkek";
        }
        else
        {
            text3.text = "K�z";
        }
        if (toggle.isOn)
        {
            text4.text = "18 Ya� �st�";
        }
        else
        {
            text4.text = "18 Ya� Alt�";
        }
        text5.text = slider.value.ToString();
    }
    public void QuitSurvey()
    {
        SceneManager.LoadScene(0);
    }
}
