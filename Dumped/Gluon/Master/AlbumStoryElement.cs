using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AlbumStoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TopAlbumStoryViewType;

		[SerializeField]
		private int _SortId;

		public int Id => default(int);

		public int TopAlbumStoryViewType => default(int);

		public int SortId => default(int);
	}
}
