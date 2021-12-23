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

		protected override void PlayCurve()
		{
		}

		private IEnumerator UpdateOffset()
		{
			return null;
		}
	}
}
