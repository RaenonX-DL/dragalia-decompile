using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.Cri
{
	public class MoviePlayerForObj : MoviePlayerBase
	{
		[SerializeField]
		private CriManaMovieController movieController;

		[SerializeField]
		private MeshFilter meshFilter;

		[SerializeField]
		private GameObject screenObject;

		protected override CriManaMovieMaterial MovieController => null;

		public override string SortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int SortingOrder
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public override bool IsTargetForReycast
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

		public override Vector2 ScreenSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		protected override void AdjustScreenSize(Vector2 dispRectSize, bool isPanScan)
		{
		}
	}
}
