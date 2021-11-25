using UnityEngine;

namespace Gluon
{
	public class CharaGimmickModeGaugeUI : CharaGimmickActiveGaugeUI
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("è\u0083\u008cæ\u0099\u00afç\u0094»å\u0083\u008f")]
		protected SpriteRenderer[] _bgImage;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		protected SpriteRenderer[] _iconImage;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("é\u009d\u009eã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		protected Color _deactiveColor;

		private VisibleUIObject[] _gaugeVisible;

		public new static CharaGimmickModeGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected override void Initialize(CharacterBase chara)
		{
		}

		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
		{
		}

		public void SetMode(int mode)
		{
		}

		protected void SetColor(Color color, int index, bool active)
		{
		}

		protected void SetColor(ref SpriteRenderer sprite, Color color)
		{
		}

		protected void SetActiveColor(int index)
		{
		}

		protected void SetDeactiveColor(int index)
		{
		}

		public override int GetGaugeType()
		{
			return default(int);
		}
	}
}
