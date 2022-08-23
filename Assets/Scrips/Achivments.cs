using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Achivments : MonoBehaviour
{
    public int money;
    public int total_money;
    public Text money_score;
    public bool get_10_money = false;
    public bool get_100_money = false;
    public bool get_1000_money = false;
    //  private Color colors_button;
    public Button button_get_10_money;
    public Button button_get_100_money;
    public Button button_get_1000_money;
    public Button button_get_10_click_x1;
  //  private int achivments = 0;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
       total_money = PlayerPrefs.GetInt("total_money");
        get_10_money = PlayerPrefs.GetInt("get_10_money") == 1 ? true : false;
        get_100_money = PlayerPrefs.GetInt("get_100_money") == 1 ? true : false;
        get_1000_money = PlayerPrefs.GetInt("get_1000_money") == 1 ? true : false;
        StartCoroutine(IdleFarm());
    }
    public void ToHome()
    {
        PlayerPrefs.SetInt("money", money);
        SceneManager.LoadScene(0);
    }
    public void Achivment_money(int money_to_achivment)
    {
        money += money_to_achivment;
        total_money += money_to_achivment;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }
    // Update is called once per frame
    void Update()
    {
        if (total_money >= 10 && get_10_money == false)
        {
            button_get_10_money.interactable = true;
            get_10_money = true;
            PlayerPrefs.SetInt("get_10_money", get_10_money ? 1 : 0);
        }

        if (total_money >= 100 && get_100_money == false)
        {
            button_get_100_money.interactable = true;
            get_100_money = true;
            PlayerPrefs.SetInt("get_100_money", get_100_money ? 1 : 0);
        }

        if (total_money >= 1000 && get_1000_money == false)
        {
            button_get_1000_money.interactable = true;
            get_1000_money = true;
            PlayerPrefs.SetInt("get_1000_money", get_1000_money ? 1 : 0);
        }

        money_score.text = money.ToString();
    }
    IEnumerator IdleFarm()
    {
        yield return new WaitForSeconds(1);
        money += 1;
        total_money += 1;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
        StartCoroutine(IdleFarm());
    }
}
