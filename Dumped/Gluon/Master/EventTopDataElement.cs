using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventTopDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TopBgmConditionType1;

		[SerializeField]
		private int _TopBgmConditionId1;

		[SerializeField]
		private string _TopBgmName1;

		[SerializeField]
		private int _TopBgmConditionType2;

		[SerializeField]
		private int _TopBgmConditionId2;

		[SerializeField]
		private string _TopBgmName2;

		public int Id => default(int);

		public int TopBgmConditionType1 => default(int);

		public int TopBgmConditionId1 => default(int);

		public string TopBgmName1 => null;

		public int TopBgmConditionType2 => default(int);

		public int TopBgmConditionId2 => default(int);

		public string TopBgmName2 => null;
	}
}
