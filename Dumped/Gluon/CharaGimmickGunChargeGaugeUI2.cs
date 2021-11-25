using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickGunChargeGaugeUI2 : CharaGimmickBaseGaugeUI
	{
		protected enum GaugeType
		{
			Charge,
			ChargeMax
		}

		[SerializeField]
		[Header("component")]
		protected RectTransform rootRt;

		[SerializeField]
		protected RectTransform adjustRt;

		[SerializeField]
		protected InGameSimpleGaugeUI chargeGauge;

		[SerializeField]
		protected InGameCounterUI chargeCounter;

		[SerializeField]
		protected InGameSimpleGaugeUI[] bulletGaugeList;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0082¿ã\u0082¹æ\u00af\u008eã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®è\u0089²\n0:é\u0080\u009aå\u00b8\u00b8\n1:æ\u009c\u0080å¤§")]
		protected Color32[] _gaugeColor;

		protected VisibleUIObject visible;

		protected HumanCharacter owner;

		protected List<AbilityDataElement> abilityList;

		protected int lastCountValue;

		protected int lastChargePhase;

		protected float lastChargeGaugeRate;

		protected readonly CharacterBuffType targetBuffType;

		protected readonly int targetBuffIconId;

		protected int maxStackNum => default(int);

		public static CharaGimmickGunChargeGaugeUI2 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize(CharacterBase chara)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateCount()
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
		{
		}

		public void SetChargeGaugeRate(float chargeRate, int chargePhase, bool isForce = false)
		{
		}

		private void SetCount(int count, bool isForce = false)
		{
		}

		public override void SetAbilityData(ref List<AbilityDataElement> list)
		{
		}

		public override int GetGaugeType()
		{
			return default(int);
		}
	}
}
