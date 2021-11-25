using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponCraftTreeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _CraftGroupId;

		[SerializeField]
		private int _CraftStep;

		[SerializeField]
		private int _CraftNodeId;

		[SerializeField]
		private int _CraftWeaponId;

		[SerializeField]
		private int _ParentCraftNodeId;

		public int Id => default(int);

		public int CraftGroupId => default(int);

		public int CraftStep => default(int);

		public int CraftNodeId => default(int);

		public int CraftWeaponId => default(int);

		public int ParentCraftNodeId => default(int);
	}
}
