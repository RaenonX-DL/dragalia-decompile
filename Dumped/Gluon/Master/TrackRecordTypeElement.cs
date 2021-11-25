using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TrackRecordTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Gid;

		public int Id => default(int);

		public int Gid => default(int);
	}
}
