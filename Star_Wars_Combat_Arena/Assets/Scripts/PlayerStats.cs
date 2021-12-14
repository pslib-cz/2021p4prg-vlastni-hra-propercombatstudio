using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float zivoty;
    public float stamina;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetDamage (float poskozeni) 
    {
        zivoty -= poskozeni;
        if (zivoty <= 0) 
        {
            Destroy(transform.gameObject);
        }
    }

    public void LoseStamina (float poskozeni) 
    {
        stamina -= poskozeni;
        if (stamina <= 0) 
        {
            GetDamage(poskozeni);
        }
    }
}
