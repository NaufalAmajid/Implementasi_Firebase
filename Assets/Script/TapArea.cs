using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

 

public class TapArea : MonoBehaviour, IPointerDownHandler
{   
    //SOUND EFFECT
    public AudioSource myFX;
    public AudioClip click;

    //VOID CLICKSOUND
    public void ClickSound()
    {

        myFX.PlayOneShot(click);
    }

    //VOID ONPOINTERDOWN
    public void OnPointerDown (PointerEventData eventData)
    {

        GameManager.Instance.CollectByTap (eventData.position, transform);

    }

}   
