using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AlbumQuestPlayRecordElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _QuestPlayRecordType;

		[SerializeField]
		private int _QuestPlayRecordValue;

		public int Id => default(int);

		public int QuestPlayRecordType => default(int);

		public int QuestPlayRecordValue => default(int);
	}
}
