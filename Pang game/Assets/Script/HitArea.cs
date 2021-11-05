using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            AudioManger.instance.SetEffect(1);
            GameManger.instance.OnHitPlayer();
        }
    }
}
