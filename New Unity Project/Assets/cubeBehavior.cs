using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehavior : MonoBehaviour
{
    public float decimalNumber;
        
    void Start()
    {
        decimalNumber = 1.11f;
    }

    void Update()
    {
        MoveMyObjectAlongAVector(this.transform, Vector3.up * Time.deltaTime);
    }
         float GiveMeTheSum(float numberA, float numberB)
    { float numberSum = numberA + numberB;
    return numberSum
}
  //  void MoveMyObjectAlongAVector(Transform theTransformThatNeedToBeMoved, Vector3)