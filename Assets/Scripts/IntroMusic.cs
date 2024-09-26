using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMusic : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource GhostNormal;
    // Start is called before the first frame update
    void Start()
    {
        intro.Play();
        GhostNormal.PlayDelayed(intro.clip.length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
