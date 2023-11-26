using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiayNoche : MonoBehaviour
{
    [Range(0.0f, 24f)] public static float hora = 12;
    public Transform sun;
    private static float duracion = 10;
    private float solX;

    // Update is called once per frame
    private void Update()
    {
        hora += Time.deltaTime * (24/(60 * duracion));

        if (hora >= 24)
        {
            hora = 0;
        }

        RotacionSol();
    }

     void RotacionSol()
    {
        solX = 15 * hora;
        sun.localEulerAngles = new Vector3(solX, 0, 0);
        if ((hora < 6 || hora > 18) /*&& sun.GetComponent<Light>().intensity > 0*/)
        {
            if (sun.GetComponent<Light>().intensity > 0)
            {
                sun.GetComponent<Light>().intensity -= 0.1f * Time.deltaTime;
            }
            
        }
        else if((hora > 6 && hora < 18) /*&& sun.GetComponent<Light>().intensity < 1*/)
        {
            if (sun.GetComponent<Light>().intensity < 1)
            {
                sun.GetComponent<Light>().intensity += 0.1f * Time.deltaTime;
            }
        }
        if ((Tconsciente.dia == true && Mathf.CeilToInt(hora) == 12) ||(Tconsciente.noche == true && Mathf.CeilToInt(hora) == 24))
        {
            duracion = 10;
            Tconsciente.dia = false;
            Tconsciente.noche = false;
        }
    }

    public static void HoraDia ()
    {
        if (Tconsciente.sol)
        {
            if (hora < 6 || hora > 18)
            {
                duracion = 0.2f;
            }
        }

    }

    public static void HoraNoche()
    {
        if (Tconsciente.luna)
        {
            if (hora > 6 && hora < 18)
            {
                duracion = 0.2f;
            }
        }

    }
}
