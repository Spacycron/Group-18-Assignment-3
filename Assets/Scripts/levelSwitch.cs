using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSwitch : MonoBehaviour
{


    GameManager GameManager;
    public string nextlevel;




    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            if (GameManager.levelComplete)
            {
                SceneManager.LoadScene(nextlevel);
            }
        }
    }
    
        
    





    // Update is called once per frame
    void Update()
    {
        
    }
}
