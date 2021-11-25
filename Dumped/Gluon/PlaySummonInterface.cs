using UnityEngine;

namespace Gluon
{
	public class PlaySummonInterface : IPlaySummonInterface
	{
		public static IPlaySummonInterface instance;

		public Transform node3d => null;

		public FlashPlayerManager flashPlayerManager => null;

		public CameraClearFlags oldFlashCameraClearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		public RenderTexture charaWeaponRenderTexture => null;

		public bool IsBoxSummon => default(bool);

		public void StartWhiteOutEffect(float inTime, float outTime)
		{
		}

		public void OnBoxSummonEvent(BoxSummonEventId eid)
		{
		}
	}
}
