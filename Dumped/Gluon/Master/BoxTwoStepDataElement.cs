using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BoxTwoStepDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Icon;

		public int Id => default(int);

		public string Name => null;

		public string Icon => null;
	}
}
