using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject enemy;
    public float poskozeni;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack() 
    {
        enemy.GetComponent<EnemyStats>().LoseStamina(poskozeni);
    }
}
