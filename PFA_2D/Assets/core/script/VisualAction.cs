using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualAction : MonoBehaviour
{
    [SerializeField]
    GameObject targetButtonAction;

    ParameterAll ParameterAll;
    Function function;

    Vector2 vector2Strength, vector2DistanceStart;
    float strength;

    private void Start()
    {
        vector2DistanceStart = gameObject.transform.position - targetButtonAction.transform.position; // sauvegarde dans cette varible la distance de entre l'objet et sa cible
        ParameterAll = FindObjectOfType<ParameterAll>(); // objet de la classe "ParameterAll" regroupant tous les reglage du jeu
        function = FindObjectOfType<Function>(); // objet de la  classe "Function" qui regroupe les fonctions utilisable
    }

    void Update()
    {
        strength = ParameterAll.visualActionStrength; // recupere le parametre de la force qui sera exercer pour son deplacement  
        vector2Strength = new Vector2(strength, 0); // applique le parametre de force dans un vercteur pour son deplacement

        function.LookAt2D(gameObject, targetButtonAction); // utilise la fonction pour que l'objet pointe vers sa cible
        function.ScroolAndScale2D(gameObject, targetButtonAction, vector2DistanceStart); // utilise cette fonction pour que l'objet adapte son scale � celui de sa cible 

        this.GetComponent<Rigidbody2D>().AddRelativeForce(vector2Strength); // aplique le vecteur de force pour son d�placement
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /// si notre objet atteint sa cible alors la detruire (destruction temporaire, a remplacer par une autre fonction )
        if (collision.gameObject == targetButtonAction.gameObject)
        {
            // penser a d'avenir remplacer par une autre fonctiont peremettant de cacher l'objet
            // et de le fairte reaparaitre dans un moment aleatoire concordant avec le bpm de la musique actuelle
            Destroy(this.gameObject);
        }
    }
}