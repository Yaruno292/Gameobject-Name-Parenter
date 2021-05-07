using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NameReParenter))]
public class NameReParenterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        NameReParenter reParenter = (NameReParenter)target;
        if (GUILayout.Button("Combine"))
        {
            reParenter.ReParent();
        }
    }
}
