using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if ((SceneManager.GetActiveScene().name == "FirstLevel" && stamina < 100) || 
            (SceneManager.GetActiveScene().name == "SecondLevel" && stamina < 150) || 
            (SceneManager.GetActiveScene().name == "ThirdLevel" && stamina < 200)) 
        {
            stamina++;
        }
    }

    private void GetDamage (float poskozeni) 
    {
        zivoty -= poskozeni;
        if (zivoty <= 0) 
        {
            SceneManager.LoadScene("FirstLevel");
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
