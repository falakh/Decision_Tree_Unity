using UnityEngine;
using UnityEngine.Serialization;

namespace a
{
    public class DecisionsC : DECISIONnode
    {
         public int Jarak;
        //overide this methode use your own logic 
        public override bool testDecision()
        {
            Debug.Log("decision C hasil " + (Jarak > 30));
            return (Jarak > 30);
        }
    }
}