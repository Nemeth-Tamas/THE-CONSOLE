using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bevitel : MonoBehaviour {

    [SerializeField]
    InputField InputField;
    [SerializeField]
    Button button;
    [SerializeField]
    InputField InputField1;
    [SerializeField]
    Button button1;
    [SerializeField]
    AudioClip AudioClip;


    string pass = "almaaaa";
    string passb;



    private AudioSource source;

    // Use this for initialization
    void Start (){

        source = GetComponent<AudioSource>();

        //InputField.gameObject.SetActive(false);
        //button.gameObject.SetActive(false);
        //InputField1.gameObject.SetActive(true);
        //button1.gameObject.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {

        

        passb = InputField1.text;

        if (pass == passb)
        {
            InputField.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
            InputField1.gameObject.SetActive(false);
            button1.gameObject.SetActive(false);
        }
        else
        {
            InputField.gameObject.SetActive(false);
            button.gameObject.SetActive(false);
            InputField1.gameObject.SetActive(true);
            button1.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            feldolgoz();
        }
	}

    public void kuld()
    {
        
        feldolgoz();
    }
    void feldolgoz()
    {
        switch (InputField.text)
        {
            case "alma":
                Debug.Log("alma");
                break;
            case "faded":
                source.PlayOneShot(AudioClip, 1);
                break;
            case "zene stop":
                source.Stop();
                break;
            case "hang 20":
                source.volume = 0.2f;
                break;
            case "hang 10":
                source.volume = 0.1f;
                break;
            case "hang 30":
                source.volume = 0.3f;
                break;
            case "hang 40":
                source.volume = 0.4f;
                break;
            case "hang 50":
                source.volume = 0.5f;
                break;
            case "hang 60":
                source.volume = 0.6f;
                break;
            case "hang 70":
                source.volume = 0.7f;
                break;
            case "hang 80":
                source.volume = 0.8f;
                break;
            case "hang 90":
                source.volume = 0.9f;
                break;
            case "hang 100":
                source.volume = 1f;
                break;
            case "némít":
                source.volume = 0;
                break;
            default:
                Debug.Log("Helytelen parancs");
                break;
        }
    }

}
