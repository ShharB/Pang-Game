using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{

    public static AudioManger instance;

    [SerializeField]
    private AudioSource bgSound;

    [SerializeField]
    private AudioSource soundEffect;

    [SerializeField]
    private AudioClip[] audioBgClips;

    [SerializeField]
    private AudioClip[] audioEffectClips;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetBgSound(int index)
    {
        bgSound.clip = audioBgClips[index];
        bgSound.Play();
    }

    public void SetEffect(int index)
    {
        soundEffect.PlayOneShot(audioEffectClips[index]);
    }


}
