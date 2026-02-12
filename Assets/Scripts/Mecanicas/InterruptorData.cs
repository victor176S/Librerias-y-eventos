using System.Collections.Generic;
using UnityEngine;

public class InterruptorData : MonoBehaviour
{
    public KeyCode tecla;

    public Vector3 direccion;

    [SerializeField] private float velocidad = 1;

    public bool pulsado = false;

    public bool isComplex;

    [Header("Complex button values")]

    public List<GameObject> sections;

    [SerializeField] private List<float> sectionValues;

    public float contador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GetSections();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(direccion * velocidad);
    }
    /*void GetSections()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            sections[i] = gameObject.transform.GetChild(1 + i).gameObject;
        }
    }*/

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Marca"))
        {
            contador += Time.deltaTime;
        }
    }
    
}
