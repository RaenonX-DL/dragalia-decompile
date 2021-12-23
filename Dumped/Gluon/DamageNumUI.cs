using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;

namespace Gluon
{
	public class DamageNumUI : FastUpdateMonoBehaviour
	{
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

		[Serializable]
		private class CriticalAnim
		{
			public float criticalDelay;
		}

		public enum DamageType
		{
			Normal,
			Weak,
			Strong
		}

		public enum Target
		{
			Own2Enemy,
			Group2Enemy,
			Enemy2Own
		}

		private enum WordType
		{
			Critical,
			TotalDamage,
			HitCount
		}

		private enum LocationType
		{
			Center,
			Bottom
		}

		private class TweenObject
		{
			private Transform rt;

			private SpriteRenderer spriteRenderer;

			private int idx;

			private DamageNumUI owner;

			private DOGetter<float> getTweenValue;

			private DOSetter<float> onUpdateDamageScaleIn;

			private DOSetter<float> onUpdateDamageScaleOut;

			private DOSetter<float> onUpdateCriticalScale;

			private TweenCallback onCompleteDamageScaleIn;

			private TweenCallback onCompleteDamageScaleOut;

			private TweenCallback onCompleteCriticalScaleIn;

			private Vector3 parentLocalPosition;

			private float baseScale;

			private float criticalScale;

			private Sequence sequenceDamage;

			private Sequence sequenceDamageCritical;

			private Sequence sequenceDamageTotal;

			private Sequence sequenceWordCritical;

			private Sequence sequenceWordTotal;

			private TweenUtil.ColorModulusArgs colorModulusArgs;

			public TweenObject(DamageNumUI owner, Transform rt, SpriteRenderer spriteRenderer, int idx)
			{
			}

			public void StopTween()
			{
			}

			public void SetUpdate(bool b)
			{
			}

			public float DamageAnim(float delay, float intervalDuration)
			{
				return default(float);
			}

			private void DamageComplete()
			{
			}

			public float DamageCriticalAnim(float delay, float intervalDuration)
			{
				return default(float);
			}

			private void DamageCriticalComplete()
			{
			}

			public float DamageTotalAnim(float delay, float intervalDuration)
			{
				return default(float);
			}

			private void DamageTotalComplete()
			{
			}

			public float WordCriticalAnim(float delay)
			{
				return default(float);
			}

			private void WordCriticalComplete()
			{
			}

			public float WordTotalAnim(float delay, float intervalDuration)
			{
				return default(float);
			}

			private void WordTotalWordComplete()
			{
			}

			public void SetParentLocalPosition(Vector3 pos)
			{
			}

			public void SetBaseScale(float scale)
			{
			}

			public void SetCriticalScale(float scale)
			{
			}

			private void SetFade(SpriteRenderer sprite, float fade)
			{
			}

			private void SetExposure(TweenUtil.ColorModulusArgs args, float toEvBy255)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		private SpriteRenderer[] imageDigitBase;

		[SerializeField]
		private SpriteRenderer[] imageFig;

		[SerializeField]
		private SpriteRenderer imageDotIcon;

		[SerializeField]
		private RectTransform rtNumber;

		[SerializeField]
		private Transform rtWord;

		[SerializeField]
		private RectTransform rtDotIcon;

		[SerializeField]
		[Header("resource")]
		private Sprite[] spriteBase1;

		[SerializeField]
		private Sprite[] spriteBase2;

		[SerializeField]
		private Sprite[] spriteBase3;

		[SerializeField]
		private Sprite spritePercentBase1;

		[SerializeField]
		private Sprite[] spriteCritical;

		[SerializeField]
		private Sprite[] spriteTotalDamage;

		[SerializeField]
		private Sprite[] spriteHitCount;

		[SerializeField]
		[Header("parameter")]
		private float margin;

		[SerializeField]
		private float wordMargin;

		[SerializeField]
		private float[] fontScale;

		[SerializeField]
		private Color[] ownColor;

		[SerializeField]
		private Color[] enemyColor;

		[SerializeField]
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
		private Color recoverHPColor;

		[SerializeField]
		private Color recoverSPColor;

		[SerializeField]
		private float correctRadius;

		[SerializeField]
		private float correctRadiusHP;

		[SerializeField]
		private float normalDamageScale;

		[SerializeField]
		private float criticalDamageScale;

		[SerializeField]
		private float otherCharacterScale;

		[SerializeField]
		private float raidOtherCharacterScale;

		[SerializeField]
		private float raidDotDamageScale;

		[SerializeField]
		private float totalDamageScale;

		[SerializeField]
		private DamageAnim damageAnim;

		[SerializeField]
		private CriticalAnim criticalWordAnim;

		private const int numberNum = 10;

		private const float digitSizeScale = 0.76f;

		private const float digitScale = 76f;

		private const float figSizeScale = 1f;

		private const float figScale = 100f;

		private const float totalDamageHumanAdjustPosY = 140f;

		private const float totalDamageDragonAdjustPosY = 50f;

		private readonly Vector2 totalDamageOffsetPos;

		private readonly Color criticalColor;

		private readonly Color criticalColorEnemy;

		private readonly Color totalDamageColor;

		private Vector3[] spriteBaseSize1;

		private Vector3[] spriteBaseSize2;

		private Vector3[] spriteBaseSize3;

		private Vector2 spritePercentBaseSize1;

		private Vector2[] spriteCriticalSize;

		private Vector2[] spriteTotalDamageSize;

		private Vector2[] spriteHitCountSize;

		private RectTransform rootRt;

		private Transform[] figRt;

		private TweenObject[] figRtTween;

		private Transform[] digitBaseRt;

		private TweenObject[] digitBaseRtTween;

		private SpriteRenderer dotIconParentImage;

		private CanvasGroup canvasGroup;

		private float[] digitPosX;

		private bool bMove;

		private Tweener tweenerFade;

		private Tweener tweenerScale;

		private float scale;

		private float correctScale;

		private InGameUICtrl inGameUI;

		private bool isDotDamage;

		private float totalDamageWordPosX;

		private DOGetter<float> getFadeValue;

		private DOGetter<float> getScaleValue;

		private DOGetter<float> dummyGetter;

		private DOSetter<float> onUpdateFade;

		private DOSetter<float> onUpdateScale;

		private DOSetter<float> dummySetter;

		private TweenCallback onCompleteFade0;

		private TweenCallback onCompleteFade1;

		private TweenCallback onCompleteScale0;

		private TweenCallback onCompleteScale1;

		private bool[] imageDigitBaseEnabled;

		private static int numDamageType;

		private static int numTarget;

		private static readonly Vector3 WORD_DEFAULT_POSITION;

		private static readonly Vector3 WORD_TOTAL_DAMAGE_POSITION;

		private static readonly Vector3 WORD_TOTAL_DAMAGE_SCALE;

		private const float CORRECT_RADIUS_CHRONOS = 90f;

		private static readonly float[] pivotLocationTransform;

		public bool isActive
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isTotalDamage
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int totalDamageIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static int GetNumDamageType()
		{
			return default(int);
		}

		private static int GetNumTarget()
		{
			return default(int);
		}

		private void Visible(bool b, bool force = false)
		{
		}

		public static DamageNumUI Create(GameObject parent, GameObject target, InGameUICtrl inGameUI)
		{
			return null;
		}

		private void Initialize(InGameUICtrl inGameUI)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void SetTweenUpdate(bool b)
		{
		}

		private Vector2 GetTotalDamagePosition()
		{
			return default(Vector2);
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Setup(CharacterBase character, int val, Vector3 position, bool isCritical, bool isDragon, DamageType damageType, Target targetType, bool isRaidQuest, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, bool isHitCount)
		{
		}

		public void SetupHP(int val, Vector3 position)
		{
		}

		public void SetupSP(int val, Vector3 position)
		{
		}

		private void ResetParam(Vector3 position, bool isCorrectRadius, bool isVisibleNumber, bool isVisibleWord, float correctRadiusScale)
		{
		}

		private int SetupWord(WordType word, Color wordColor, out float width)
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

		private void SetPivotTransform(int n, Transform[] rt, LocationType loc)
		{
		}

		private float SetDamageAnim(int n, TweenObject[] tweenObject, bool reverse, bool isCriticalDamage, bool isTotalDamage, bool isHitCount)
		{
			return default(float);
		}

		private float SetWordAnim(int n, TweenObject[] tweenObject, bool reverse, bool isTotalDamage, float intervalDuration)
		{
			return default(float);
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFade0()
		{
		}

		private void OnCompleteFade1()
		{
		}

		private void OnUpdateScale(float value)
		{
		}

		private void OnCompleteScale0()
		{
		}

		private void OnCompleteScale1()
		{
		}

		private void DelayedCall(float delay, TweenCallback callback)
		{
		}

		private void SetAlpha(float alpha)
		{
		}

		private void SetVisibleSpriteRenderer()
		{
		}

		private void SetVisibleFigSpriteRenderer(bool visible)
		{
		}
	}
}
