using System.Collections;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistSetScale : DungeonBgArtistBase
	{
		public enum CalcKind
		{
			Set,
			Add
		}

		[SerializeField]
		private CalcKind calcKind;

		[SerializeField]
		private Vector3 baseLocalScale;

		[SerializeField]
		private float curveCycleSecond;

		public AnimationCurve animationCurve;

		[SerializeField]
		private float curveCycleOffset;

		[SerializeField]
		private bool clampZeroFlag;

		protected override void PlayCurve()
		{
		}

		private IEnumerator UpdateOffset()
		{
			return null;
		}
	}
}
