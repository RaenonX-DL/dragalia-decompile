using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class RaidPlayerBase : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform[] ofs;

		public const int numUI = 7;

		private const float waitSec = 1f;

		[HideInInspector]
		public RaidPlayerUI[] raidPlayer;

		private CharacterManager.PartyInfo partyInfo;

		private Coroutine coroutine;

		private RectTransform rectTrnasform;

		public int ActiveUINum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static RaidPlayerBase Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void Active(bool b)
		{
		}

		private IEnumerator UpdateInfo()
		{
			return null;
		}

		private void Update()
		{
		}

		public void CreateSandTimerUI()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void ShowSandTimerUI(int actorId)
		{
		}

		public void HideSandTimerUI()
		{
		}

		public void HideSandTimerUI(int actorId)
		{
		}

		public void SetSandTimerUICount(int actorId, int count)
		{
		}

		public void SetSandTimerUICountColor(int actorId, SandTimerUI.CountColorType type)
		{
		}

		public int GetActorSlot(int actorId)
		{
			return default(int);
		}
	}
}
