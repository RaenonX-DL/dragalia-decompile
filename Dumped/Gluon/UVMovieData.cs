using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class UVMovieData : ScriptableObject
	{
		public Texture2D[] textures;

		public int fremePerWidth;

		public int fremePerHeight;

		public int frameTotalCount;

		public float fps;

		public float startOffsetSec;

		public float endOffsetSec;

		public bool isLoop;

		public float startLoopSec;

		public float endLoopSec;

		public int loopCount;
	}
}
