using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FINISH : MonoBehaviour
{
   // public GameObject winpanel;
    //public GameObject losepannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(gameObject.tag=="finish")
        {
            if(other.tag=="Player")
            {
                SceneManager.LoadScene(2);

            }
            if (other.tag=="ENEMY")
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
