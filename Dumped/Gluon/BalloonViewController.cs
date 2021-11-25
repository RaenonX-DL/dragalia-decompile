using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class BalloonViewController : FastUpdateMonoBehaviour
	{
		[Serializable]
		public struct BalloonGradeOffsetInfo
		{
			public Vector3[] gradeOffsets;
		}

		[SerializeField]
		[Header("å\u0090¹ã\u0081\u008då\u0087ºã\u0081\u0097ç\u0094»å\u0083\u008fã\u0083ªã\u0082¹ã\u0083\u0088")]
		private Sprite[] balloonImages;

		[SerializeField]
		[Header("å\u0090¹ã\u0081\u008då\u0087ºã\u0081\u0097ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083©")]
		private SpriteRenderer balloonRenderer;

		[SerializeField]
		private GameObject balloonOffsetTarget;

		[SerializeField]
		private Transform balloonElementsBinder;

		[SerializeField]
		private BalloonGradeOffsetInfo[] balloonGradeOffsetInfos;

		[SerializeField]
		private float fixedDispSizeDistance;

		private Vector3 initialBalloonScale;

		private Vector3 initialBalloonPosition;

		private Vector3 animationOffset;

		[HideInInspector]
		public bool isBallonReady;

		[HideInInspector]
		public Action onBallonReady;

		public bool isFirstSetting;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetAnimation()
		{
		}

		private void SetAnimationImple(bool isUpdate)
		{
		}

		public void UpdateAnimationPos()
		{
		}

		protected void OnDestroy()
		{
		}

		public void SetImage(MaterialHarvester.HarvestType type, Facility.eFacilityModelGrade grade)
		{
		}

		private Sprite GetGivenTypeImage(MaterialHarvester.HarvestType type)
		{
			return null;
		}

		public override void FastUpdate()
		{
		}
	}
}
