using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace Combat {
	[CreateAssetMenu(fileName = "�½�����������",menuName = "�Զ�/����������")]
	public class MoveSetInfo:ScriptableObject {
		public MoveInfo[] moves;
		public AnimatorOverrideController animations;

		public const float moveRunIndex = 4;
		public const float moveHaltIndex = 5;
	}



	[System.Serializable]
	public class MoveInfo {
		[InspectorName("�˺���Χ")]
		public Vector2Int damageRange;
		[InspectorName("�˺�����")]
		public DamageType damageType;
		[InspectorName("����")]
		public Vector2 relativeKnockback;
		[InspectorName("Ԥ��")]
		public GameObject previewObject;
		[InspectorName("����ʱ��")]
		public int moveDuration;
		[InspectorName("�����������")]
		public float maxResetSpeed;
		[InspectorName("��߳�ʼ����")]
		public float maxInitialSpeed;
	}
}