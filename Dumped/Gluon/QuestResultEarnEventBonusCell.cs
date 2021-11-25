using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultEarnEventBonusCell : SimpleAnimationCell
	{
		[SerializeField]
		private RawImage icon;

		[SerializeField]
		private Image medalIcon;

		[SerializeField]
		private Text ptValueText;

		[SerializeField]
		private Text koValueText;

		[SerializeField]
		private Text infoText;

		[SerializeField]
		private Image effectImage;

		private bool isCancelled;

		private const float moveBackDis = 20f;

		public Action checkLabelAction;

		private const string seCheckMark = "SE_OUT_RANDOM_003";

		protected override void Awake()
		{
		}

		public void SetContent(QuestResultModel.ScoringEnemyPointListData.EnemyPointListData data)
		{
		}

		public void ShowStartAnimation()
		{
		}

		public void CancelAnimation()
		{
		}

		private void CancelAnimationImpl()
		{
		}
	}
}
