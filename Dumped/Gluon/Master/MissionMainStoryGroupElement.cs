using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MissionMainStoryGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _LockText;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _AnimationInfo;

		public int Id => default(int);

		public string Text => null;

		public string LockText => null;

		public int SortId => default(int);

		public string AnimationInfo => null;
	}
}
