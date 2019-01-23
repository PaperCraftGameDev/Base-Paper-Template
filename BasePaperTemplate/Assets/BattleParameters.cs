using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleParameters : MonoBehaviour {

    public static BattleParameters battleParameters;

    //put savable parameters here

    private void Awake()
    {
        if(battleParameters == null)
        {
            battleParameters = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(battleParameters != this)
        {
            Destroy(gameObject);
        }
    }

}
