using System.Collections;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistAddPosition : DungeonBgArtistBase
	{
		[SerializeField]
		private Vector3 addLocalPosition;

		[SerializeField]
		private float curveCycleSecond;

		public AnimationCurve animationCurve;

		[SerializeField]
		private float curveCycleOffset;

		private void Start()
		{
		}

		private IEnumerator UpdateOffset()
		{
			return null;
		}
	}
}
