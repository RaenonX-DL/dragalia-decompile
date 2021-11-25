using UnityEngine;

namespace Gluon
{
	public class CharaGimmickCustomPointGaugeUI3 : CharaGimmickCustomPointGaugeUI2
	{
		protected enum StateType
		{
			Normal,
			Negative,
			Num
		}

		protected class IconData
		{
			protected Sprite _sprite;

			protected Material _material;

			public Sprite Sprite => null;

			public Material Material => null;

			private IconData()
			{
			}

			public IconData(string iconName)
			{
			}

			~IconData()
			{
			}

			public void LoadIcon(string iconName)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		protected RectTransform _stepGaugeRootRt;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0083\u008dã\u0082¬ã\u0083\u0086ã\u0082£ã\u0083\u0096æ\u0099\u0082ã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®è\u0089²")]
		protected Color _gaugeNegativeColor;

		[SerializeField]
		[Tooltip("ã\u0083\u008dã\u0082¬ã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0082³ã\u0083³ã\u0083\u0087ã\u0082£ã\u0082·ã\u0083§ã\u0083³ID")]
		protected int[] _negativeConditionId;

		protected HumanCharacter _owner;

		protected IconData[] _iconDataList;

		protected StateType _state;

		public new static CharaGimmickCustomPointGaugeUI3 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected override void Initialize(CharacterBase chara)
		{
		}

		private void SetState(StateType type, bool isForce = false)
		{
		}

		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
		{
		}

		protected override void UpdateGaugeValue()
		{
		}

		protected bool GetBuffCountForConditionId(out int conditionId, out int count)
		{
			return default(bool);
		}

		public override int GetGaugeType()
		{
			return default(int);
		}
	}
}
