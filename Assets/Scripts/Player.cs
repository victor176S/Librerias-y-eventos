using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VicGenLib.Controllers;

public class Player : MonoBehaviour
{
    public float currentRotX = 0;

    public float currentRotY = 0;

    public float currentRotZ = 0;
    public float postRotX = 0;

    private float RotXOutPut;

    private GameObject tableta;

    private List<IEnumerator> funciones;

    private bool functionControl = true;

    private bool functionControlOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        tableta = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento camara teclas

        MovBase.KeyCamMov(this.gameObject, currentRotX, out RotXOutPut, 40, -40);

        this.gameObject.transform.GetChild(0).gameObject.transform.eulerAngles = new UnityEngine.Vector3(RotXOutPut, this.gameObject.transform.eulerAngles.y , 0);

        currentRotX = RotXOutPut;

        if (functionControl && Input.GetKey(KeyCode.Q))
        {
            Debug.Log("entrada");

            StartCoroutine(VicGenLib.Canvas.Cam.RotateAmountByPress(this.gameObject.transform.GetChild(0).GetChild(0).gameObject, KeyCode.Q, 90, 0.002f, false, true));

            functionControl = false;
        }

        if(!functionControl && Input.GetKey(KeyCode.E))
        {
            Debug.Log("salida");

            StartCoroutine(VicGenLib.Canvas.Cam.RotateAmountByPress(this.gameObject.transform.GetChild(0).GetChild(0).gameObject, KeyCode.E, -90, 0.002f, true, false));

            functionControl = true;
        }
    }
}