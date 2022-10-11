using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    public GameObject deathUI;
    public Animator anim;
    public AudioSource deadSound;
    void Start()
    {
        pc = GetComponent<PlayerController>();
        Time.timeScale = 1f;

        anim = GetComponent<Animator>();
        deathUI.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            anim.SetTrigger("Death");   
            Time.timeScale = 0.25f;
           
            deathUI.gameObject.SetActive(true);
            pc.enabled = false;
           

            deadSound.Play();
            deadSound.pitch = 0.5f;


        }

    }


}