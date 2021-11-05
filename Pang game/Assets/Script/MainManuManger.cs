using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManuManger : MonoBehaviour
{

    private void Start()
    {
        AudioManger.instance.SetBgSound(0);
    }
    public void GoToMainGame()
    {
        Application.LoadLevel("lvl1");
    }
}
