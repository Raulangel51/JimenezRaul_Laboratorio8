using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    public Image ima;
    public Text t;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Name();
    }

    void Name()
    {
        RaycastHit hitInfo;
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(myRay, out hitInfo, 4))
        {
            if (hitInfo.collider.gameObject.tag.Equals("Box") || hitInfo.collider.gameObject.tag.Equals("Ball"))
            {
                ima.enabled = true;
                t.enabled = true;
                t.text = hitInfo.collider.gameObject.tag.ToString();
            }
            else
            {
                ima.enabled = false;
                t.enabled = false;
            }
        }
    }
}
