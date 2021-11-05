using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger instance;

    public int hp = 4;

    public int points = 0;

    private float onHitDelay = 3, onHitDelaySave,blink=0.05f, blinkSave;

    private bool onHit = false;

    public UIManger uIManger;


    private SpriteRenderer playerSprit;

    

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            onHitDelaySave = onHitDelay;
            blinkSave = blink;
            AudioManger.instance.SetBgSound(1);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (onHit)
        {
            if (onHitDelay<=0)
            {
                playerSprit.enabled = true;
                onHit = false;
                onHitDelay = onHitDelaySave;
            }
            else
            {
                onHitDelay -= Time.deltaTime;
                if (blink<=0)
                {
                    blink = blinkSave;
                    playerSprit.enabled = false;
                }
                else
                {
                    blink -= Time.deltaTime;
                    playerSprit.enabled = true;
                }
            }
        }
    }


    public void OnHitPlayer()
    {
        if (!onHit)
        {
            onHit = true;
            if (hp-1!=-1)
            {
                hp--;
            }
            else
            {
                DestroyManger();
                Application.LoadLevel("Main");
            }


            uIManger.SetHp(hp);
        }
        
    }

    public void AddPoint()
    {
        points++;
        uIManger.SetPoint(points);
    }

    public void SetPlayerSpriteRenderer(SpriteRenderer playerSpritUse)
    {
        playerSprit = playerSpritUse;
    }

    public void DestroyManger()
    {
        Destroy(gameObject);
    }
}
