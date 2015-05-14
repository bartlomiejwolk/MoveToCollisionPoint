using UnityEngine;
using System.Collections;

namespace MoveToPoint {

    public class Move : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "MoveToPoint";

        #endregion

        #region INSPECTOR FIELDS
        #endregion

        #region INSPECTOR FIELDS
        [SerializeField]
        private string description = "Description";

        [SerializeField]
        private Transform targetTransform;


        /// <summary>
        /// Offset hit position forward/backward.
        /// </summary>
        [SerializeField]
        private float offset;

        #endregion

        #region PROPERTIES
        public Transform TargetTransform {
            get { return targetTransform; }
            set { targetTransform = value; }
        }

        /// <summary>
        /// Offset hit position forward/backward.
        /// </summary>
        public float Offset {
            get { return offset; }
            set { offset = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region METHODS

        public void MoveToHitPoint(RaycastHit hitInfo) {
            if (TargetTransform == null) return;

                TargetTransform.position = hitInfo.point
                    + (hitInfo.point - TargetTransform.position).normalized
                    * Offset;
        }

        #endregion
    }

}
