/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Dungeon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChatIconUIIngame : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private MoveChatIcon moveChatIcon;
		[SerializeField]
		private RectTransform offsetRt;
		[SerializeField]
		private SpriteRenderer iconImage;
		[SerializeField]
		private SpriteRenderer numberImage;
		[SerializeField]
		private SpriteRenderer frameImage;
		[SerializeField]
		private SpriteRenderer arrowImage;
		[Header]
		[SerializeField]
		private Sprite[] numberSprite;
		private VisibleUIObject _rootVisible;
		private CharacterBase _currentTargetChara;
		private Sequence _seqEffect;
		private int _playerIndex;
		private int _stampId;
		private float _stayTime;
		private float _fadeTime;
		private bool _isDisplaying;
		private static readonly Color[] PlayerColorList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal float _PlayShowAnim_b__1(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_1
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass20_1();
	
			// Methods
			internal float _PlayShowAnim_b__2(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_2
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass20_2();
	
			// Methods
			internal float _PlayShowAnim_b__3(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_3
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass20_3();
	
			// Methods
			internal float _PlayShowAnim_b__4(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		// Constructors
		public ChatIconUIIngame();
		static ChatIconUIIngame();
	
		// Methods
		public void Initialize(RectTransform[] rects, StampCollisionArea[] collAreas, float stayTime, float fadeTime, int idx);
		private void OnDestroy();
		public void Display();
		public void Hidden();
		private void PlayShowAnim();
		public void PlayHideAnim();
		public void CancelDisplay();
		public void SetStampId(int stampId);
		private void MainSequenceEndCallback();
		private void Update();
		private void SetDisplayStamp(bool isDisplay);
		public void OnLoadedMaterial(Material mtrl);
		private CharacterBase GetTargetChara();
		private int GetActorId();
		[CompilerGenerated]
		private void _PlayShowAnim_b__20_0();
		[CompilerGenerated]
		private void _PlayHideAnim_b__21_0();
	}
}
