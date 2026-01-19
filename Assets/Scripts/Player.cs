using UnityEngine;
using VicGenLib.Controllers;

public class Player : MonoBehaviour
{
    public float currentRotX = 0;

    public float currentRotY = 0;

    public float currentRotZ = 0;
    public float postRotX = 0;

    private float RotXOutPut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento camara teclas

        /*MovBase.KeyCamMov(this.gameObject, currentRotX, out RotXOutPut);

        this.gameObject.transform.GetChild(0).gameObject.transform.eulerAngles = new UnityEngine.Vector3(RotXOutPut, 0 , 0);

        currentRotX = RotXOutPut;*/
    }
}