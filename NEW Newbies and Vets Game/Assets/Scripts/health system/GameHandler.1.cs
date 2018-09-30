﻿using UnityEngine;
//using CodeMonkey;

public class GameHandler : MonoBehaviour
{
	//initizlixe healthbar
	public Transform pfHealthBar;

  
    private void Start()
    {
		//connect healthsystem and healthbar
        HealthSystem healthSystem = new HealthSystem(100);


		Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0, 10), Quaternion.identity);
		HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();	
		healthBar.Setup(healthSystem);

		Debug.Log("Health: " + healthSystem.GetHealthPercent());
		healthSystem.Damage(10);
		Debug.Log("Health: " + healthSystem.GetHealthPercent());


        //damage button
		/*CMDebug.ButtonUI(new Vector2(100, 100), "Damage", () =>
		  {
			  healthSystem.Damage(10);
			  Debug.Log("Damaged: " + healthSystem.GetHealth());
		  });

        //heal button
        CMDebug.ButtonUI(new Vector2(-100, 100), "Heal", () =>
        {
            healthSystem.Heal(10);
            Debug.Log("Healed: " + healthSystem.GetHealth());
        });*/
    }
}
