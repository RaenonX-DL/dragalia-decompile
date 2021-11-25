using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestResultEarnEventBonusList : MonoBehaviour
	{
		[SerializeField]
		private Transform contentTransform;

		[SerializeField]
		private float moveDis;

		[SerializeField]
		private QuestResultEarnEventBonusCell clearStageCell;

		private float moveDuration;

		private List<QuestResultEarnEventBonusCell> bonusCells;

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

		public void SetContent(QuestDataElement dataElement)
		{
		}

		public IEnumerator StartEnterAnimation(QuestResultEarnEventBonus buildEventResult)
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
