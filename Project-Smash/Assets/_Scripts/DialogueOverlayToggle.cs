using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOverlayToggle : MonoBehaviour
{

    public GameObject overlayToggle;
   // public TextReader script;
 

// Start is called before the first frame update
void Start()
    {
        overlayToggle = GameObject.Find("DialogueOverlay");
        overlayToggle.SetActive(false);
       // GameObject temp = GameObject.Find("TextBox");
       // script = temp.GetComponent<TextReader>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            overlayToggle.SetActive(true);

            //script.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            overlayToggle.SetActive(false);

           // script.enabled = false;
        }
    }
}
