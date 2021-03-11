using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepon : MonoBehaviour
{

    
    public GameObject throwablePrefab;
    private GameObject sphere = null;
    public float thowForce = 10f;
    public float maxThrowForce = 4f;

    private float holdDownTimer;
    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;
}

    // Update is called once per frame
    void Update()
    {

        if (input.GetbuttonDown("Fire1"))
        {
            holdDownTimer = Time.time;
        }

        if (input.GetbuttonDown("Fire1"))
        {
            float totalTime = Time.time - holdDownTimer;
            object p = Throw();
        }



        }
    
}
