using UnityEngine;
using UnityEngine.UI;

namespace Cute.Cri
{
	public class MoviePlayerForUI : MoviePlayerBase
	{
		[SerializeField]
		private CriManaMovieControllerForUI movieController;

		[SerializeField]
		private RawImage rawImage;

		[SerializeField]
		private RectTransform screenRect;

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
			get
			{
				return default(bool);
			}
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
