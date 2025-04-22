using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gasoline : MonoBehaviour
{
    public Image gasBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gasBar.fillAmount -= Input.GetAxis("Horizontal") / 10000f;
    }

    public void AddFuel()
    {
        gasBar.fillAmount += 0.1f;
    }
}
