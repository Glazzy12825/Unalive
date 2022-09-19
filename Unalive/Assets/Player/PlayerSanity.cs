using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSanity : MonoBehaviour
{
    public float maxSanity = 80.0f;
    public float currentSanity;

    public SanityBar sanityBar;

    // Start is called before the first frame update
    void Start()
    {

        currentSanity = maxSanity;
        sanityBar.SetMaxSanity(maxSanity);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            GiveHealth(20);
        }
    }

    void TakeDamage(float damage)
    {
        if(currentSanity > 0)
        {
            currentSanity -= damage;
        }
        
        sanityBar.SetSanity(currentSanity);
    }

    void GiveHealth(float Health)
    {
        if (currentSanity < 100)
        {
            currentSanity += Health;
        }
        
        sanityBar.SetSanity(currentSanity);
    }

}
