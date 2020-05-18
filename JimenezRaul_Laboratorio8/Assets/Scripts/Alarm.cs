using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    Light L;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        L = other.GetComponent<Light>();
        L.intensity = Mathf.Lerp(1,2, 2 * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other)
    {
        L = other.GetComponent<Light>();
        L.intensity = 0;
    }
}
