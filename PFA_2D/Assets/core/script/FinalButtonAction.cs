using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButtonAction : MonoBehaviour
{
    [SerializeField]
    GameObject targetVisualAction; // objet cible   K.G

    ParameterAll parameterAll;
    public Function function; 

    void Start()
    {
        function = FindObjectOfType<Function>(); // objet de la  classe "Function" qui regroupe les fonctions utilisable    K.G
        parameterAll = FindObjectOfType<ParameterAll>(); // objet de la classe "ParameterAll" regroupant tous les reglage du jeu    K.G
    }

}
