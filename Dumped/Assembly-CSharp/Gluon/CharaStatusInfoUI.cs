/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaStatusInfoUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _digitRootRt;
		[SerializeField]
		private RectTransform _signRt;
		[SerializeField]
		private SpriteRenderer _bgImage;
		[SerializeField]
		private SpriteRenderer _iconImage;
		[SerializeField]
		private SpriteRenderer _blinkIconImage;
		[SerializeField]
		private SpriteRenderer _gaugeImage;
		[SerializeField]
		private SpriteRenderer[] _digitImageList;
		[SerializeField]
		private SpriteRenderer _signImage;
		[SerializeField]
		private CircleGauge _gaugeCtrl;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _coolDownAlpha;
		[SerializeField]
		[Tooltip]
		private int _playerSortingOrder;
		[SerializeField]
		[Tooltip]
		private int _enemySortingOrder;
		[SerializeField]
		[Tooltip]
		private DigitLayoutData[] _percentDigiLayoutDataArray;
		[SerializeField]
		[Tooltip]
		private DigitLayoutData[] _countDigiLayoutDataArray;
		[SerializeField]
		[Tooltip]
		private DigitLayoutData[] _quantityDigiLayoutDataArray;
		[SerializeField]
		[Tooltip]
		private DigitLayoutData[] _levelDigiLayoutDataArray;
		[SerializeField]
		[Tooltip]
		private DigitLayoutData[] _levelDigiLayoutDataArrayEN_US;
		[SerializeField]
		[Tooltip]
		private Color _buffColor;
		[SerializeField]
		[Tooltip]
		private Color _debuffColor;
		[SerializeField]
		[Tooltip]
		private Color _auraColor;
		[SerializeField]
		[Tooltip]
		private Color _partyAuraColor;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _digitRootVisible;
		private VisibleUIObject _signVisible;
		private VisibleUIObject[] _digitVisibleList;
		private VisibleUIObject _blinkIconVisible;
		private int _maxDigitNum;
		private int[] _maxNumList;
		private int _horizontalNum;
		private ValueDisplayPositionType _valueDispPosType;
		private int _index;
		private int _buffIconId;
		private AuraConst.TargetType _auraTargetType;
		private AuraType _auraType;
		private AbnormalStatusType _abnormalType;
		private EnemyAbilityType _enemyAbilityType;
		private int _productId;
		private int _value;
		private float _gaugeRate;
		[CompilerGenerated]
		private bool _IsCoolDown_k__BackingField;
		[CompilerGenerated]
		private bool _IsEnable_k__BackingField;
		[CompilerGenerated]
		private bool _IsDirty_k__BackingField;
		private readonly float[] DigitAdjustRootPositionList;
		private const float IconMerginX = 45f;
		private const float IconMerginXForInside = 42f;
		private const float IconMerginY = 60f;
	
		// Properties
		public bool IsCoolDown { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsEnable { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsDirty { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		public class DigitLayoutData
		{
			// Fields
			[Tooltip]
			public float digitScale;
			[Tooltip]
			public float digitOffsetX;
			[Tooltip]
			public float signOffsetX;
			[Tooltip]
			public float signOffsetY;
			[Tooltip]
			public float signScale;
	
			// Constructors
			public DigitLayoutData();
		}
	
		public enum ValueDisplayPositionType
		{
			Outside = 0,
			Inside = 1
		}
	
		// Constructors
		public CharaStatusInfoUI();
	
		// Methods
		public static CharaStatusInfoUI Create(GameObject parent, GameObject pobj, ValueDisplayPositionType type, int horizontalNum, int siblingIndex = -1);
		private void Initialize(ValueDisplayPositionType type, int horizontalNum);
		private void SetMaxNum(InGameBuffUI.ValueDisplayType type, int digitNum);
		public void ResetData();
		public void Visible(bool b);
		public void ShowByBuff(int buffIconId, bool isBuff, InGameBuffUI.ValueDisplayType valueDispType, InGameBuffUI.GaugeDisplayType gaugeDispType, int productId, EnemyAbilityType enemyAbilityType, Sprite sprite, int count, int value, int level, int index, int quantity, bool coolDown, int durationTimeScale);
		public void ShowByAbnormal(AbnormalStatusType type, Sprite sprite, int value, int index);
		public void ShowByAura(CharacterAuraCtrl.Parameter param, Sprite sprite, int index);
		private void SetEffectValue(InGameBuffUI.ValueDisplayType type, int value, Color color);
		public void SetGaugeRate(float rate, bool force = false);
		public void SetDirty(bool b);
		public bool IsMatch(int buffIconId, int productId);
		public bool IsMatch(AbnormalStatusType type);
		public bool IsMatch(EnemyAbilityType type);
		public bool IsMatch(AuraConst.TargetType targetType, AuraType type, int productId);
		public void AdjustRootPosition(int index);
		public void SetCoolDown(bool b, bool force = false);
		private void ApplyColorAlpha();
		private void ApplyColorAlpha(ref SpriteRenderer sprite);
		private DigitLayoutData[] GetLevelDigiLayoutDataArray();
		public void SetVisibleBlinkIcon(bool b);
		public void OnUpdateBlinkAnim(float value);
	}
}
