using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip FireSound;
    static AudioSource AudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        FireSound = Resources.Load<AudioClip>("fire");
        AudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySounnd (string clip)
    {
        switch (clip)
        {
            case "fire":
                AudioSrc.PlayOneShot(FireSound);
                break;
        }
    }
}
