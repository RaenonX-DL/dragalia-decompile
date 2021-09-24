/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SkillInfo : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private Button _button;
		[SerializeField]
		[Tooltip]
		private RectTransform _offsetRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _effectRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _noUseRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _chainSkillFrameRt;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _skillIcon;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _effectImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _chainSkillFrameImage;
		[SerializeField]
		[Tooltip]
		private SkillIconCtrl _skillIconCtrl;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _counterUI;
		[SerializeField]
		[Tooltip]
		private SkillOverChargeGaugeUI _overChargeGaugeUI;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _expansionTime;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _maxGaugeAnimFlashPower;
		[CompilerGenerated]
		private int _SkillIndex_k__BackingField;
		private RectTransform _rootRt;
		private Tweener _twExpansion;
		private VisibleUIObject _effectVisible;
		private VisibleUIObject _noUseVisible;
		private VisibleUIObject _chainSkillVisible;
		private float _gaugeRate;
		private float _lastGaugeRate;
		private bool _isValidate;
		private bool _isExpansionEffect;
		private bool _isMaxEffect;
		private bool _isGaugeMax;
		private int _spGaugeCount;
		private bool _isDisableSkillByRequiredBuff;
		private Dictionary<int, AbnormalStatusType> _lastAbnormalStatusTypeDic;
		private bool _isLastBind;
		private bool _isDisableUpdate;
		private bool _isCheckActive;
		private bool _isEnableChainSkill;
		private int _lastSkillId;
		private string _lastIconName;
		private const float TweenerExpansionEndValue = 1f;
		private const int EmptyItemSkillID = -1;
	
		// Properties
		[HideInInspector]
		public int SkillIndex { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public Action<SkillInfo> onClick;
			public SkillInfo __4__this;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public SkillInfo();
	
		// Methods
		public void Initialize(Action<SkillInfo> onClick, int skillIndex, bool isLeft);
		public override void FastUpdate();
		private bool IsChangedAbnormalStatus();
		public bool SetSkillIcon(CharacterBase chara, int skillId);
		public bool SetEmptyItemSkillIcon(bool isDisable = true);
		public void DisableSkill(bool isDisable, bool isDisableGrayOut, bool isEnableReturnValue);
		private void SetSkillIcon(string iconName, Material material, Sprite sprite);
		public void SetItemSkillCount(int count);
		public void SetGaugeValue(float rate, bool isForce = false);
		public void SetOverChargeGaugeValue(int phase, int phaseSp, int phaseConsumeSp, bool isForce = false);
		private void CheckInactive(bool bmax);
		public void Attach(RectTransform parentRT);
		public void Visible(bool b, bool force = false);
		public bool IsVisible();
		public void Validate(bool b);
		public Vector2 GetButtonPosition();
		public Vector2 GetButtonSize();
		private void StartExpansionEffect();
		private void OnUpdateExpansion(float value);
		private void OnCompleteExpansion();
		public void PauseMaxEffect();
		public void SetEnabled(bool b);
		public void OnUpdateGaugeMax(float value);
		public void SetupChainSkill(Material frameMat);
		public void SetVisibleChainSkill(bool b);
		public void SetDisableSkillByRequiredBuff(bool v, int spGaugeCount);
	}
}
