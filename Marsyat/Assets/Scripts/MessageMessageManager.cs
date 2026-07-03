using System;
using UnityEngine;
using UnityEngine.UI;

public class MessageMessageManager : MonoBehaviour
{
    public static MessageMessageManager Instance;

    public Image displayImage;   // the one Image on screen
    public Sprite[] messages;    // your array of sprites

    void Awake()
    {
        displayImage.sprite = messages[0];
        Instance = this;
    }

    public void ShowMessage(int index)
    {
        displayImage.sprite = messages[index];
    }
}