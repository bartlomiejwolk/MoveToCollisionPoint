using UnityEngine;
using System.Collections;

namespace MoveToPoint {

    public class MoveToPoint : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "MoveToPoint";

        #endregion
        
        /// <summary>
        /// Offset hit position forward/backward.
        /// </summary>
        [SerializeField]
        private float offset;

        [SerializeField]
        private Transform targetTransform;

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

        public void MoveToHitPoint(RaycastHit hitInfo) {
            if (TargetTransform == null) return;

                TargetTransform.position = hitInfo.point
                    + (hitInfo.point - TargetTransform.position).normalized
                    * Offset;
            }
        }
}
