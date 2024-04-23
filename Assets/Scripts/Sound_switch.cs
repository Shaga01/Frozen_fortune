using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_switch : MonoBehaviour
{
    [SerializeField] Image on;
    [SerializeField] Image off;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void soundOn()
    {
        off.gameObject.SetActive(true);
    }
}
