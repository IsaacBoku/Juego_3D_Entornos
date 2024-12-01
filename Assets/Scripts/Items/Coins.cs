using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public string name_coins;
    public int value_coins;
    public float rotation_z = 30f;

    public int n_coins;
    public Coins_Points points;
    private void Start()
    {
        points = FindObjectOfType<Coins_Points>();
    }
    private void Update()
    {
        Movement_Coins();
    }
    void Movement_Coins()
    {
        transform.Rotate(0, 0, rotation_z * Time.deltaTime);

    }
    public void RandomValue()
    {
        value_coins = Random.Range(0, 20);
    }
    public int getCoins()
    {
        return value_coins;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement_Player>() != null)
        {
            points.Sumar_Coins(); //Acceso a script Coins_Points para puntuar desde el game manager
            Destroy(gameObject); //Destruccion del gameobject cuando lo toca el jugador
        }
    }
}
