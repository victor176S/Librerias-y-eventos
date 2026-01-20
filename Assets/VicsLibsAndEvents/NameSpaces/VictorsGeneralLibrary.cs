using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace VicGenLib

{
    namespace Calc
    {
        public class Sums
        {       
            public static float SumExample(float a, float b)
            {
                float c;

                c = a + b;

                    return c;
            }

        }

        public class Movement
        {       
            public static float Normalize(float a, float b)
            {
                float c;

                float a2;

                float b2;

                a2 = Mathf.Pow(a, 2);

                b2 = Mathf.Pow(b, 2);

                c = a2 + b2;

                c = Mathf.Sqrt(c);

                    return c;
            }

            //Usar en Update
            /*Hace el lerp más facil teniendo solo que pasar las variables*/

            public static UnityEngine.Vector3 SimplerLerp(GameObject objeto, GameObject startPoint, GameObject endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.transform.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(Transform objeto, GameObject startPoint, GameObject endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(Transform objeto, Transform startPoint, GameObject endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(Transform objeto, GameObject startPoint, Transform endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.transform.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(GameObject objeto, Transform startPoint, GameObject endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.transform.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(GameObject objeto, Transform startPoint, Transform endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.transform.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(GameObject objeto, GameObject startPoint, Transform endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.transform.position = UnityEngine.Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

            public static UnityEngine.Vector3 SimplerLerp(Transform objeto, Transform startPoint, Transform endPoint, float lerpTime, AnimationCurve lerpCurve, float timeElapsed,out float timeElapsedOutPut)
            {

                float t = timeElapsed / lerpTime;

                t = Mathf.Clamp01(t);

                objeto.position = UnityEngine.Vector3.Lerp(startPoint.position, endPoint.position, lerpCurve.Evaluate(t));

                timeElapsed += Time.deltaTime;

                timeElapsedOutPut = timeElapsed;

                return objeto.transform.position;
            }

        }   
    }

    namespace Controllers
    {

        public class MovBase
        {
        public static UnityEngine.Vector3 SimplePlayerMovement(GameObject objeto)
        {
            if(Input.GetKey(KeyCode.W))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,0.1f);
            }

            if(Input.GetKey(KeyCode.S))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,-0.1f);
            }

            if(Input.GetKey(KeyCode.A))
            {
                objeto.transform.position += new UnityEngine.Vector3(-0.1f,0,0);
            }

            if(Input.GetKey(KeyCode.D))
            {
                objeto.transform.position += new UnityEngine.Vector3(0.1f,0,0);
            }

            return objeto.transform.position;
        }

        public static UnityEngine.Vector3 SimplePlayerMovement(GameObject objeto, float velocidad)
        {
            if(Input.GetKey(KeyCode.W))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,0.1f * velocidad);
            }

            if(Input.GetKey(KeyCode.S))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,-0.1f * velocidad);
            }

            if(Input.GetKey(KeyCode.A))
            {
                objeto.transform.position += new UnityEngine.Vector3(-0.1f,0,0 * velocidad);
            }

            if(Input.GetKey(KeyCode.D))
            {
                objeto.transform.position += new UnityEngine.Vector3(0.1f,0,0 * velocidad);
            }

            return objeto.transform.position;
        }

        public static UnityEngine.Vector3 SimplePlayerMovementCustom(GameObject objeto, KeyCode codeForward, KeyCode codeBackwards, KeyCode codeLeft, KeyCode codeRight)
        {
            if(Input.GetKey(codeForward))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,0.1f);
            }

            if(Input.GetKey(codeBackwards))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,-0.1f);
            }

            if(Input.GetKey(codeLeft))
            {
                objeto.transform.position += new UnityEngine.Vector3(-0.1f,0,0);
            }

            if(Input.GetKey(codeRight))
            {
                objeto.transform.position += new UnityEngine.Vector3(0.1f,0,0);
            }

            return objeto.transform.position;
        }

        public static UnityEngine.Vector3 SimplePlayerMovementRB(GameObject objeto, ForceMode modo)
        {
            if(Input.GetKey(KeyCode.W))
            {
                objeto.GetComponent<Rigidbody>().AddForce(0, 0, 1f, modo);
            }

            if(Input.GetKey(KeyCode.S))
            {
                objeto.GetComponent<Rigidbody>().AddForce(0, 0, -1f, modo);
            }

            if(Input.GetKey(KeyCode.A))
            {
                objeto.GetComponent<Rigidbody>().AddForce(-1f, 0, 0, modo);
            }

            if(Input.GetKey(KeyCode.D))
            {
                objeto.GetComponent<Rigidbody>().AddForce(1f, 0, 0, modo);
            }

            return objeto.transform.position;
        }

        public static UnityEngine.Vector3 SimplePlayerMovementRB(GameObject objeto, ForceMode modo, float velocidad)
        {
            if(Input.GetKey(KeyCode.W))
            {
                objeto.GetComponent<Rigidbody>().AddForce(0, 0, 1f * velocidad, modo);
            }

            if(Input.GetKey(KeyCode.S))
            {
                objeto.GetComponent<Rigidbody>().AddForce(0, 0, -1f * velocidad, modo);
            }

            if(Input.GetKey(KeyCode.A))
            {
                objeto.GetComponent<Rigidbody>().AddForce(-1f * velocidad, 0, 0, modo);
            }

            if(Input.GetKey(KeyCode.D))
            {
                objeto.GetComponent<Rigidbody>().AddForce(1f * velocidad, 0, 0, modo);
            }

            return objeto.transform.position;
        }


        public static UnityEngine.Vector3 PlayerJumpRB(GameObject objeto, ForceMode modo, float fuerza)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                objeto.GetComponent<Rigidbody>().AddForce(0, 10, 0f, modo);
            }

            return objeto.transform.position;
        }

        public static UnityEngine.Vector3 SimplePlayerMovementCustomRB(GameObject objeto, KeyCode codeForward, KeyCode codeBackwards, KeyCode codeLeft, KeyCode codeRight)
        {
            if(Input.GetKey(codeForward))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,0.1f);
            }

            if(Input.GetKey(codeBackwards))
            {
                objeto.transform.position += new UnityEngine.Vector3(0,0,-0.1f);
            }

            if(Input.GetKey(codeLeft))
            {
                objeto.transform.position += new UnityEngine.Vector3(-0.1f,0,0);
            }

            if(Input.GetKey(codeRight))
            {
                objeto.transform.position += new UnityEngine.Vector3(0.1f,0,0);
            }

            return objeto.transform.position;
        }

        public static void KeyCamMov(GameObject objeto, float rotationX, out float RotXOutPut, float topeRotacionArriba, float topeRotacionAbajo)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                objeto.transform.localEulerAngles += new UnityEngine.Vector3(0, 1, 0);    
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                objeto.transform.localEulerAngles += new UnityEngine.Vector3(0, -1, 0);    
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (rotationX > -topeRotacionArriba)
                {
                    rotationX -= 1;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                
                if (rotationX < -topeRotacionAbajo)
                {
                    rotationX += 1;
                }
            }

            RotXOutPut = rotationX; 
        }

        public static void KeyCamMov(GameObject objeto, float rotationX, out float RotXOutPut, float topeRotacionArriba, float topeRotacionAbajo, float velHor, float velVert)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                objeto.transform.localEulerAngles += new UnityEngine.Vector3(0, 1 * velHor, 0);    
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                objeto.transform.localEulerAngles += new UnityEngine.Vector3(0, -1 * velHor, 0);    
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (rotationX > -topeRotacionArriba)
                {
                    rotationX -= 1 * velVert;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                
                if (rotationX < -topeRotacionAbajo)
                {
                    rotationX += 1 * velVert;
                }
            }

            RotXOutPut = rotationX; 
        }

        }
    }

    namespace Canvas
    {
        public class Cam
        {
            public static void ChangeCamInCanvas(List<GameObject> camaras, RawImage imagen, int numCamara)
            {
                
                imagen.texture = camaras[numCamara].GetComponent<Camera>().targetTexture;

            }

            public static IEnumerator RotateAmountByPress(GameObject objeto, KeyCode tecla, float cantidad, float segundosEntreMov)
            {

                if (Input.anyKeyDown)
                {
                    if (Input.GetKeyDown(tecla))
                    {
                        for(int i = 0; i < Mathf.Abs(cantidad); i++)
                        {

                            if (cantidad < 0)
                            {
                                objeto.transform.localEulerAngles += new UnityEngine.Vector3(-1,0,0);

                                yield return new WaitForSeconds(segundosEntreMov);
                            }

                            if (cantidad > 0)
                            {
                                objeto.transform.localEulerAngles += new UnityEngine.Vector3(1,0,0);

                                yield return new WaitForSeconds(segundosEntreMov);
                            }
                        }
                    }
                }
            }

            public static IEnumerator RotateAmountByPress(GameObject objeto, KeyCode tecla, float cantidad, float segundosEntreMov, bool setActive, bool setlate)
            {
                if (Input.anyKeyDown)
                {
                    Debug.Log("entrada input");

                    if (!setlate)
                    {
                        if (setActive)
                        {
                            objeto.gameObject.SetActive(true);
                        }

                        if (!setActive)
                        {
                            objeto.gameObject.SetActive(false);
                        }
                    }

                    if (Input.GetKeyDown(tecla))
                    {
                        Debug.Log("entrada input correcto");

                        if (cantidad < 0)
                        {
                            objeto.transform.Rotate(cantidad, 0, 0);

                            yield return new WaitForSeconds(segundosEntreMov);
                        }

                        if (cantidad > 0)
                        {
                            objeto.transform.Rotate(cantidad, 0, 0);

                            yield return new WaitForSeconds(segundosEntreMov);
                        }
                    }
                
                    if (setlate)
                    {

                        if (setActive)
                        {

                            Debug.Log("set Active true");
                            objeto.gameObject.SetActive(true);
                        }

                        if(!setActive)
                        {
                            Debug.Log("set Active false");
                            objeto.gameObject.SetActive(false);
                        }
                    }
                }
            }
        }
    }

    namespace Logic
    {
        public class Func
        {
            public static void OneOrOtherFunc(List<IEnumerator> funciones, bool entrada, out bool salida)
            {
                GameObject eventHandler = GameObject.FindWithTag("EventHandler");

                Debug.Log("entrada OneorOther");

                if (entrada)
                {
                    Debug.Log("entrada OneorOther entrada");

                    eventHandler.GetComponent<CorrutineExecutor>().ExecuteCorrutine(funciones[0]);
                }

                if (!entrada)
                {
                    eventHandler.GetComponent<CorrutineExecutor>().ExecuteCorrutine(funciones[1]);
                }
                
                salida = !entrada;

            }
        }
    }
}   
        