using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CastleStoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private int _SortKey;

		[SerializeField]
		private string _ThumbnailImage;

		[SerializeField]
		private GiftType _ReleaseEntityType;

		[SerializeField]
		private int _ReleaseEntityId;

		[SerializeField]
		private int _ReleaseEntityQuantity;

		[SerializeField]
		private string _ReleaseDate;

		public int Id => default(int);

		public string Title => null;

		public int SortKey => default(int);

		public string ThumbnailImage => null;

		public GiftType ReleaseEntityType => default(GiftType);

		public int ReleaseEntityId => default(int);

		public int ReleaseEntityQuantity => default(int);

		public string ReleaseDate => null;
	}
}
