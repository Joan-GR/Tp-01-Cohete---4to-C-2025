using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject fuegoON;
    public GameObject botonGO;
    public CoheteScript coheteScript;


    private void OnMouseDown()
    {
        fuegoON.SetActive(true);
        botonGO.SetActive(false);
        //ordenarle al cohete que despegue
        coheteScript.Despegue();
    }

    private void OnMouseUp()
    {

        botonGO.SetActive(true);
    }

}
