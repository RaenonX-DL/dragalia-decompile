using System.Collections.Generic;
using DG.Tweening;

namespace Gluon
{
	public static class VocalTrackController
	{
		private class VocalTrackCompare : IEqualityComparer<VocalTrack>
		{
			public bool Equals(VocalTrack track1, VocalTrack track2)
			{
				return default(bool);
			}

			public int GetHashCode(VocalTrack track)
			{
				return default(int);
			}
		}

		private static readonly Dictionary<VocalTrack, string> _vocalAisacControlDict;

		private static VocalTrack _vocalType;

		private static Tweener _tweener;

		public static void Initialize()
		{
		}

		public static VocalTrack GetVocalType()
		{
			return default(VocalTrack);
		}

		public static void SetVocalType(VocalTrack vocalType)
		{
		}

		private static void OnComplete()
		{
		}
	}
}
