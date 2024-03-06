using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace Combat {
	[CreateAssetMenu(fileName = "�½�����������",menuName = "�Զ�/����������")]
	public class MoveSetInfo:ScriptableObject {
		[InspectorName("������")]
		public MoveInfo[] moves;
		[InspectorName("������")]
		public AnimatorOverrideController animations;

		public const int moveRunIndex = 4;
		public const int moveHaltIndex = 5;
	}



	[System.Serializable]
	public class MoveInfo {
		[InspectorName("�˺���Χ")]
		public Vector2Int damageRange;
		[InspectorName("�˺�����")]
		public DamageType damageType;
		[InspectorName("����")]
		public Vector2 relativeKnockback;
		[InspectorName("����ʱ��")]
		public int moveDuration;
		[InspectorName("�����������")]
		public float maxResetSpeed;
		[InspectorName("��߳�ʼ����")]
		public float maxInitialSpeed;
		[InspectorName("Ԥ��")]
		public GameObject previewObject;
		[InspectorName("��������")]
		public string moveName;
		[InspectorName("����ͼ��")]
		public Sprite moveIcon;

	}
}