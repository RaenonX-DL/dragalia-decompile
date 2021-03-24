/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortAreaExtensionController : MonoBehaviour
	{
		// Fields
		[Header]
		[Header]
		[SerializeField]
		[Tooltip]
		private float step1WaitTime;
		[SerializeField]
		[Tooltip]
		private float step1BackMoveDistance;
		[SerializeField]
		[Tooltip]
		private float step1BackMoveDuration;
		[SerializeField]
		[Tooltip]
		private Ease step1Easing;
		[Header]
		[SerializeField]
		[Tooltip]
		private float[] mainFacilityLvUpMoveSpeeds;
		private const float defaultSpeed = 30f;
		[SerializeField]
		[Tooltip]
		private Ease step2Easing;
		[Header]
		[SerializeField]
		[Tooltip]
		private Vector3[] smithPosDiff;
		[SerializeField]
		[Tooltip]
		private float step3WorkingWait;
		[SerializeField]
		[Tooltip]
		private float step3VanishingWait;
		[SerializeField]
		[Tooltip]
		private float step3ExtensionWait;
		[SerializeField]
		[Tooltip]
		private float step3FadeOutDuration;
		[Header]
		[Header]
		[SerializeField]
		[Tooltip]
		private float step4FadeOutKeepWait;
		[SerializeField]
		[Tooltip]
		private float step4FadeInDuration;
		private Sequence sequence;
		private GameObject[] dragonSmithObjs;
		private bool isFadingOut;
		private readonly float areaExtensionEffectAdjustY;
		private readonly float completeEffectAdjustY;
	
		// Nested types
		public enum FinishFlashAnimType
		{
			AreaExtension = 0,
			Complete = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public FacilityViewController facilityViewController;
			public FortAreaExtensionController __4__this;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _OnFinishedMainFacilityFocusAnim_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_1
		{
			// Fields
			public Vector3 newAreaPos;
			public Transform cameraCtrlTransform;
			public __c__DisplayClass20_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass20_1();
	
			// Methods
			internal void _OnFinishedMainFacilityFocusAnim_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public FortAreaExtensionController __4__this;
			public Vector3 areaGroundPos;
			public FinishFlashAnimType type;
			public FacilityViewController facilityViewController;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _OnFinishSmishAnim_b__0();
			internal void _OnFinishSmishAnim_b__1();
			internal void _OnFinishSmishAnim_b__2();
			internal void _OnFinishSmishAnim_b__3();
			internal void _OnFinishSmishAnim_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__23_5;
			public static Action __9__23_6;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFinishSmishAnim_b__23_5();
			internal void _OnFinishSmishAnim_b__23_6();
		}
	
		// Constructors
		public FortAreaExtensionController();
	
		// Methods
		public void OnFinishedMainFacilityFocusAnim(FacilityViewController facilityViewController);
		public void PlayDragonSmithTrioBuildAnimation(Vector3 newAreaPos, Transform cameraCtrlTransform, FacilityViewController facilityViewController, FinishFlashAnimType type = FinishFlashAnimType.AreaExtension);
		public void OnFinishSmishRemoveTrigger();
		public void OnFinishSmishAnim(FacilityViewController facilityViewController, Vector3 areaGroundPos, FinishFlashAnimType type);
		private void SetEffectOrder(EffectObject eo);
		public void QuitAreaExtensionAnimation();
	}
}
