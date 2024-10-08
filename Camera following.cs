using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public float smooth = 0.3f;
    Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.position;
    }

    private void LateUpdate()
    {
        if(player!=null)
        {
            transform.position = Vector3.Lerp(transform.position, player.position + distance,smooth);
        }
    }

}
