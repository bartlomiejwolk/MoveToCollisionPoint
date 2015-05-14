using UnityEngine;
using System.Collections;
using UnityEditor;
using OneDayGame;

[CustomEditor(typeof(MoveToPoint))]
public class MoveToPointEditor : Editor {

    private SerializedProperty offset;
    private SerializedProperty targetTransform;

    private void OnEnable() {
        offset = serializedObject.FindProperty("offset");
        targetTransform = serializedObject.FindProperty("targetTransform");
    }

    public override void OnInspectorGUI() {
        serializedObject.Update();

        DrawTargetField();
        DrawOffsetField();

        serializedObject.ApplyModifiedProperties();
    }

    private void DrawOffsetField() {
        EditorGUILayout.PropertyField(
            offset,
            new GUIContent(
                "Offset",
                "Offsets end position forward or backward."));
    }

    private void DrawTargetField() {
        EditorGUILayout.PropertyField(
            targetTransform,
            new GUIContent(
                "Target",
                "Transform to be moved."));
    }

}
