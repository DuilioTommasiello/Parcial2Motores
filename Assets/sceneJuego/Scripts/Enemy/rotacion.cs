using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    public Transform targetObject; // El objeto hacia el cual queremos rotar
    public float rotationSpeed = 5.0f; // Velocidad de rotación

    void Update()
    {
        if (targetObject != null)
        {
            //// Calculamos la dirección hacia el objeto destino
            //Vector3 direction = player.tranform.position - transform.position;

            //// Calculamos la rotación hacia esa dirección usando Quaternion.LookRotation
            //Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);

            //// Aplicamos la rotación suavemente
            //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("No se ha asignado un objeto destino.");
        }
    
    }
}
