using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbnormalStatusTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _AbnormalName;

		[SerializeField]
		private int _IsViewDetail;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _Group;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _ResistGain;

		[SerializeField]
		private int _DisplayPriority;

		public int Id => default(int);

		public string AbnormalName => null;

		public int IsViewDetail => default(int);

		public int SortId => default(int);

		public int Group => default(int);

		public int Priority => default(int);

		public int ResistGain => default(int);

		public int DisplayPriority => default(int);
	}
}
