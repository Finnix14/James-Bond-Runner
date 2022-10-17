using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Death : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    public GameObject deathUI;
    public Animator anim;
    public AudioSource deadSound;

    public Transform t;
    public float force = 0.05f;
    public float radius;



    public List<GameObject> _parts;
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
            dyingFR();
            
            
         
            Time.timeScale = 0.8f;
           
            deathUI.gameObject.SetActive(true);
            pc.enabled = false;
           

            deadSound.Play();
           

            anim.enabled = false;

           
            
            

        }


    }
    public void dyingFR()
    {
        foreach (var t in _parts)
        {
            t.transform.SetParent(null);
            t.AddComponent<Rigidbody>().AddExplosionForce(force, Vector3.zero, radius);
            t.AddComponent<CapsuleCollider>();
        }
    }


}