/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonMultiCharaBase : MonoBehaviour
	{
		// Fields
		public Image charaIcon;
		public GameObject newImage;
		public GameObject moonOverride;
		public UnityEngine.UI.Text moonCount;
		public Transform backHaloNode;
		public Transform frontHaloNode;
		[SerializeField]
		private Transform _frontBonusNode;
		[SerializeField]
		private Image iconAmulet;
		[SerializeField]
		private Image iconDragonElements;
		[SerializeField]
		private List<Sprite> dragonElements;
		private SummonResultItemData data;
		private int resultIndex;
		public Action<SummonResultItemData, int> onButtonClicked;
	
		// Properties
		public Transform frontBonusNode { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _StartMoonOverride_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_1
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_1();
	
			// Methods
			internal float _StartMoonOverride_b__1(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_2
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_2();
	
			// Methods
			internal float _StartMoonOverride_b__2(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_3
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_3();
	
			// Methods
			internal float _StartMoonOverride_b__3(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_4
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_4();
	
			// Methods
			internal float _StartMoonOverride_b__4(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_5
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_5();
	
			// Methods
			internal float _StartMoonOverride_b__5(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_6
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_6();
	
			// Methods
			internal float _StartMoonOverride_b__6(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_7
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_7();
	
			// Methods
			internal float _StartMoonOverride_b__7(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_8
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_8();
	
			// Methods
			internal float _StartMoonOverride_b__8(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_9
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass16_9();
	
			// Methods
			internal float _StartMoonOverride_b__9(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		// Constructors
		public SummonMultiCharaBase();
	
		// Methods
		public void SetByItemData(SummonResultItemData data, int resultIndex);
		public void StartMoonOverride();
		private void SetIcon(Sprite sprite, Material mat);
		private void SetIsNew(bool isNew);
		public void OnDetailButtonPressed();
		private void SetIconAmulet();
		private void SetIconDoragonElement();
	}
}
