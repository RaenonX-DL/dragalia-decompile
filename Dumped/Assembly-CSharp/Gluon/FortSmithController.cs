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
	public class FortSmithController : MonoBehaviour
	{
		// Fields
		private SmithState state;
		protected animationEndDelegate animationEndCallback;
		[CompilerGenerated]
		private Animator _animator_k__BackingField;
		private bool _isDisp;
		[Header]
		[SerializeField]
		public float fallDistance;
		public float moveDuration;
		private float effDuration;
		private float totalTime;
		public float buildEffectPosOffset;
		private Vector3 offsetVec;
		[Header]
		[SerializeField]
		private float effectPosOffsetDis;
		[SerializeField]
		private Transform transCenter;
		private bool _isAreeaExtension;
		private Renderer[] smithRenderers;
		private EffectObject effectObj;
		private Renderer[] effectRenderers;
		private int buildSECount;
		[SerializeField]
		private int buildSEMaxCount;
		[SerializeField]
		private float volumnFadeOutFactor;
		private Vector3 buildPos;
		private Tweener idleMoveTweener;
		private const float reverseSmithRotationX = 60f;
		private static readonly Vector3 reverseSmithRotationEuler;
	
		// Properties
		public Animator animator { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isDisp { get; set; }
		public bool isAreeaExtension { get; set; }
	
		// Nested types
		public enum SmithState
		{
			None = 0,
			Born = 1,
			AfterBornAnimation = 2,
			Idle = 3,
			Build = 4,
			AfterBuildAnimation = 5,
			Quit = 6,
			Destroy = 7
		}
	
		public delegate void animationEndDelegate();
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public FortSmithController __4__this;
			public Vector3 targetPos;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _MoveUpward_b__0();
		}
	
		// Constructors
		public FortSmithController();
		static FortSmithController();
	
		// Methods
		public void AddAnimationEndCallback(animationEndDelegate callback);
		private void Start();
		private void Update();
		private Vector3 GetBornEffectPos(Vector3 targetPos);
		public void SetState(SmithState smithState);
		public void ShowBuildEffect();
		public void MoveUpward();
		public void Disp(bool flag);
		private void SetEffectOrder(GameObject go, Vector3 targetPos);
		private Vector3 GetEffectPosOffset();
		public void ShowQuitAnimation();
		private void OnDestroy();
		private Vector3 GetRisingRotation(Quaternion localRotation);
		[CompilerGenerated]
		private void _Update_b__36_0();
	}
}
