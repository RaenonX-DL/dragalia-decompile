/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickGunChargeGaugeUI : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _adjustRt;
		[SerializeField]
		protected InGameSimpleGaugeUI _chargeGauge;
		[SerializeField]
		protected InGameSimpleGaugeUI _dischargeGauge;
		[SerializeField]
		protected SpriteRenderer _sandTimerImage;
		[SerializeField]
		protected InGameCounterUI _chargeCounter;
		[SerializeField]
		protected InGameSimpleGaugeUI[] _bulletGauge;
		[Header]
		[SerializeField]
		[Tooltip]
		protected Color32[] _gaugeColor;
		[SerializeField]
		[Tooltip]
		protected int _maxStackNum;
		[SerializeField]
		[Tooltip]
		protected float _dischargeChangeBulletDelayAnimTime;
		protected VisibleUIObject _visible;
		protected VisibleUIObject _sandTimerVisible;
		protected VisibleUIObject _countVisible;
		protected HumanCharacter _owner;
		protected List<AbilityDataElement> _abilityList;
		protected StateType _state;
		protected int _targetCountValue;
		protected float _targetChargeGaugeRate;
		protected List<List<CustomPointData>> _targetCPDataList;
		protected int _lastCountValue;
		protected float _lastChargeGaugeRate;
		protected float _lastDischargeGaugeRate;
		protected int _lastCP;
		protected int _overflowCount;
		protected int _cpIndex;
		protected Action<int, int, int> _onStepoverCallback;
		protected int _stepoverCallbackArgeIndex;
		protected readonly CharacterBuffType TargetBuffType;
		protected readonly InGameBuffUI.UniqueBuffIconType TargetUniqueBuffIconType;
		protected readonly int CPDataReserveNum;
	
		// Nested types
		public enum StateType
		{
			Charge = 0,
			Discharge = 1
		}
	
		protected enum GaugeType
		{
			Charge = 0,
			ChargeMax = 1
		}
	
		protected class CustomPointData
		{
			// Fields
			public int prevCP;
			public int currCP;
			public bool isUsed;
	
			// Constructors
			public CustomPointData();
	
			// Methods
			public bool Set(int prevCP, int currCP);
			public void Clear();
		}
	
		// Constructors
		public CharaGimmickGunChargeGaugeUI();
	
		// Methods
		public static CharaGimmickGunChargeGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		private void OnDestroy();
		public override void FastUpdate();
		protected void UpdateUI(bool isForce = false);
		private void UpdateChargeModeUI(int buffNum, float durationTime, float lifeTime, bool isForce);
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false);
		protected bool AddCPData(int index, int prevCP, int currCP);
		protected bool SetState(StateType state, bool isForce = false, bool isAnim = true);
		private void SetCountValue(int stack, bool isForce = false, bool isAnim = true);
		public void SetChargeGaugeRate(float chargeRate, int chargeCount, int overflowCount, bool isForce = false);
		public void SetDischargeGaugeRate(float timeRate, bool isForce = false);
		public override void SetAbilityData(ref List<AbilityDataElement> list);
		private static int CompareAbilityDataElement(AbilityDataElement x, AbilityDataElement y);
		public override void SetGaugeCallback(int idx, Action<int, int, int> onComplete);
		protected void ApplyGaugeCallback(int index);
		protected void ApplyGaugeCallback();
		public override int GetGaugeType();
		[CompilerGenerated]
		private void _Initialize_b__34_0(float rate);
		[CompilerGenerated]
		private void _Initialize_b__34_1(float rate);
	}
}
