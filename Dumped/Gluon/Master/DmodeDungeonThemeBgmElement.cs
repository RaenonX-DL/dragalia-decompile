using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeDungeonThemeBgmElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ThemeBgmGroupId;

		[SerializeField]
		private string _Bgm;

		public int Id => default(int);

		public int ThemeBgmGroupId => default(int);

		public string Bgm => null;
	}
}
