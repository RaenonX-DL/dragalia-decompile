using System;
using System.Collections;
using System.Collections.Generic;
using Cute.Core;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickGaugeCtrl : FastUpdateMonoBehaviour
	{
		public enum GaugeType
		{
			None,
			ActiveGauge,
			ModeGauge,
			OverflowGauge,
			OverflowGauge2,
			OverflowGauge3,
			CustomPointGauge,
			CustomPointGauge2,
			CustomPointGauge3,
			CustomPointGauge4,
			GunChargeGauge,
			GunChargeGauge2,
			RequiredBuffGauge
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _gaugeRt;

		private Dictionary<CharacterBase, CharaGimmickBaseGaugeUI> _gaugeList;

		private Dictionary<CharacterBase, Dictionary<int, Coroutine>> _gaugeDelayList;

		public static CharaGimmickGaugeCtrl Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public void Attach(CharacterBase chara, GaugeType type)
		{
		}

		public void Show(CharacterBase chara)
		{
		}

		public void Hide(CharacterBase chara, bool isOnlyOverflow)
		{
		}

		public void Hide()
		{
		}

		public void SetGaugeValue(CharacterBase chara, int idx, int value, int consumeValue, int maxValue, float delay, bool isImmediateGaugeAnim, bool isPlayAnim, bool isSkipGaugePrevWaitTime)
		{
		}

		private IEnumerator SetGaugeValue(CharacterBase chara, CharaGimmickBaseGaugeUI gauge, int idx, int value, int consumeValue, int maxValue, float delay, bool isImmediateGaugeAnim, bool isPlayAnim, bool isSkipGaugePrevWaitTime)
		{
			return null;
		}

		private void AddGaugeDelay(CharacterBase chara, int idx, Coroutine delayObj)
		{
		}

		private void StopGaugeDelay(CharacterBase chara, int idx)
		{
		}

		public void SetMode(CharacterBase chara, int mode)
		{
		}

		public void SetGaugeAnimCompleteCallback(CharacterBase chara, int idx, Action<int> onComplete)
		{
		}

		public void SetGaugeAnimCompleteCallback(CharacterBase chara, int idx, Action<int, int, int> onComplete)
		{
		}

		public float GetGaugeMoveTime(CharacterBase chara)
		{
			return default(float);
		}

		public void ChangeAppearance(CharacterBase chara, int type)
		{
		}

		public void SetAbilityData(CharacterBase chara, ref List<AbilityDataElement> list)
		{
		}

		public bool IsOverflowGauge(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
