using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectablesCounter : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    [SerializeField] private AudioSource collectSound;
    [SerializeField] private TMP_Text scoreText;
    

    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        collectSound = GameObject.Find("Player").GetComponent<AudioSource>();
        scoreText = GameObject.Find("MartiniCounter").GetComponentInChildren<TMP_Text>();
    }

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        pc.playerScore++;
        scoreText.GetComponent<TMP_Text>().text = " " + pc.playerScore;
        Destroy(gameObject);
    }
}
