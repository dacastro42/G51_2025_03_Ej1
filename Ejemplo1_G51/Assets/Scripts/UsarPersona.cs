using UnityEngine;
using PackagePersona;
using System.Collections.Generic;
using TMPro;

public class UsarPersona : MonoBehaviour
{

    List<Estudiante> listaE = new List<Estudiante>();
    public TMP_InputField nameStudent;
    public TMP_InputField mailStudent;
    public TMP_InputField dirStudent;
    public TMP_InputField CodeStudent;
    public TMP_InputField carreraStudent;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        //Estudiante e1 = new Estudiante("2025_1", "Ing multimedia", 
        //    "David Castro", "dacastro@uao.edu.co", "carrera 34");

        //Estudiante e2 = new Estudiante("2025_2", "Ing ambiental",
        //    "Sandra Garces", "dsgarces@uao.edu.co", "carrera 14");

        //listaE.Add(e1);
        //listaE.Add(e2);

        //for (int i = 0; i < listaE.Count; i++)
        //{
        //    Debug.Log(listaE[i].NameP + " " + listaE[i].NameCarrera);
        //}
    }

    // Update is called once per frame
    public void Update()
    {
        
    }


    public void AddStudentList()
    {
        string nameStudent1= nameStudent.text;
        string mailStudent1= mailStudent.text;
        string dirStudent1= dirStudent.text;
        string codeStudent1=CodeStudent.text;
        string carreraS1= carreraStudent.text;
        Estudiante e1 = new Estudiante(codeStudent1, carreraS1,
           nameStudent1, mailStudent1, dirStudent1);

        listaE.Add(e1);

    }

    public void ShowStudentList()
    {
        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log(listaE[i].NameP + " " + listaE[i].NameCarrera);
        }

        Utilidades.SaveDataStudent(listaE);
    }

}