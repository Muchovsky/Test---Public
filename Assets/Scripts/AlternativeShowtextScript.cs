using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeShowtextScript : MonoBehaviour
{
    Animator thisAnimator;
    void Start()
    {
        thisAnimator = GetComponent<Animator>();
    }

    public void OnButtonClicked()
    {
        thisAnimator.SetBool("Clicked", true);
    }

}
