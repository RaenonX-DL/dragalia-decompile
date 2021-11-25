using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class Clb01EventLocationElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _LocationName;

		[SerializeField]
		private string _PointerImageName;

		[SerializeField]
		private float _LocationPointerX;

		[SerializeField]
		private float _LocationPointerY;

		[SerializeField]
		private int _ReleaseQuestStoryId;

		[SerializeField]
		private int _ReleaseQuestId;

		[SerializeField]
		private int _IsViewAnnounce;

		[SerializeField]
		private string _TopBannerImage;

		[SerializeField]
		private string _HowToPlayImage;

		public int Id => default(int);

		public string LocationName => null;

		public string PointerImageName => null;

		public float LocationPointerX => default(float);

		public float LocationPointerY => default(float);

		public int ReleaseQuestStoryId => default(int);

		public int ReleaseQuestId => default(int);

		public int IsViewAnnounce => default(int);

		public string TopBannerImage => null;

		public string HowToPlayImage => null;
	}
}
