using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Glucose))]
public class GlucoseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        Glucose mySugarLevel = (Glucose) target;

        mySugarLevel.bloodPrefab = (GameObject) EditorGUILayout.ObjectField(mySugarLevel.bloodPrefab, typeof(GameObject), true);

        mySugarLevel.A1C = EditorGUILayout.FloatField("Variante Glicêmica", mySugarLevel.A1C);



        EditorGUILayout.LabelField("Nível de Açúcar no Sangue (mg/dL)", mySugarLevel.nivelGlicose.ToString());

        EditorGUILayout.HelpBox("Calcule Seu Nível de Açúcar!", MessageType.Info);

        if(mySugarLevel.nivelGlicose <= 70)
        {
            EditorGUILayout.HelpBox("Nível: Hipoglicemia", MessageType.Warning);
        }
        else if(mySugarLevel.nivelGlicose > 70 && mySugarLevel.nivelGlicose <= 100)
        {
            EditorGUILayout.HelpBox("Nível: Normal", MessageType.Info);
        }
        else if(mySugarLevel.nivelGlicose > 100 && mySugarLevel.nivelGlicose <= 125)
        {
            EditorGUILayout.HelpBox("Nível: Glicemia Alterada", MessageType.Warning);
        }
        else if (mySugarLevel.nivelGlicose > 125)
        {
            EditorGUILayout.HelpBox("Nível: Hiperglicemia", MessageType.Error);
        }


        GUI.color = Color.red;

        if(GUILayout.Button("Create Blood"))
        {
            mySugarLevel.CreateBlood();
        }
    }
}
