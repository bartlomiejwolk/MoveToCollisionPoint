using UnityEngine;
using System.Collections;
using UnityEditor;
using OneDayGame;

namespace MoveToPoint {

    [CustomEditor(typeof (Move))]
    public class MoveEditor : Editor {

        private SerializedProperty offset;
        private SerializedProperty targetTransform;
        private SerializedProperty description;

        private void OnEnable() {
            offset = serializedObject.FindProperty("offset");
            targetTransform = serializedObject.FindProperty("targetTransform");
            description = serializedObject.FindProperty("description");
        }

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

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

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    Move.Version,
                    Move.Extension));
        }
        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }
        #region METHODS

        [MenuItem("Component/MoveToPoint")]
        private static void AddMyClassComponent() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(Move));
            }
        }

        #endregion METHODS
    }

}
