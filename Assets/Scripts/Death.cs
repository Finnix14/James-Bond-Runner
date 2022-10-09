using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    public GameObject deathUI;
    public Animator anim;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        anim = GetComponent<Animator>();
        deathUI.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            deathUI.gameObject.SetActive(true);
            anim.SetTrigger("Death");

        }

    }


}