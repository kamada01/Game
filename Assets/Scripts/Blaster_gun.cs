using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster_gun : MonoBehaviour, InventoryItem
{
    public string Name
    {
        get { return "Blaster_gun"; }
    }

    public Sprite _Image = null;
    public Sprite Image
    {
        get { return _Image;  }
    }
    public void OnPickup()
    {
        gameObject.SetActive(false);
    }
}
