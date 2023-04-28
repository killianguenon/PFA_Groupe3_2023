using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{

    public void LookAt2D(GameObject origin, GameObject target)
    {
        Vector3 direction = target.transform.position - origin.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        origin.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void ScroolAndScale2D(GameObject origin, GameObject target, Vector2 StartDistance)
    {
        Vector3 scaleTarget = target.gameObject.transform.localScale;
        Vector3 scaleOrigin = target.gameObject.transform.localScale;
        
        Vector2 distance = origin.transform.position - target.transform.position;
        Vector2 percentDistance = (distance) / StartDistance;
        
        scaleOrigin -= new Vector3(scaleTarget.x*percentDistance.x,scaleTarget.y*percentDistance.y,scaleOrigin.z);
        if (scaleOrigin.x >= origin.transform.localScale.x && scaleOrigin.y >= origin.transform.localScale.y)
        {
            origin.transform.localScale = scaleOrigin;
        }
    }
}
