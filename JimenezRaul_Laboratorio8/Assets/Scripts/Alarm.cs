using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    public Light light1;
    public Light light2;

    // Start is called before the first frame update
    void Start()
    {
        //L = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //L = other.GetComponent<Light>();
        light1.intensity = Mathf.Sin(Time.time);
        light2.intensity = Mathf.Sin(Time.time);
    }

    private void OnTriggerStay(Collider other)
    {
        light1.intensity = Mathf.Sin(Time.time) + 0.5f;
        light2.intensity = Mathf.Sin(Time.time) + 0.5f;
    }

    private void OnTriggerExit(Collider other)
    {
        //L = other.GetComponent<Light>();
        light1.intensity = 0;
        light2.intensity = 0;
    }
}
