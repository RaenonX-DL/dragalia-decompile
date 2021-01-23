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
	public class DamageUICtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
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
		private Sprite[] spriteMiss;
		[SerializeField]
		private Sprite[] spriteGuard;
		[SerializeField]
		private Sprite[] spriteTotalDamage;
		[SerializeField]
		private Sprite[] spriteHitCount;
		[Header]
		[SerializeField]
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
		private const int digitCount = 9;
		private const int figCount = 8;
		private const int numberNum = 10;
		private static readonly int maxNum;
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
		private Vector2[] spriteMissSize;
		private Vector2[] spriteGuardSize;
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
		[CompilerGenerated]
		private bool _isActive_k__BackingField;
		[CompilerGenerated]
		private bool _isTotalDamage_k__BackingField;
		[CompilerGenerated]
		private int _totalDamageIndex_k__BackingField;
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
	
		// Properties
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isTotalDamage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int totalDamageIndex { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
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
	
		[Serializable]
		private class CriticalAnim
		{
			// Fields
			public float criticalDelay;
	
			// Constructors
			public CriticalAnim();
		}
	
		public enum NoDamageType
		{
			Miss = 0,
			Guard = 1
		}
	
		public enum DamageType
		{
			Normal = 0,
			Weak = 1,
			Strong = 2
		}
	
		public enum Target
		{
			Own2Enemy = 0,
			Group2Enemy = 1,
			Enemy2Own = 2
		}
	
		private enum WordType
		{
			Critical = 0,
			Miss = 1,
			Guard = 2,
			TotalDamage = 3,
			HitCount = 4
		}
	
		private enum LocationType
		{
			Center = 0,
			Bottom = 1
		}
	
		private class TweenObject
		{
			// Fields
			private Transform rt;
			private SpriteRenderer spriteRenderer;
			private int idx;
			private DamageUICtrl owner;
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
	
			// Constructors
			public TweenObject(DamageUICtrl owner, Transform rt, SpriteRenderer spriteRenderer, int idx);
	
			// Methods
			public void StopTween();
			public float DamageAnim(float delay, float intervalDuration);
			private void DamageComplete();
			public float DamageCriticalAnim(float delay, float intervalDuration);
			private void DamageCriticalComplete();
			public float DamageTotalAnim(float delay, float intervalDuration);
			private void DamageTotalComplete();
			public float WordCriticalAnim(float delay);
			private void WordCriticalComplete();
			public float WordTotalAnim(float delay, float intervalDuration);
			private void WordTotalWordComplete();
			public void SetParentLocalPosition(Vector3 pos);
			public void SetBaseScale(float scale);
			public void SetCriticalScale(float scale);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOGetter<float> __9__146_0;
			public static DOSetter<float> __9__146_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal float _.ctor_b__146_0();
			internal void _.ctor_b__146_1(float x);
		}
	
		// Constructors
		public DamageUICtrl();
		static DamageUICtrl();
	
		// Methods
		private static int GetNumDamageType();
		private static int GetNumTarget();
		private void Visible(bool b, bool force = false);
		public static DamageUICtrl Create(GameObject parent, GameObject target, InGameUICtrl inGameUI);
		private void Initialize(InGameUICtrl inGameUI);
		private void OnDestroy();
		public override void FastUpdate();
		private Vector2 GetTotalDamagePosition();
		public bool IsVisible();
		public void Setup(CharacterBase character, int val, Vector3 position, bool isCritical, bool isDragon, DamageType damageType, Target targetType, bool isRaidQuest, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int uniqueBuffIcon, bool isHitCount);
		public void SetupHP(int val, Vector3 position);
		public void SetupSP(int val, Vector3 position);
		public void SetupNoDamage(Vector3 position, NoDamageType noDamageType);
		private void ResetParam(Vector3 position, bool isCorrectRadius, bool isVisibleNumber, bool isVisibleWord, float correctRadiusScale);
		private int SetupWord(WordType word, Color wordColor, out float width);
		private void DisableObject(bool b);
		private void StopTween();
		public void StopAllImmediate();
		private void SetPivotTransform(int n, Transform[] rt, LocationType loc);
		private float SetDamageAnim(int n, TweenObject[] tweenObject, bool reverse, bool isCriticalDamage, bool isTotalDamage, bool isHitCount);
		private float SetWordAnim(int n, TweenObject[] tweenObject, bool reverse, bool isTotalDamage, float intervalDuration);
		private void OnUpdateFade(float value);
		private void OnCompleteFade0();
		private void OnCompleteFade1();
		private void OnUpdateScale(float value);
		private void OnCompleteScale0();
		private void OnCompleteScale1();
		private void DelayedCall(float delay, TweenCallback callback);
		private void SetAlpha(float alpha);
		private void SetVisibleSpriteRenderer();
		private void SetVisibleFigSpriteRenderer(bool visible);
		[CompilerGenerated]
		private float _Initialize_b__118_0();
		[CompilerGenerated]
		private float _Initialize_b__118_1();
	}
}
