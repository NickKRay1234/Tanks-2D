using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{
    private Inventory _inventory;

    public void OnEnable()
    {
        _inventory = (Inventory)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(_inventory.Items.Count > 0)
        {

        }
        else
        {
            EditorGUILayout.LabelField("Инвентарь пустой! Предметов нет!");
        }
        if (GUILayout.Button("Добавить предмет", GUILayout.Width(300), GUILayout.Height(20)))
            _inventory.Items.Add(new Inventory.Item());
    }



}
