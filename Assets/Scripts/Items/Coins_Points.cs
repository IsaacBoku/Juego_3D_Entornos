using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins_Points : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI text_Coins;
    [SerializeField] private TextMeshProUGUI text_Gems;

    public Coins[] coins;

    [Header("Objects Points")]
    public int n_coins;
    public int n_Gems;
    private void Start()
    {
        //ContadorCoins();
    }
    private void Update()
    {
        UI_points();
    }
    private void ContadorCoins()
    {
        int n_random = Random.Range(0, coins.Length);
        Instantiate(coins[n_random]);

        for(int i = 0; i < coins.Length; i++)
        {
            var coinsInstanciate = Instantiate(coins[i]);
            coinsInstanciate.GetComponent<Coins>().RandomValue();

            if(coinsInstanciate.GetComponent<Coins>().getCoins() > 10)
            {
                coinsInstanciate.transform.position += new Vector3(0, 3f, 0);
            }
        }
    }
    public void UI_points()
    {
        string point_Coins = n_coins.ToString("Coins: "+ n_coins);
        text_Coins.text = point_Coins;

        string point_Gems = n_Gems.ToString("Gems: "+ n_Gems);
        text_Gems.text = point_Gems;
    }
    public int Sumar_Coins()
    {
        Debug.Log("1 Coin");
        return n_coins++;
        
    }
    public int Sumar_Gems()
    {
        Debug.Log("1 Gem");
        return n_Gems++;
    }
}
