using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SimpleQuickTimeEvents : MonoBehaviour
{
    public GameObject marcaFunc;

    private bool pulsado;

    float contadorPulsado;

    float contadorFull;
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

                contadorPulsado = other.gameObject.GetComponent<InterruptorData>().contador;

                

                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pulsado = false;

        contadorFull = other.gameObject.GetComponent<InterruptorData>().contador;

        if (contadorPulsado <= contadorFull / 3f)
        {
            Debug.Log("Muy pronto");
        }

        if (contadorPulsado < contadorFull / 2f && contadorPulsado >= contadorFull / 3f)
        {
            Debug.Log("bien");
        }

        if (contadorPulsado >= contadorFull / 2f && contadorPulsado < (contadorFull / 3f) + contadorFull / 2)
        {
            Debug.Log("bien");
        }

        if (contadorPulsado >= (contadorFull / 3f) + contadorFull / 2)
        {
            Debug.Log("muy tarde");
        }

        

    }

}
