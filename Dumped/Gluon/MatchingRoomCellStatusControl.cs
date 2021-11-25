using UnityEngine;

namespace Gluon
{
	public class MatchingRoomCellStatusControl : MonoBehaviour
	{
		public GameObject editingParent;

		public GameObject readyParent;

		public GameObject waitingParent;

		public FlashPlayerManager flashPlayerManager;

		private MatchingReadyState currentState;

		private Animator iconRecruitementAnimator;

		private Animator iconCheckingAnimator;

		private FlashPlayer partyEditingFlashPlayer;

		private FlashPlayer readyFlashPlayer;

		private string flashPathBase => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SwitchToState(MatchingReadyState state, bool withSE)
		{
		}

		private static Animator CreateAnimator(string path, GameObject parent)
		{
			return null;
		}
	}
}
