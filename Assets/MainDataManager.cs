using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDataManager : MonoBehaviour
{
    [SerializeField] private int encryptionKey;
    void Start()
    {
        if (!PlayerPrefs.HasKey("money"))
        {
            PlayerPrefs.SetInt("money", 0^encryptionKey);
        }
        if(!PlayerPrefs.HasKey("soldboba"))
        {
            PlayerPrefs.SetInt("soldboba", 0^encryptionKey);
        }
    }

    [SerializeField] public Text moneyDisplay, soldBobaDisplay;
    public void resetUserData()
    {
        PlayerPrefs.DeleteAll();
        int data = 0^encryptionKey;
        PlayerPrefs.SetInt("money", data);
        PlayerPrefs.SetInt("soldboba", data);
        moneyDisplay.text = "Current money: 0";
        soldBobaDisplay.text = "Sold Boba(s): 0";
    }

    public void OnSellBobaButtonClick()
    {
        System.Random r = new System.Random();
        int money = PlayerPrefs.GetInt("money", 0)^encryptionKey;
        int soldBoba = PlayerPrefs.GetInt("soldboba", 0)^encryptionKey;
        soldBoba += 1;
        int temp = r.Next(1, 50);
        Debug.Log($"{temp} : {money}");
        money += temp;
        moneyDisplay.text = "Current money: "+money.ToString();
        soldBobaDisplay.text = "Sold Boba(s): "+soldBoba.ToString();
        PlayerPrefs.SetInt("money", money ^ encryptionKey);
        PlayerPrefs.SetInt("soldboba", soldBoba ^ encryptionKey);
    }
}
