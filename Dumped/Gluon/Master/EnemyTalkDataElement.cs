using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyTalkDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EnemyId;

		[SerializeField]
		private int _TalkId;

		[SerializeField]
		private EnemyTalkTrigger _Trigger;

		[SerializeField]
		private int _IntValue01;

		public int Id => default(int);

		public int EnemyId => default(int);

		public int TalkId => default(int);

		public EnemyTalkTrigger Trigger => default(EnemyTalkTrigger);

		public int IntValue01 => default(int);
	}
}
