using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_menu_shop : MonoBehaviour
{
    public GameObject button_buyer;
    public GameObject button_fishing_rod_shop;
    public GameObject button_boat_shop;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "buyer")
        {
            button_buyer.SetActive(true);
        }
        if (collision.gameObject.tag == "shop_udochek")
        {
            button_fishing_rod_shop.SetActive(true);
        }
        if (collision.gameObject.tag == "boat_shop")
        {
            button_boat_shop.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "buyer")
        { 
            button_buyer.SetActive(false);
        }
        if (collision.gameObject.tag == "shop_udochek")
        {
            button_fishing_rod_shop.SetActive(false);
        }
        if (collision.gameObject.tag == "boat_shop")
        {
            button_boat_shop.SetActive(false);
        }
    }
    // shop_udochek
}

