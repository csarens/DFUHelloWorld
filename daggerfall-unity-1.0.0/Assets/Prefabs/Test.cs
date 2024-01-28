using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.UserInterfaceWindows;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private DaggerfallUI UI;
    private DaggerfallInventoryWindow _window;
    // Start is called before the first frame update
    void Start()
    {

        UI = GetComponent<DaggerfallUI>();
        _window = UI.InventoryWindow;
        _window.OnItemHover += (e, b) =>
        {
            Debug.Log($"{e.weightInKg} and {e.value} and {(WeaponMaterialTypes)e.NativeMaterialValue}");
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
