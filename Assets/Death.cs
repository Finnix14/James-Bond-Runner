using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    public GameObject deathUI;


    void Start()
    {
        characterController = GetComponent<CharacterController>();


        deathUI.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            
            deathUI.gameObject.SetActive(true);

        }

    }


}