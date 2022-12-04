using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch : MonoBehaviour
{

    [SerializeField] GameObject CamPlayer;
    [SerializeField] GameObject CamEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            CamPlayer.SetActive(true);
        }

        if (Input.GetKey(KeyCode.X))
        {
            CamEnemy.SetActive(true);
        }
        
    }
}
