using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeAbilityRebornUI : CharaCircleGaugeUI
	{
		[SerializeField]
		[Header("component")]
		private InGameCounterUI _counterUI;

		private int _lastTimeImageIndex;

		public static CharaCircleGaugeAbilityRebornUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
		{
			return null;
		}

		protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY)
		{
		}

		public override void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false)
		{
		}
	}
}
