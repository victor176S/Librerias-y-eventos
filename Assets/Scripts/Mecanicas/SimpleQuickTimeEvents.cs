using System.Collections.Generic;
using UnityEngine;

public class SimpleQuickTimeEvents : MonoBehaviour
{
    public GameObject marcaFunc;

    private bool pulsado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    public static void SimpleQuickTimeEvent(List<GameObject> interruptores, GameObject marca)
    {
        


    }

    private void OnTriggerStay(UnityEngine.Collider other)
    {
        if (other.gameObject.name == "Interruptor" || other.gameObject.CompareTag("Interruptor"))
        {
            var interruptor = other.gameObject.GetComponent<InterruptorData>();

            Debug.Log("Interruptor");

            if (Input.GetKey(interruptor.tecla) && !pulsado)
            {
                Debug.Log("pulsado");

                interruptor.pulsado = true;

                pulsado = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pulsado = false;
    }

}
