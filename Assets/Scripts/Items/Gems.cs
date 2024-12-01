using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public Coins_Points points;

    public float rotation_z = 20;
    private void Start()
    {
        points = FindObjectOfType<Coins_Points>();
    }
    private void Update()
    {
        Movement_Gems();
    }
    void Movement_Gems()
    {
        transform.Rotate(0, 0, rotation_z * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement_Player>() != null)
        {
            points.Sumar_Gems(); //Acceso a script Coins_Points para puntuar desde el game manager
            Destroy(gameObject); //Destruccion del gameobject cuando lo toca el jugador
        }
    }
}
