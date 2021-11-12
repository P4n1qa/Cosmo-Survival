using UnityEngine;
using UnityEngine.UI;
public class FuelMeter : MonoBehaviour
{
    public Text fuelText;
    public static int fuel;
    public GameObject win;
    public HeroHealth heroHealth;

    private void Start()
    {
        fuel = 0;
        heroHealth = GameObject.Find("Player").GetComponent<HeroHealth>();
    }
    void Update()
    {
        fuelText.text= "Fuel " +fuel + "/5";
         if (fuel == 5)
        {
            fuel = 5;
            win.SetActive(true);
            Time.timeScale = 0;
        }
        if (fuel == 0 && heroHealth.hp == 3)
        {
            Time.timeScale = 1;
        }

    }

}
