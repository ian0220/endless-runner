using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]
    private GameObject backgroundfirst;

    public void moeftoo(GameObject moevegameobect) 
    {  // controleerd wat de achterst background is en ze de nieuwe er achter
        moevegameobect.transform.position = new Vector3(backgroundfirst.transform.position.x + 55, moevegameobect.transform.position.y, moevegameobect.transform.position.z);
        backgroundfirst = moevegameobect;
    }
}
