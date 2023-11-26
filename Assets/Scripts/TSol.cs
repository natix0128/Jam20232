using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador")
        {
            Tconsciente.luna = false;
            Tconsciente.sol = true; 
        }
        Debug.Log("Acabas de Conseguir El Tejido del Sol");
        Destroy(gameObject);
    }
}
