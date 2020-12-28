using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
   // int count = 0;
  //  public static int eggs;
    //  public GameObject playerscore;
    public GameObject Gift;
    private void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        // count += 1;
        // eggs = count;
        PlayerScore.eggs += 1;
        //    playerscore.gifts();
        //   PlayerScore.gifts();

        Destroy(this.gameObject);
        Gift.GetComponent<PlayerScore>().Gifts();
       // this.gameObject.SetActive(false);

        
    }

    


}
