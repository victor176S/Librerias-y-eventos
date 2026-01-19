using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VicGenLib.Canvas;

public class CambiarCamaras : MonoBehaviour
{

    public List<GameObject> camaras;

    public RawImage imagen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarCam1()
    {
        Cam.ChangeCamInCanvas(camaras, imagen, 0);
    }

    public void CambiarCam2()
    {
        Cam.ChangeCamInCanvas(camaras, imagen, 1);
    }

    public void CambiarCam3()
    {
        Cam.ChangeCamInCanvas(camaras, imagen, 2);
    }
}
