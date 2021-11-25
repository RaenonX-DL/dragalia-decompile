using System;
using Cute.Core;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;

namespace Gluon
{
	public class DamageFigUI : FastUpdateMonoBehaviour
	{
		public enum NoDamageType
		{
			Resist,
			Miss,
			Guard,
			Dodge,
			ODCounter
		}

		private enum WordType
		{
			Resist,
			Miss,
			Guard,
			Dodge,
			ODCounter
		}

		[Serializable]
		private class TextData
		{
			[Tooltip("ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088")]
			public Sprite sprite;

			[Tooltip("ã\u0083\u009eã\u0083¼ã\u0082\u00b8ã\u0083³")]
			public float margin;
		}

		[Serializable]
		private class DamageAnim
		{
			public float delayTime;

			public float[] initScaleY;

			public float[] scaleY;

			public float moveY;

			public float intervalDuration;

			public float intervalDurationCritical;

			public float intervalDurationTotal;
		}

		private class TweenObject
		{
			private Transform rt;

			private SpriteRenderer spriteRenderer;

			private int idx;

			private DamageFigUI owner;

			private int cnt;

			private Tweener tweener;

			private float baseScale;

			private Sequence sequenceDamage;

			private TweenUtil.ColorModulusArgs colorModulusArgs;

			public TweenObject(DamageFigUI owner, Transform rt, SpriteRenderer spriteRenderer, int idx)
			{
			}

			public void StopTween()
			{
			}

			public float DamageAnim(float delay, float intervalDuration)
			{
				return default(float);
			}

			private void DamageComplete()
			{
			}

			public void SetBaseScale(float scale)
			{
			}
		}

		private enum Location
		{
			Center,
			Bottom
		}

		[SerializeField]
		[Header("component")]
		private Transform rtWord;

		[SerializeField]
		private SpriteRenderer[] imageFig;

		[SerializeField]
		[Header("resource")]
		[Tooltip("Resist ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088æ\u0083\u0085å\u00a0±")]
		private TextData[] resistTextDataArray;

		[SerializeField]
		[Tooltip("Miss ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088æ\u0083\u0085å\u00a0±")]
		private TextData[] missTextDataArray;

		[SerializeField]
		[Tooltip("Guard ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088æ\u0083\u0085å\u00a0±")]
		private TextData[] guardTextDataArray;

		[SerializeField]
		[Tooltip("Dodge ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088æ\u0083\u0085å\u00a0±")]
		private TextData[] dodgeTextDataArray;

		[SerializeField]
		[Tooltip("ODCounter ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088æ\u0083\u0085å\u00a0±")]
		private TextData[] odCounterTextDataArray;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ä\u00b8\u008aæ\u0098\u0087é\u0080\u009fåº¦(/s)")]
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

		private void Visible(bool b, bool force = false)
		{
		}

		public static DamageFigUI Create(GameObject parent, GameObject target, InGameUICtrl inGameUI)
		{
			return null;
		}

		private void Initialize(InGameUICtrl inGameUI)
		{
		}

		public override void FastUpdate()
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void SetupNoDamage(Vector3 position, NoDamageType noDamageType, Color color)
		{
		}

		private int SetupWord(WordType word, Color color)
		{
			return default(int);
		}

		private void DisableObject(bool b)
		{
		}

		private void StopTween()
		{
		}

		public void StopAllImmediate()
		{
		}

		private void SetPivotTransform(int n, Transform[] rt, Location loc)
		{
		}

		private float SetDamageAnim(int n, TweenObject[] tweenObject, bool reverse)
		{
			return default(float);
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFade1()
		{
		}

		private void OnUpdateScale(float value)
		{
		}

		private void OnCompleteScale1()
		{
		}

		private void DelayedCall(float delay, TweenCallback callback)
		{
		}

		private void SetVisibleFigSpriteRenderer(bool visible)
		{
		}

		private void SetAlpha(float alpha)
		{
		}
	}
}
