using UnityEngine;
using System.Collections;
using UnityEditor;
using OneDayGame;

[CustomEditor(typeof(MoveToPoint))]
public class MoveToPointEditor : Editor {

	private SerializedProperty _collisionComponent;
	private SerializedProperty _offset;

	private void OnEnable() {
		_collisionComponent = serializedObject.FindProperty("_collisionComponent");
		_offset = serializedObject.FindProperty("_offset");
	}

	public override void OnInspectorGUI() {
		base.OnInspectorGUI();
		//TimeScaleDebug script = (TimeScaleDebug)target;
		serializedObject.Update();

		EditorGUILayout.PropertyField(_collisionComponent);
		EditorGUILayout.PropertyField(_offset);
		
		// Save changes
		/*if (GUI.changed) {
			EditorUtility.SetDirty(script);
		}*/
		serializedObject.ApplyModifiedProperties();
	}
}
