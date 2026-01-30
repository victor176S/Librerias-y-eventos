using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using VicGenLib.Calc;

public class UI : MonoBehaviour
{

    float tiempo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FrameShowWait());
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = VicGenLib.Calc.Counters.FpsIndependentCounterInt(tiempo);

        this.gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = ((int)tiempo).ToString();
    }

    IEnumerator FrameShowWait()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);

            this.gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = VicGenLib.Logic.GUI.PassFramesToText();
        }
    }
}
