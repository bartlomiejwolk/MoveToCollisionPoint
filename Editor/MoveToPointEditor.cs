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
		base.OnInspectorGUI();
		serializedObject.Update();

		EditorGUILayout.PropertyField(targetTransform);
		EditorGUILayout.PropertyField(offset);

		serializedObject.ApplyModifiedProperties();
	}
}
