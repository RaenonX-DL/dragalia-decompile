using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExRushTopCharaButton : MonoBehaviour, ICustomMessage
	{
		public enum Type
		{
			Fire,
			Wind,
			Dark,
			Water,
			Rush,
			Light,
			Story,
			Trade,
			Mission
		}

		[SerializeField]
		[Header("Type")]
		public Type type;

		[SerializeField]
		[Header("NewState")]
		public QuestStateIcon stateIcon;

		[SerializeField]
		[Header("Pressed")]
		public ButtonWithSelectedImage buttonWithSelectedImage;

		public GameObject eyeDirection;

		public Button button;

		public GameObject iconGO;

		public Transform[] scaleTransforms;

		[SerializeField]
		[Header("RW")]
		public GameObject rushParentGO;

		public GameObject wParentGO;

		public GameObject[] subFaces;

		[SerializeField]
		[Header("Badges")]
		public Badge mainBadge;

		public GameObject pickupMissionBadge;

		[SerializeField]
		[Header("WMovie")]
		public RawImage wMovieImage;

		public int wMovieRow;

		public int wMovieColumn;

		public int wMovieSize;

		public float beforeWMovieWait;

		private const string prefUnlockW = "ExRushUnlockW";

		private Coroutine unlockCoroutine;

		private bool isEventEnded => default(bool);

		public void OnPageBecomeActive()
		{
		}

		private void DisableButton(bool withIcon = true)
		{
		}

		private void UpdateRush(List<QuestEventMenuElement> menuDataList)
		{
		}

		private IEnumerator RunUnlock()
		{
			return null;
		}

		private List<QuestEventMenuElement> GetQuestList(bool onlyAvailable, bool excludeQuestAfterEnd)
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		private void UpdateBadge()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public void OnPressed()
		{
		}
	}
}
