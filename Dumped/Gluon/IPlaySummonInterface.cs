using UnityEngine;

namespace Gluon
{
	public interface IPlaySummonInterface
	{
		Transform node3d { get; }

		FlashPlayerManager flashPlayerManager { get; }

		CameraClearFlags oldFlashCameraClearFlags { get; set; }

		RenderTexture charaWeaponRenderTexture { get; }

		bool IsBoxSummon { get; }

		void StartWhiteOutEffect(float inTime, float outTime);

		void OnBoxSummonEvent(BoxSummonEventId eid);
	}
}
