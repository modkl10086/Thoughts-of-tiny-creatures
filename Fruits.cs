using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
    private int bananas;
    protected int fruits = 0;
    [SerializeField] private Text score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fruits"))
        {
            Destroy(collision.gameObject);
            bananas++;
            fruits++;
            
            score.text = "Fruits score:" + fruits;
        }
    }
    private void Start()
    {

        bananas = 0;
        fruits = 0;
    }
    public int GetBananas()
    {
        return bananas;
    }
}
