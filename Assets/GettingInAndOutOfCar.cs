using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingInAndOutOfCar : MonoBehaviour
{
    [SerializeField] GameObject human = null;
    [SerializeField] GameObject car = null;

    [SerializeField] KeyCode enterExitKey = KeyCode.E;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(enterExitKey))
        {
            GetOutOfCar();
        }
    }

    void GetOutOfCar()
    {
        human.SetActive(true);

        human.transform.position = car.transform.position - car.transform.TransformDirection(Vector3.left);
    }
}
