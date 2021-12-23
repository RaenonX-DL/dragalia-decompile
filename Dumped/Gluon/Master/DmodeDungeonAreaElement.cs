using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeDungeonAreaElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ThemeGroupId;

		[SerializeField]
		private int _VariationType;

		[SerializeField]
		private int _IsSelectedEntity;

		[SerializeField]
		private string _Scene;

		[SerializeField]
		private string _AreaName;

		[SerializeField]
		private string _BossMultiSceneName;

		[SerializeField]
		private int _DungeonAreaPlannerDataId;

		public int Id => default(int);

		public int ThemeGroupId => default(int);

		public int VariationType => default(int);

		public int IsSelectedEntity => default(int);

		public string Scene => null;

		public string AreaName => null;

		public string BossMultiSceneName => null;

		public int DungeonAreaPlannerDataId => default(int);
	}
}
