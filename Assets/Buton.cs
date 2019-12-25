using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton : MonoBehaviour
{
    [SerializeField]
    private Transform downTransform;

    private Vector3 basePos;
    
    
    // Start is called before the first frame update
    void Start()
    {
        basePos= this.transform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerEnter(Collider  col) {
       
        //this.transform.position  = baseTransform.position;
    }

    void  OnTriggerStay(Collider  col) {
        this.transform.localPosition  = downTransform.localPosition;

    }

    void  OnTriggerExit(Collider  col) {
        
        this.transform.localPosition = basePos;
    }
}
