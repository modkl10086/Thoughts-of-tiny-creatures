using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuList : MonoBehaviour
{
    public GameObject menuList;
    [SerializeField] private bool menuKey = true;
    //[SerializeField] private AudioSource bgmSound;
    // Start is called before the first frame update
    void Start()
    {
        menuList.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (menuKey)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuList.SetActive(true);
                menuKey = false;
                Time.timeScale = (0);
                //bgmSound.Pause();
            }

        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuList.SetActive(false);
            menuKey = true;
            Time.timeScale = (1);
            //bgmSound.Play();
        }

    }
    public void Ruturn()
    {
        menuList.SetActive(false);
        menuKey = true;
        Time.timeScale = (1);
    }

    public void Restart()
    {
        menuList.SetActive(false);
        menuKey = true;
        Time.timeScale = (1);
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
