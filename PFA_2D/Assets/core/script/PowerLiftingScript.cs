using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerLiftingScript : MonoBehaviour
{
    public GameObject gaugeRouge, barreSelect, gaugeBase;

    [SerializeField ,Range(-14f, 17f)]
    float posYgaugeRouge;


    private void Start()
    {
        
    }
    private void Update()
    {
        //gaugeRouge.GetComponent<Transform>().position = new Vector3(gaugeRouge.transform.position.x, posYgaugeRouge, gaugeRouge.transform.position.z);
    }
}
