using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.UserInterfaceWindows;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DaggerfallUI.UIManager.OnWindowChange += (e,b) =>
        {
            if (DaggerfallUI.UIManager.TopWindow is DaggerfallInventoryWindow window)
            {
                window.OnItemHover += (c, d) => Debug.Log($"{c.weightInKg} and {c.value} and {(WeaponMaterialTypes)c.NativeMaterialValue}");  
            }
        };

    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
