/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DamageFigUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform rtWord;
		[SerializeField]
		private SpriteRenderer[] imageFig;
		[Header]
		[SerializeField]
		[Tooltip]
		private TextData[] resistTextDataArray;
		[SerializeField]
		[Tooltip]
		private TextData[] missTextDataArray;
		[SerializeField]
		[Tooltip]
		private TextData[] guardTextDataArray;
		[SerializeField]
		[Tooltip]
		private TextData[] dodgeTextDataArray;
		[SerializeField]
		[Tooltip]
		private TextData[] odCounterTextDataArray;
		[Header]
		[SerializeField]
		[Tooltip]
		private float ascendSpeed;
		[SerializeField]
		private float fadeTime;
		[SerializeField]
		private float stayTime;
		[SerializeField]
		private float scaleTime;
		[SerializeField]
		private float scaleAnim;
		[SerializeField]
		private float fontAlpha;
		[SerializeField]
		private float correctRadius;
		[SerializeField]
		private DamageAnim damageAnim;
		private const int figCount = 8;
		private const float figScale = 100f;
		private RectTransform rootRt;
		private Transform[] figRt;
		private TweenObject[] figRtTween;
		private CanvasGroup canvasGroup;
		private bool bMove;
		private Tweener tweenerFade;
		private Tweener tweenerScale;
		private float scale;
		private float correctScale;
		private InGameUICtrl inGameUI;
		private bool isActive;
		private DOGetter<float> getFadeValue;
		private DOGetter<float> getScaleValue;
		private DOGetter<float> dummyGetter;
		private DOSetter<float> onUpdateFade;
		private DOSetter<float> onUpdateScale;
		private DOSetter<float> dummySetter;
		private TweenCallback onCompleteFade1;
		private TweenCallback onCompleteScale1;
		private static readonly float[] pivotLocationTransform;
	
		// Nested types
		public enum NoDamageType
		{
			Resist = 0,
			Miss = 1,
			Guard = 2,
			Dodge = 3,
			ODCounter = 4
		}
	
		private enum WordType
		{
			Resist = 0,
			Miss = 1,
			Guard = 2,
			Dodge = 3,
			ODCounter = 4
		}
	
		[Serializable]
		private class TextData
		{
			// Fields
			[Tooltip]
			public Sprite sprite;
			[Tooltip]
			public float margin;
	
			// Constructors
			public TextData();
		}
	
		[Serializable]
		private class DamageAnim
		{
			// Fields
			public float delayTime;
			public float[] initScaleY;
			public float[] scaleY;
			public float moveY;
			public float intervalDuration;
			public float intervalDurationCritical;
			public float intervalDurationTotal;
	
			// Constructors
			public DamageAnim();
		}
	
		private class TweenObject
		{
			// Fields
			private Transform rt;
			private SpriteRenderer spriteRenderer;
			private int idx;
			private DamageFigUI owner;
			private int cnt;
			private Tweener tweener;
			private float baseScale;
			private Sequence sequenceDamage;
			private TweenUtil.ColorModulusArgs colorModulusArgs;
	
			// Constructors
			public TweenObject(DamageFigUI owner, Transform rt, SpriteRenderer spriteRenderer, int idx);
	
			// Methods
			public void StopTween();
			public float DamageAnim(float delay, float intervalDuration);
			private void DamageComplete();
			public void SetBaseScale(float scale);
		}
	
		private enum Location
		{
			Center = 0,
			Bottom = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOGetter<float> __9__62_0;
			public static DOSetter<float> __9__62_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal float _.ctor_b__62_0();
			internal void _.ctor_b__62_1(float x);
		}
	
		// Constructors
		public DamageFigUI();
		static DamageFigUI();
	
		// Methods
		private void Visible(bool b, bool force = false);
		public static DamageFigUI Create(GameObject parent, GameObject target, InGameUICtrl inGameUI);
		private void Initialize(InGameUICtrl inGameUI);
		public override void FastUpdate();
		public bool IsVisible();
		public void SetupNoDamage(Vector3 position, NoDamageType noDamageType, Color color);
		private int SetupWord(WordType word, Color color);
		private void DisableObject(bool b);
		private void StopTween();
		public void StopAllImmediate();
		private void SetPivotTransform(int n, Transform[] rt, Location loc);
		private float SetDamageAnim(int n, TweenObject[] tweenObject, bool reverse);
		private void OnUpdateFade(float value);
		private void OnCompleteFade1();
		private void OnUpdateScale(float value);
		private void OnCompleteScale1();
		private void DelayedCall(float delay, TweenCallback callback);
		private void SetVisibleFigSpriteRenderer(bool visible);
		private void SetAlpha(float alpha);
		[CompilerGenerated]
		private float _Initialize_b__43_0();
		[CompilerGenerated]
		private float _Initialize_b__43_1();
	}
}
