using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLuna : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador")
        {            
            Tconsciente.sol = false;
            Tconsciente.luna = true;
        }
        Debug.Log("Acabas de Conseguir El Tejido de la Luna");
        Destroy(gameObject);
    }
}
