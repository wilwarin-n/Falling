using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public static GameManager gm;

    public Material skySunset;
    public Material skyEvening;
    public Material skyMidNight;
    public Material skyDayBreak;

    // Start is called before the first frame update
    void Start()
    {
        //gm = gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.score >= 5000)
        {
            RenderSettings.skybox=skySunset;
        }

        
    }
}
