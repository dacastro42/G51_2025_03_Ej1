using UnityEngine;
using PackagePersona;
using System.Collections.Generic;

public class UsarPersona : MonoBehaviour
{

    List<Estudiante> listaE = new List<Estudiante>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void Start()
    {
        Estudiante e1 = new Estudiante("2025_1", "Ing multimedia", 
            "David Castro", "dacastro@uao.edu.co", "carrera 34");

        Estudiante e2 = new Estudiante("2025_2", "Ing ambiental",
            "Sandra Garces", "dsgarces@uao.edu.co", "carrera 14");

        listaE.Add(e1);
        listaE.Add(e2);

        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log(listaE[i].NameP + " " + listaE[i].NameCarrera);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
