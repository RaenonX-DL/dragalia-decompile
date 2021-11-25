using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QRBuildEventBonusList : MonoBehaviour
	{
		[SerializeField]
		private Transform contentTransform;

		[SerializeField]
		private float moveDis;

		private float moveDuration;

		[SerializeField]
		private QRBuildEventBonusCell clearStageCell;

		private List<QRBuildEventBonusCell> bonusCells;

		private QuestResultTopPage resultTop;

		private bool isMovingUp;

		public bool isSkipped
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetContent(QuestDataElement dataElement, QuestResultTopPage resultTop)
		{
		}

		private AtgenScoreMissionSuccessList[] SortScoreMissions()
		{
			return null;
		}

		public IEnumerator StartEnterAnimation(QRBuildEventResult buildEventResult)
		{
			return null;
		}

		public void SkipEnterAnimation()
		{
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}
	}
}
