using UnityEngine;
using UnityEngine.UI;

public class ParameterAll:MonoBehaviour
{
    [Range(1f,50f)]
    public float visualActionStrength; // parametre de la force qui sera exercer sur l'objet K.G

    [Range(50f, 1000f)]
    public ushort bpm; // parametre du bpm de la musique K.G
}
