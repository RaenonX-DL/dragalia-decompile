/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private int[] _diplayDigitNumList;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _digitRootVisible;
		private VisibleUIObject _signVisible;
		private VisibleUIObject[] _digitVisibleList;
		private int _maxDigitNum;
		private int[] _maxNumList;
		private int _horizontalNum;
		private DigitLayoutType _layoutType;
		private int _index;
		private InGameBuffUI.BuffIconType _buffIcon;
		private InGameBuffUI.UniqueBuffIconType _uniqueBuffIcon;
		private int _productId;
		private AbnormalStatusType _abnormalType;
		private EnemyAbilityType _enemyAbilityType;
		private int _value;
		private float _gaugeRate;
		[CompilerGenerated]
		private bool _IsCoolDown_k__BackingField;
		[CompilerGenerated]
		private bool _IsEnable_k__BackingField;
		[CompilerGenerated]
		private bool _IsDirty_k__BackingField;
		private readonly Vector3[] DigitAdjustPositonListForPercent;
		private readonly Vector3[] DigitAdjustPositonListForCount;
		private readonly Vector3[] DigitAdjustPositonListForQuantity;
		private readonly Vector3[] DigitAdjustPositonListForLevel;
		private readonly float[] DigitAdjustRootPositionList;
		private static readonly Color BuffGaugeColor;
		private static readonly Color DebuffGaugeColor;
		private const float IconMerginX = 45f;
		private const float IconMerginXForInside = 42f;
		private const float IconMerginY = 60f;
	
		// Properties
		public bool IsCoolDown { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsEnable { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsDirty { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum DispType
		{
			None = -1,
			Percent = 0,
			Count = 1,
			Count2 = 2,
			Quantity = 3,
			Level = 4
		}
	
		private enum AdjustPosition
		{
			RootX = 0,
			SignX = 1,
			SignY = 2
		}
	
		public enum DigitLayoutType
		{
			Outside = 0,
			Inside = 1
		}
	
		// Constructors
		public CharaStatusInfoUI();
		static CharaStatusInfoUI();
	
		// Methods
		public static CharaStatusInfoUI Create(GameObject parent, GameObject pobj, DigitLayoutType type, int horizontalNum, int siblingIndex = -1);
		private void Initialize(DigitLayoutType type, int horizontalNum);
		public void ResetData();
		public void Visible(bool b);
		public void ShowByBuff(InGameBuffUI.BuffIconType iconType, InGameBuffUI.UniqueBuffIconType uniqueBuffIcon, int productId, EnemyAbilityType enemyAbilityType, Sprite sprite, int count, int value, int level, int index, int quantity, bool coolDown, int durationTimeScale);
		public void ShowByAbnormal(AbnormalStatusType type, Sprite sprite, int value, int index);
		private void SetEffectValue(DispType type, int value, Color color);
		public void SetGaugeRate(float rate, bool force = false);
		public void SetDirty(bool b);
		public bool IsMatch(InGameBuffUI.BuffIconType icon, int index);
		public bool IsMatch(InGameBuffUI.UniqueBuffIconType icon, int index);
		public bool IsMatch(AbnormalStatusType type);
		public bool IsMatch(EnemyAbilityType type);
		public void AdjustRootPosition(int index);
		public void SetCoolDown(bool b, bool force = false);
		private void ApplyColorAlpha();
		private void ApplyColorAlpha(ref SpriteRenderer sprite);
	}
}
