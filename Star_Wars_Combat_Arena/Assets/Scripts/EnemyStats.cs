using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStats : MonoBehaviour
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
            switch (SceneManager.GetActiveScene().name) 
            {
                case "FirstLevel":
                    SceneManager.LoadScene("SecondLevel");
                    break;
                case "SecondLevel":
                    SceneManager.LoadScene("ThirdLevel");
                    break;
                case "ThirdLevel":
                    Application.Quit();
                    break;
                default:
                    SceneManager.LoadScene("FirstLevel");
                    break;
            }
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
