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
	public class ContactHeartControl : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Transform targetPosition;
		public MoveSetting[] moveSetting;
		public TweenSequenceVisualizer touchTargetEffect;
		[HideInInspector]
		public ContactReliabilitySlider reliabilitySlider;
		private bool motionKilled;
	
		// Nested types
		[Serializable]
		public class MoveSetting
		{
			// Fields
			public Transform heartParent;
			public TweenSequenceVisualizer heartMotion;
			public float initRotateZ;
			public float initScale;
			public float finishRotationZ;
			public float initDelay;
			public float delay;
			public float jumpPower;
			public float duration;
			public float angleDurationReduce;
			public const float finalOffsetY = 142.45f;
			public const float finalScale = 0.6f;
			private Sequence seq;
			private Vector3 parentInitPosition;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass14_0
			{
				// Fields
				public Vector3 p0;
				public Vector3 p1;
				public Vector3 p2;
				public Vector3 p3;
				public MoveSetting __4__this;
				public Vector3 lastP;
				public Action onTouch;
	
				// Constructors
				public __c__DisplayClass14_0();
	
				// Methods
				internal void _DoMotion_b__0(float t);
				internal void _DoMotion_b__1();
			}
	
			// Constructors
			public MoveSetting();
	
			// Methods
			public void DoMotion(Vector3 targetPosition, Action onShowEffect, Action onTouch);
			public void KillMotion();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public ContactHeartControl __4__this;
			public int arrivalCount;
			public Action<int> onAllCompleted;
			public int carry;
			public int targetLevel;
			public Action<float> __9__2;
			public Action __9__0;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _PlayEffect_b__0();
			internal void _PlayEffect_b__2(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_1
		{
			// Fields
			public int carryingReliability;
			public __c__DisplayClass6_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass6_1();
	
			// Methods
			internal void _PlayEffect_b__1();
		}
	
		// Constructors
		public ContactHeartControl();
	
		// Methods
		public void PlayEffect(int carry, Action<int> onAllCompleted, int targetLevel, Action onTargetLevelReached);
		public void KillEffect();
	}
}
