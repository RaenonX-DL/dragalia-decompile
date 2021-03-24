/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BalloonViewController : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Sprite[] balloonImages;
		[Header]
		[SerializeField]
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
	
		// Nested types
		[Serializable]
		public struct BalloonGradeOffsetInfo
		{
			// Fields
			public Vector3[] gradeOffsets;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public Vector3 animationStartPosition;
			public BalloonViewController __4__this;
			public bool isUpdate;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _SetAnimationImple_b__0();
		}
	
		// Constructors
		public BalloonViewController();
	
		// Methods
		private void Awake();
		private void Start();
		public void SetAnimation();
		private void SetAnimationImple(bool isUpdate);
		public void UpdateAnimationPos();
		protected void OnDestroy();
		public void SetImage(MaterialHarvester.HarvestType type, Facility.eFacilityModelGrade grade);
		private Sprite GetGivenTypeImage(MaterialHarvester.HarvestType type);
		public override void FastUpdate();
	}
}
