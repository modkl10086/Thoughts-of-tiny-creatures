using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : Fruits
{
    public GameObject dialogueBox;
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public GameObject dialogueBox3;
    public int cnt = 0;
    public GameObject dialogueBox4;
    public GameObject maochong;
    //public GameObject dialogueBox5;
    //public Text dialogueText;
    //public string npcText;
    //private bool playerNpc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && cnt ==1)
        {
            
            dialogueBox1.SetActive(true);
            cnt = 2;
            
            /*if (Input.GetKeyDown(KeyCode.E))
                dialogueBox4.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
                dialogueBox5.SetActive(true);*/
        }
        
        if (Input.GetKeyDown(KeyCode.R) && cnt == 2)
        {
            dialogueBox2.SetActive(true);
            cnt = 3;
        }
            
        if (Input.GetKeyDown(KeyCode.T) && cnt == 3)
        {
            dialogueBox3.SetActive(true);
            cnt = 4;
        }

        if(Input.GetKeyDown(KeyCode.F) && cnt!=0)
        {
            dialogueBox4.SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.Y)&&cnt!= 0)
        {
            Destroy(maochong);

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.gameObject.CompareTag("Player"))
        //dialogueText.text = npcText;
        //playerNpc = true;
        //Debug.Log("1");
        
            dialogueBox.SetActive(true);
            cnt = 1;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //if(collision.gameObject.CompareTag("Player"))
        
            dialogueBox.SetActive(false);
            dialogueBox1.SetActive(false);
            dialogueBox2.SetActive(false);
            dialogueBox3.SetActive(false);
            dialogueBox4.SetActive(false);
        //playerNpc = false;
        //Debug.Log("2");
            cnt = 0;
        
    }
}
