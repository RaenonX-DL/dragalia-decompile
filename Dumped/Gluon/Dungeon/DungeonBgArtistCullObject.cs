using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistCullObject : DungeonBgArtistUseCameraBase
	{
		private Renderer[] targetRendererArray;

		private bool enableFlagLog;

		[SerializeField]
		private float cullDistance;

		protected override void Awake()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
