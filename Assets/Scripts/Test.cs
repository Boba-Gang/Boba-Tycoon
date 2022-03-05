using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public void earnMoney_click(TextMeshProUGUI display) {
        int currentMoney = PlayerPrefs.GetInt("money", 0);
        PlayerPrefs.SetInt("money", currentMoney + 1);
        display.text = $"Current Money:{currentMoney+1}";
    }
}
