using UnityEngine;
using VicGenLib;
using VicGenLib.Calc;
using VicGenLib.Controllers;


public class NameSpacesTest : MonoBehaviour
{

    public float num1;

    public float num2;
    public Transform start;

    public Transform end;

    public Transform point;

    public float lerpTime;

    public float timeElapsedInput;

    public float timeElapsedOutPut;

    public AnimationCurve lerpCurve;

    public KeyCode forward, backwards, left, right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Suma {Sums.SumExample(num1, num2)}");
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movement.SimplerLerp(point, start, end, lerpTime, lerpCurve, timeElapsedInput, out timeElapsedOutPut);
        
        //timeElapsedInput = timeElapsedOutPut;

        MovBase.SimplePlayerMovement(this.gameObject);
        
        //MovBase.SimplePlayerMovementRB(this.gameObject, ForceMode.Force, 10);

        //MovBase.PlayerJumpRB(this.gameObject, ForceMode.Impulse,1);



    }
}
