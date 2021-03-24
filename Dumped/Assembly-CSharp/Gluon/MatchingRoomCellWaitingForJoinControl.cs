/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomCellWaitingForJoinControl : MonoBehaviour
	{
		// Fields
		public GameObject[] loadingCircles;
		public UnityEngine.UI.Text[] jumpingTexts;
		private const float inOutAnimationTime = 0.3f;
		private Sequence currentSequence;
		private const float circleRadius = 40f;
		private const float circleFadeDuration = 0.3f;
		private const float circleShowDuration = 0.8f;
		private const float circleHideDuration = 0.4f;
		private const float circleInterval = 0.18f;
		private Sequence[] loopSequences;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public int i;
			public MatchingRoomCellWaitingForJoinControl __4__this;
	
			// Constructors
			public __c__DisplayClass10_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1
		{
			// Fields
			public Transform t;
			public Image image;
			public __c__DisplayClass10_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass10_1();
	
			// Methods
			internal void _Awake_b__0();
		}
	
		// Constructors
		public MatchingRoomCellWaitingForJoinControl();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public void PlayWaiting();
		public void StopWaiting();
	}
}
