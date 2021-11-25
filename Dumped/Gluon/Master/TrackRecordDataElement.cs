using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TrackRecordDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private Gluon.TrackRecordType _TrackRecordType;

		public int Id => default(int);

		public Gluon.TrackRecordType TrackRecordType => default(Gluon.TrackRecordType);
	}
}
