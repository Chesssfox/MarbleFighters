using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace Combat {
	[CreateAssetMenu(fileName = "�½�����������",menuName = "�Զ�/����������")]
	public class MoveSetInfo:ScriptableObject {
		public MoveInfo[] moves;
		public AnimatorController animations;
	}



	[System.Serializable]
	public class MoveInfo {
		public Vector2Int damageRange;
		public DamageType damageType;
		public Vector2 relativeKnockback;
		public GameObject previewobject;
		public int moveDuration;
		public float maxInitialSpeed;
	}
}