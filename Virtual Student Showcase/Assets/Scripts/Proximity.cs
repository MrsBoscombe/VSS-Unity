using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Proximity : MonoBehaviour
{
    public string newTitle;
    public string newAuthor;
    public string newDesc;
    private Transform other;
    private Text myTitle;
    private Text myAuthor;
    private Text myDesc;
    private float dist;
    private GameObject player;
    private GameObject message1;
    private GameObject message2;
    private GameObject message3;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();
        message1 = GameObject.FindWithTag("ArtTitle");
        message2 = GameObject.FindWithTag("Author");
        message3 = GameObject.FindWithTag("Description");

        myTitle = message1.GetComponent<Text>();
        myAuthor = message2.GetComponent<Text>();
        myDesc = message3.GetComponent<Text>();
       
        myTitle.text = "";
        myAuthor.text = "";
        myDesc.text = "";
    }

     
    private void OnTriggerEnter(Collider other)
    {
        myTitle.text = newTitle;
        myAuthor.text = newAuthor;
        myDesc.text = newDesc;
        
    }

    private void OnTriggerExit(Collider other)
    {
        myTitle.text = "";
        myAuthor.text = "";
        myDesc.text = "";
    }

    
}
