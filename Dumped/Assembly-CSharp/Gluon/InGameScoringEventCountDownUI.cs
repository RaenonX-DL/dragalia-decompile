/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameScoringEventCountDownUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _adjustRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _animRt;
		[SerializeField]
		private SpriteRenderer _numberImage_10;
		[SerializeField]
		private SpriteRenderer _numberImage_01;
		[SerializeField]
		private SpriteRenderer _leftTextImage;
		[SerializeField]
		private SpriteRenderer _rightTextImage;
		[Header]
		[SerializeField]
		private TimeData[] _timeDataArray_jp;
		[SerializeField]
		private TimeData[] _timeDataArray_us;
		[SerializeField]
		private TimeData[] _timeDataArray_cn;
		[SerializeField]
		private TimeData[] _timeDataArray_tw;
		private RectTransform _numberImageRt_10;
		private RectTransform _numberImageRt_01;
		private RectTransform _leftTextImageRt;
		private RectTransform _rightTextImageRt;
		private VisibleUIObject _rootVisible;
		private Sequence _seqAnim;
		private float _lastTime;
	
		// Nested types
		[Serializable]
		private class TimeData
		{
			// Fields
			public float time;
			[Header]
			public Vector3 leftTextPos;
			public Vector3 rightTextPos;
			public Vector3 leftTextScale;
			public Vector3 rightTextScale;
			[Header]
			public Sprite numberImage_10;
			public Sprite numberImage_01;
			public Vector3 numberPos_10;
			public Vector3 numberPos_01;
			public Vector3 numberScale_10;
			public Vector3 numberScale_01;
	
			// Constructors
			public TimeData();
		}
	
		// Constructors
		public InGameScoringEventCountDownUI();
	
		// Methods
		public static InGameScoringEventCountDownUI Create(GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize();
		private void OnDestroy();
		public void SetTime(float time, bool isForce = false, bool isPlayAnim = true);
		private void PlayAnim10();
		private void PlayAnim01();
		private void OnUpdateAnim(float t, float startFade, float endFade, float startPosY, float endPosY);
		private void SetPosY(float value);
		private void SetFade(float value);
		private void SetFade(SpriteRenderer obj, float value);
		private TimeData[] GetTimeDataArray();
		[CompilerGenerated]
		private void _PlayAnim10_b__23_1(float t);
		[CompilerGenerated]
		private void _PlayAnim10_b__23_2(float t);
		[CompilerGenerated]
		private void _PlayAnim10_b__23_0();
		[CompilerGenerated]
		private void _PlayAnim01_b__24_1(float t);
		[CompilerGenerated]
		private void _PlayAnim01_b__24_2(float t);
		[CompilerGenerated]
		private void _PlayAnim01_b__24_0();
	}
}
