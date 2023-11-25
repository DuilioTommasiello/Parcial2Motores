using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    public Transform targetObject; // El objeto hacia el cual queremos rotar
    public float rotationSpeed = 5.0f; // Velocidad de rotaci�n

    void Update()
    {
        if (targetObject != null)
        {
            //// Calculamos la direcci�n hacia el objeto destino
            //Vector3 direction = player.tranform.position - transform.position;

            //// Calculamos la rotaci�n hacia esa direcci�n usando Quaternion.LookRotation
            //Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);

            //// Aplicamos la rotaci�n suavemente
            //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("No se ha asignado un objeto destino.");
        }
    
    }
}
