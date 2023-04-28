using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualAction : MonoBehaviour
{
    [SerializeField]
    GameObject targetButtonAction;
    ParameterAll ParameterAll;
    public Function function;

    Vector2 vector2Strength, vector2PositionStart;
    float strength;

    private void Start()
    {
        vector2PositionStart = transform.position - targetButtonAction.transform.position;
        ParameterAll = FindObjectOfType<ParameterAll>();
        function = FindObjectOfType<Function>();
    }

    void Update()
    {
        strength = ParameterAll.visualActionStrength;
        vector2Strength = new Vector2(strength, 0);

        function.LookAt2D(gameObject, targetButtonAction);
        function.ScroolAndScale2D(gameObject, targetButtonAction, vector2PositionStart);

        this.GetComponent<Rigidbody2D>().AddRelativeForce(vector2Strength);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == targetButtonAction.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}