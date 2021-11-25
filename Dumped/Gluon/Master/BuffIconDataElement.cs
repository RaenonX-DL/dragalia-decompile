using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BuffIconDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _IconName;

		[SerializeField]
		private int _ValueDisplayType;

		[SerializeField]
		private int _GaugeDisplayType;

		public int Id => default(int);

		public string IconName => null;

		public int ValueDisplayType => default(int);

		public int GaugeDisplayType => default(int);
	}
}
