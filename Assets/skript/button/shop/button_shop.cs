using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_shop : MonoBehaviour
{
    public GameObject panel_shop_1;
    public GameObject panel_shop_2;
    public GameObject panel_shop_3;

    //shop number 1
    public void open_shop_1()
    {
        panel_shop_1.SetActive(true);
    }
    public void exit_shop_1()
    {
        panel_shop_1.SetActive(false);
    }
    // shop number 2
    public void open_shop_2()
    {
        panel_shop_2.SetActive(true);
    }
    public void exit_shop_2()
    {
        panel_shop_2.SetActive(false);
    }
    // shop number 3
    public void open_shop_3()
    {
        panel_shop_3.SetActive(true);
    }
    public void exit_shop_3()
    {
        panel_shop_3.SetActive(false);
    }
}
