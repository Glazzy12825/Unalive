using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersEssence : MonoBehaviour
{
    public float maxEssence = 120;
    public float currentEssence;

    //call the PlayerSanity and essence bar
    public PlayerSanity playerSanity;
    public EssenceBar essenceBar;

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);

    
   

    // Start is called before the first frame update
    void Start()
    {
        currentEssence = maxEssence; // starts at full essence
        essenceBar.SetMaxEssence(currentEssence); // sets the essence scroll bar to the currentEssence
       
    }

    // Update is called once per frame
    void Update()
    {
        if (currentEssence >= maxEssence)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                essenceUsed(maxEssence);
            }
        }
    }

    //Update is called on a fixed timer
    private void FixedUpdate()
    {
        EssenceRegen();
    }


    void essenceUsed(float usedEssence)
    {
        
        // can only be used at maxEssence
        if (currentEssence >= maxEssence )
        {
            print("e pressed");
            currentEssence -= usedEssence;
        }

        // regen essence
        if (currentEssence <= maxEssence)
        {
            StartCoroutine(EssenceRegen());
        }

        essenceBar.SetEssence(currentEssence);
    }

  private IEnumerator EssenceRegen()
    {
        while(currentEssence < maxEssence)
        {
            currentEssence += maxEssence / playerSanity.currentSanity;
            essenceBar.SetEssence(currentEssence);
            
            if (currentEssence >= maxEssence)
            {
                print("Essence is full");
            }
            else
            {
                print("Essence is not full");

            }

            yield return regenTick;
        }

    }

}
