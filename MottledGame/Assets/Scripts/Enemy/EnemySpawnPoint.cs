using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class EnemySpawnPoint : EditorWindow
{
    private GameObject enemyParent;
    private GameObject emptyObj;

    private Transform firstObjPoint;

    [MenuItem("Expand/Set Spawn Point")]
    static void Init()
    {
        EditorWindow.GetWindow<EnemySpawnPoint>(true, "Set UP");
    }

    private void OnGUI()
    {
        try
        {
            enemyParent = EditorGUILayout.ObjectField("enemyParent", enemyParent, typeof(GameObject), true) as GameObject;
            emptyObj = EditorGUILayout.ObjectField("empty", emptyObj, typeof(GameObject), true) as GameObject;
            firstObjPoint = EditorGUILayout.ObjectField("firstObjPoint", firstObjPoint, typeof(Transform), true) as Transform;

            if (GUILayout.Button("Create")) PointCreate();
        }
        catch (System.FormatException) { }
    }

    private void PointCreate()
    {

    }

}
