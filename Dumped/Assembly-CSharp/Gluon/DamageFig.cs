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
	public class DamageFig : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform rtWord;
		[SerializeField]
		private SpriteRenderer[] imageFig;
		[Header]
		[SerializeField]
		private Sprite[] spriteResist;
		[Header]
		[SerializeField]
		private float margin;
		[SerializeField]
		private float wordMargin;
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
		[SerializeField]
		private float fadeOutTime;
		private const int figCount = 8;
		private const float figScale = 100f;
		private Vector2[] spriteResistSize;
		private RectTransform rootRt;
		private Transform[] figRt;
		private TweenObject[] figRtTween;
		private CanvasGroup canvasGroup;
		private bool bMove;
		private Tweener tweenerFade;
		private Tweener tweenerScale;
		private float scale;
		private float correctScale;
		private const float correctScaleRaid = 0.5f;
		private InGameUICtrl inGameUI;
		private bool isActive;
		private float criticalWordDelay;
		private DOGetter<float> getFadeValue;
		private DOGetter<float> getScaleValue;
		private DOGetter<float> dummyGetter;
		private DOSetter<float> onUpdateFade;
		private DOSetter<float> onUpdateScale;
		private DOSetter<float> dummySetter;
		private TweenCallback onCompleteFade1;
		private TweenCallback onCompleteScale1;
		private TweenCallback onCompleteStayFade;
		private static int numTarget;
		private static Vector2[] pivotLocation;
		private static readonly float[] pivotLocationTransform;
	
		// Nested types
		[Serializable]
		private class DamageAnim
		{
			// Fields
			public float scaleTime;
			public float[] initScaleY;
			public float[] scaleY;
			public float moveY;
	
			// Constructors
			public DamageAnim();
		}
	
		public enum NoDamageType
		{
			Resist = 0
		}
	
		public enum Target
		{
			Own2Enemy = 0,
			Group2Enemy = 1,
			Enemy2Own = 2
		}
	
		private class TweenObject
		{
			// Fields
			private Transform rt;
			private int idx;
			private DamageFig owner;
			private int cnt;
			private Tweener tweener;
			private float tweenValue;
			private DOGetter<float> getTweenValue;
			private DOSetter<float> onUpdateDamageScaleIn;
			private DOSetter<float> onUpdateDamageScaleOut;
			private TweenCallback onCompleteDamageScaleIn;
			private TweenCallback onCompleteDamageScaleOut;
			private Vector3 parentLocalPosition;
			private float baseScale;
	
			// Constructors
			public TweenObject(DamageFig owner, Transform rt, int idx);
	
			// Methods
			public void DamageAnim(float delay, float duration);
			private void OnUpdateDamageScaleIn(float value);
			private void OnCompleteDamageScaleIn();
			private void OnCompleteDamageScaleOut();
			private void OnUpdateDamageScaleOut(float value);
			public void StopTween();
			public void SetParentLocalPosition(Vector3 pos);
			public void SetBaseScale(float scale);
			[CompilerGenerated]
			private float _.ctor_b__13_0();
		}
	
		private enum WordType
		{
			Resist = 0,
			Miss = 1,
			Guard = 2
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
			public static DOGetter<float> __9__73_0;
			public static DOSetter<float> __9__73_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal float _.ctor_b__73_0();
			internal void _.ctor_b__73_1(float x);
		}
	
		// Constructors
		public DamageFig();
		static DamageFig();
	
		// Methods
		private static int GetNumTarget();
		private void Visible(bool b, bool force = false);
		public static DamageFig Create(GameObject parent, GameObject target, InGameUICtrl inGameUI);
		private void Initialize(InGameUICtrl inGameUI);
		public override void FastUpdate();
		public bool IsVisible();
		public void SetupNoDamage(Vector3 position, NoDamageType noDamageType, Color color);
		private int SetupWord(WordType word, Color color);
		private void DisableObject(bool b);
		private void StopTween();
		public void StopAllImmediate();
		private void SetPivot(int n, RectTransform[] rt, Location loc);
		private void SetPivotTransform(int n, Transform[] rt, Location loc);
		private void SetDamageAnim(int n, TweenObject[] tweenObject, bool reverse);
		private void OnCompleteStayFade();
		private void OnCompleteStayFadeNoMove();
		private void OnUpdateFade(float value);
		private void OnCompleteFade0();
		private void OnCompleteFade1();
		private void OnUpdateScale(float value);
		private void OnCompleteScale0();
		private void OnCompleteScale1();
		private void DelayedCall(float delay, TweenCallback callback);
		private void SetVisibleFigSpriteRenderer(bool visible);
		private void SetAlpha(float alpha);
		[CompilerGenerated]
		private float _Initialize_b__47_0();
		[CompilerGenerated]
		private float _Initialize_b__47_1();
	}
}
