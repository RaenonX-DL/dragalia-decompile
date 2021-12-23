using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistAddRotate : DungeonBgArtistBase
	{
		[SerializeField]
		private Vector3 addLocalRotation;

		[SerializeField]
		private float curveCycleSecond;

		public AnimationCurve animationCurve;

		[SerializeField]
		private float curveCycleOffset;

		[SerializeField]
		private bool riseWaveFlag;

		private bool started;

		public Vector3 AddLocalRotation
		{
			set
			{
			}
		}

		public float CurveCycleSecond
		{
			set
			{
			}
		}

		public float CurveCycleOffset
		{
			set
			{
			}
		}

		public bool RiseWaveFlag
		{
			set
			{
			}
		}

		public bool waitStart
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Start()
		{
		}

		protected override void PlayCurve()
		{
		}

		private void Update()
		{
		}

		private IEnumerator UpdateOffset()
		{
			return null;
		}
	}
}
