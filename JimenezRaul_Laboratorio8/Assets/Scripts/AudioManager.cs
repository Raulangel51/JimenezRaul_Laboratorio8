using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip shoot;
    public AudioClip boom;

    float m_MySliderValue;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_MySliderValue = 0.5f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnGUI()
    {
        m_MySliderValue = GUI.HorizontalSlider(new Rect(350, 25, 200, 60), m_MySliderValue, 0.0F, 1.0F);
        audioSource.volume = m_MySliderValue;
    }

    public void PlayJump()
    {
        if (jump)
            audioSource.PlayOneShot(jump);
            
    }

    public void PlayBoom()
    {
        if (boom)
            audioSource.PlayOneShot(boom);
    }

    public void PlayShoot()
    {
        if (shoot)
            audioSource.PlayOneShot(shoot);
    }
}
