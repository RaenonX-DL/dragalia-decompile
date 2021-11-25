using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class InteractiveBGMElement : IMasterElement
	{
		[SerializeField]
		private string _CueName;

		[SerializeField]
		private int[] _BlockTimes;

		[SerializeField]
		private int[] _CallbackMarkerTimes;

		[SerializeField]
		private int[] _CallbackMarkerBitFlags;

		[SerializeField]
		private int _TransitionBlockId;

		public string CueName => null;

		public int[] BlockTimes => null;

		public int[] CallbackMarkerTimes => null;

		public int[] CallbackMarkerBitFlags => null;

		public int TransitionBlockId => default(int);
	}
}
