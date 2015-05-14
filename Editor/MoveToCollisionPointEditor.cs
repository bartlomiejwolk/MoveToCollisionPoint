using OneDayGame;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace MoveToCollisionPointEx {

    [CustomEditor(typeof(MoveToCollisionPoint))]
    public class MoveToCollisionPointEditor : Editor {

        #region SERIALIZER PROPERTIES

        private SerializedProperty description;
        private SerializedProperty offset;
        private SerializedProperty targetTransform;

        #endregion SERIALIZER PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            DrawTargetField();
            DrawOffsetField();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnEnable() {
            offset = serializedObject.FindProperty("offset");
            targetTransform = serializedObject.FindProperty("targetTransform");
            description = serializedObject.FindProperty("description");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
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

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    MoveToCollisionPoint.Version,
                    MoveToCollisionPoint.Extension));
        }

        #endregion INSPECTOR CONTROLS

        #region METHODS

        [MenuItem("Component/MoveToCollisionPoint")]
        private static void AddMyClassComponent() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(MoveToCollisionPoint));
            }
        }

        #endregion METHODS
    }

}