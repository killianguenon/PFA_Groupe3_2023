using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButtonAction : MonoBehaviour
{
    [SerializeField]
    GameObject targetVisualAction;

    ParameterAll ParameterAll;
    public Function function;

    void Start()
    {
        function = FindObjectOfType<Function>();
    }

    void Update()
    {
        function.LookAt2D(this.gameObject, targetVisualAction);
    }
}
