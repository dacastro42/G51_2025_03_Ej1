using UnityEngine;
using System;
using System.Collections.Generic;
using PackagePersona;
using System.Runtime.Serialization;
using System.IO;
public class Utilidades 
{
    public static bool SaveDataStudent(List<Estudiante> listaE)
    {
        try
        {
            string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaE }, true);
            string folderPath = Application.streamingAssetsPath;

            // Crear la carpeta si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "datos.json");

            // Escribir el archivo
            File.WriteAllText(filePath, jsonString);

            Debug.Log(" Archivo JSON guardado correctamente en: " + filePath);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error al guardar archivo JSON: " + ex.Message);
            return false;
        }
    }
}

[Serializable]
public class EstudianteListWrapper
{

    public List<Estudiante> estudiantes;

}