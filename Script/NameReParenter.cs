using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameReParenter : MonoBehaviour
{
    [SerializeField] private GameObject newParent = null;
    [SerializeField] private GameObject oldParent = null;

    private void Start()
    {
        ReParent();
    }

    private void ReParent()
    {
        Transform[] oldParents = oldParent.GetComponentsInChildren<Transform>();
        Transform[] newParents = newParent.GetComponentsInChildren<Transform>();

        //Sets all oldparents to newparents when name matches
        for (int i = 0; i < newParents.Length; i++)
        {
            for (int j = 0; j < oldParents.Length; j++)
            {
                if (oldParents[j].name == newParents[i].name)
                {
                    //places under same name
                    oldParents[j].tag = "Finish";
                    oldParents[j].SetParent(newParents[i]);
                }
            }
        }

        //Sets all oldparents with unmatching names to right parent
        for (int i = 0; i < oldParents.Length; i++)
        {
            if (oldParents[i].tag == "Untagged")
            {
                Transform[] unMatchedKids = oldParents[i].GetComponentsInChildren<Transform>();
                for (int j = 0; j < unMatchedKids.Length; j++)
                {
                    unMatchedKids[j].tag = "Finish";
                }

                oldParents[i].SetParent(oldParents[i].parent.parent);
            }
        }

        //Clears all Tags
        for (int i = 0; i < oldParents.Length; i++)
        {
            if (oldParents[i].tag == "Finish")
            {
                oldParents[i].tag = "Untagged";
            }
        }
    }
}
