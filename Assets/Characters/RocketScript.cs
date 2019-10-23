using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float distance = 0f;

    public GameObject player;
    private Animator animator;
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(player.transform.position, this.transform.position);
        animator.SetFloat("distancia", distance);

        if (distance < 0.5f) { 
            this.transform.position += new Vector3(1, 0, 0) * 0.06f;
            this.animator.enabled = true;
        }
        else
        {
            this.animator.enabled = false;
        }
    }
}
