using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TextReader : MonoBehaviour
{

    
//Text Reader Variables
public Text txt;
    public string path = "Assets/Text_Files/TestText.txt";
    public int counter = 0;

    //Text Scroller and Delay Variables
    private string currentText;
    public float delay = 0.03f;
   
    //List of Dialogue Lines
    ArrayList textLines = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {

        txt = GetComponent<Text>();
        ReadString();
        //Letter by letter string reveal
        StartCoroutine(showText());
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = currentText;
        if(Input.GetKeyDown(KeyCode.Space) && counter < textLines.Count-1)
            //&& currentText == textLines[counter].ToString())
        {           
            counter++;
            StartCoroutine(showText());
        }

    }
    
    //Reads input file for dialogue box.
    void ReadString()
    {
        string temp;
        //Read the text directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        while ((temp = reader.ReadLine()) != null)
        {
            textLines.Add(temp);
        }
        reader.Close();
    }
    
    IEnumerator showText()
    {
            for(int j = 0; j < textLines[counter].ToString().Length; j++)
            {
                /*NOT DONE D: ---- ATTEMPTING TO ADD SPECIAL PAUSE CHARACTER FOR TEXT SCROLLING
                if(textLines[counter].ToString()[j] == '#')
                {
                    textLines[counter].ToString().Remove(textLines[counter].ToString()[j],1);
                    yield return new WaitForSeconds(0.6f);
                }
                */
                //Type-Writer Effect Text
                currentText = textLines[counter].ToString().Substring(0, j);
                yield return new WaitForSeconds(delay);
            }
        
    }
}
