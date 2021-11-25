using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistBillboard : DungeonBgArtistUseCameraBase
	{
		public enum BillboardKind
		{
			LookCameraPos,
			CopyCameraRot
		}

		[SerializeField]
		private bool startOnlyFlag;

		[SerializeField]
		private BillboardKind billboardkind;

		[SerializeField]
		private bool fixedAxisYFlag;

		protected override void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		private void SetBillboard()
		{
		}
	}
}
