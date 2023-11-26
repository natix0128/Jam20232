using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tconsciente : MonoBehaviour
{
    public static bool dia = false;
    public static bool noche = false;

    public static bool sol = false;
    public static bool luna = false;

    public static bool cLuna = false;
    public static bool cSol= false;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DiayNoche.HoraDia();
            dia = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            DiayNoche.HoraNoche();
            noche = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && Tconsciente.cSol)
        {
            sol = true;
            luna = false;
            Debug.Log("Activaste el tejido del Sol");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && Tconsciente.cLuna)
        {
            luna = true;
            sol = false;
            Debug.Log("Activaste el tejido de la Luna");
        }
    }
}
