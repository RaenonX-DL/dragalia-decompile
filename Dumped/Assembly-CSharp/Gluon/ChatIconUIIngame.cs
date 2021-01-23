/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Dungeon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChatIconUIIngame : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private MoveChatIcon moveChatIcon;
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
		private int playerIndex;
		private Sequence sequenceEffect;
		private RectTransform rectTransform;
		private int stampId;
		private float stayTime;
		private float fadeTime;
		private static readonly Color[] PlayerColorList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal float _Display_b__0(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_1
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass15_1();
	
			// Methods
			internal float _Display_b__1(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_2
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass15_2();
	
			// Methods
			internal float _Display_b__2(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_3
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass15_3();
	
			// Methods
			internal float _Display_b__3(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		// Constructors
		public ChatIconUIIngame();
		static ChatIconUIIngame();
	
		// Methods
		public void Initialize(RectTransform[] rects, StampCollisionArea[] collAreas, float stayTime, float fadeTime, int idx);
		private int GetActorId();
		public void Display();
		public void CancelDisplay();
		public void SetNextStampId(int id);
		private void MainSequenceEndCallback();
		private void Update();
		private void SetDisplayStamp(bool beginStamp);
		public void OnLoadedMaterial(Material mtrl);
	}
}
