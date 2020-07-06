using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class AlternativePopupWindow : MonoBehaviour
{
    [SerializeField]
    string textToShow;
    [SerializeField]
    TextMeshProUGUI labeltext;

    void Start()
    {
        labeltext.text = textToShow;
    }

    public void OpenPopup()
    {
        gameObject.SetActive(true);
    }
// test for git
}
