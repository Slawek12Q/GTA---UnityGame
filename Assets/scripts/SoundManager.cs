using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;

    public AudioClip gunFire;

    private AudioSource soundEffectAudio;
	// Use this for initialization
	void Start ()
    {
		if(Instance==null)
        {
            Instance=this;
        }
        else if(Instance!=this)
        {
            Destroy(gameObject);
        }
        soundEffectAudio=GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void PlayOneShot(AudioClip clip)
    {
        soundEffectAudio.PlayOneShot(clip);
    }
}
