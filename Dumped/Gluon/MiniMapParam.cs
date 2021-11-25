using UnityEngine;

namespace Gluon
{
	public class MiniMapParam : MonoBehaviour
	{
		public enum ProgressSearch
		{
			Unexplored,
			Discoverry,
			Intrusion
		}

		public const float MapPartsScale = 4f;

		private Rect _mapRect;

		private SpriteRenderer _image;

		private MiniMapParam[] _params;

		private float _disruptAlpha;

		private static float DiscoverryAlpha;

		private static float AnimationTime;

		private ProgressSearch _searchState;

		private static Vector3 DefaultScale;

		public Rect MapRect => default(Rect);

		public SpriteRenderer Image => null;

		public bool IsIntrusion => default(bool);

		public ProgressSearch SearchState
		{
			get
			{
				return default(ProgressSearch);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void Initialize(Vector2 pos, Rect viewRect)
		{
		}

		private void SetColorAlpha(float alpha, bool isAnim = true)
		{
		}

		private void SetIntrusion()
		{
		}

		public bool IsIntrusionArea(Vector2 pos)
		{
			return default(bool);
		}

		public void UpdateState(Vector2 pos)
		{
		}

		private void OnUpdateAlpha(float value)
		{
		}

		public void SetDrawFlag(bool drawFlag)
		{
		}

		public void SetAlwaysDraw()
		{
		}
	}
}
