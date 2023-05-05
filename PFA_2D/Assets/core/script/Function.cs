using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    /// equivalent du lookAt mais pour la 2D    K.G
    /// permet d'effectuer une rotation de l'axe z de sorte que l'axe x pointe vers la position cible   K.G
    public void LookAt2D(GameObject origin, GameObject target)
    {
        Vector3 direction = target.transform.position - origin.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        origin.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void ScroolAndScale2D(GameObject origin, GameObject target, Vector2 StartDistance)
    {
        Vector3 scaleTarget = target.gameObject.GetComponent<RectTransform>().localScale; //recupere le scale de la cible   K.G
        Vector3 scaleOrigin = target.gameObject.GetComponent<RectTransform>().localScale; //recupere le scale de l'origine  K.G

        Vector2 distance = origin.GetComponent<RectTransform>().position - target.GetComponent<RectTransform>().position; // calcule la distance entre la position d'origine et sa cible    K.G
        Vector2 percentDistance = (distance) / StartDistance; // calcule en pourcentage compris [0,1] la distance parcourue (1 = arriver a destination) K.G

        scaleOrigin -= new Vector3(scaleTarget.x*percentDistance.x,scaleTarget.y*percentDistance.y,scaleOrigin.z); // calcule le scale en fonction de la distance parcourue     K.G

        ///force le depart du scale à partire de la taille d'origine jusqu'a celle de sa cible  K.G
        ///empeche de scale a partir de l'infiniment petit.    K.G
        if (scaleOrigin.x >= origin.GetComponent<RectTransform>().localScale.x && scaleOrigin.y >= origin.GetComponent<RectTransform>().localScale.y)
        {
            origin.GetComponent<RectTransform>().localScale = scaleOrigin; // affecte le nouveau scale au RectTransform de l'origine    K.G
        }
    }
}
