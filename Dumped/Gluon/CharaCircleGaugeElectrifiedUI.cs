using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeElectrifiedUI : CharaCircleGaugeUI
	{
		[SerializeField]
		[Header("resource")]
		protected Sprite[] _iconSprites;

		public static CharaCircleGaugeElectrifiedUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
		{
			return null;
		}

		public override void SetCount(int count)
		{
		}
	}
}
