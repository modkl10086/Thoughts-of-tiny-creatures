using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//¼ÓÔØ³¡¾°µÄ

public class death : MonoBehaviour
{
    [SerializeField]private GameObject playerPS;
    [SerializeField]private Animator anim;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "trap")
        {
            Death();
        }
    }

    private void Death()
    {
        rb.bodyType = RigidbodyType2D.Static;
        Destroy(playerPS,1f);
        anim.SetTrigger("death");
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
