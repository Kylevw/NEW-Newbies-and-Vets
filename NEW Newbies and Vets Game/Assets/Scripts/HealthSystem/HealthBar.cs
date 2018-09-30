using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private HealthSystem healthSystem;

    //will only update health when it changes
    public void Setup(HealthSystem healthSystem)
    {
        this.healthSystem = healthSystem;

        healthSystem.OnHealthChange += HealthSystem_OnHealthChange;
    }
    void HealthSystem_OnHealthChange(object sender, System.EventArgs e)
    {
        transform.Find("Bar").localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
    }

    private void Update()
    {

    }
}
