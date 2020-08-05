using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField]
    Button popupButton;
    [SerializeField]
    Button textButton;
    [SerializeField]
    Button soundButton;
    [SerializeField]
    GameObject popupGameObject;
    [SerializeField]
    GameObject textGameObject;
    [SerializeField]
    AudioSource audioSource;

    bool isTextVisible;

    private float textShowDuration = 3f;

    void Start()
    {
        //close aditional gameobjects at the start of game
        popupGameObject.SetActive(false);
        textGameObject.SetActive(false);

        isTextVisible = false;
    }

    public void OnPopupButtonClicked()
    {
        popupGameObject.SetActive(true);
    }

    public void OnTextButtonClicked()
    {
        if (!isTextVisible)
        {
            StartCoroutine(ShowTextCoroutine());
        }
    }

    public void OnSoundButtonClicked()
    {
        audioSource.Play();
    }

    private IEnumerator ShowTextCoroutine()
    {
        textGameObject.SetActive(true);
        isTextVisible = true;
        yield return new WaitForSecondsRealtime(textShowDuration);
        textGameObject.SetActive(false);
        isTextVisible = false;
    }
}
