using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    //bool act = true;
    public AudioClip boton;
    public Light light;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Input.GetMouseButtonDown(0) && light.enabled == true)
            {
                audioSource.PlayOneShot(boton);
                light.enabled = false;
            }
            else if(Input.GetMouseButtonDown(0) && light.enabled == false)
            {
                audioSource.PlayOneShot(boton);
                light.enabled = true;
            }
            //active = !active;
            //this.gameObject.SetActive(active);
            //audioSource.PlayOneShot(boton);
            //gameObject.SetActive(!gameObject.activeInHierarchy);
            //if (act == true)
            //{
            //    this.gameObject.SetActive(false);
            //    audioSource.PlayOneShot(boton);
            //    act = false;
            //}
            //if (act == false)
            //{
            //    this.gameObject.SetActive(true);
            //    audioSource.PlayOneShot(boton);
            //    act = true;
            //}
        }
    }
}
