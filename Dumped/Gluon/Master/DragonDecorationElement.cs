using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DragonDecorationElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ModelId;

		[SerializeField]
		private string _SummonAnimationName;

		[SerializeField]
		private string _NodeName;

		[SerializeField]
		private bool _IsFirstVisible;

		public int Id => default(int);

		public int ModelId => default(int);

		public string SummonAnimationName => null;

		public string NodeName => null;

		public bool IsFirstVisible => default(bool);
	}
}
