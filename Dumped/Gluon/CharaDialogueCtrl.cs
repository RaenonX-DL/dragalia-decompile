using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharaDialogueCtrl : FastUpdateMonoBehaviour
	{
		private class DialogueData
		{
			public CharaDialogueUI charaDialogue;

			public int index;
		}

		private class DialogueQueue
		{
			public Material material;

			public string text;

			public bool leftIcon;

			public string voice;

			public InGameSound.Priority voicePriority;

			public int indexData;

			public bool waitVoiceEnd;

			public bool isManual;

			public bool fastForward;

			public CharaDialogueUI.Balloon balloon;
		}

		private const int numDialogue = 3;

		private DialogueData[] dialogueData;

		private const int numDialogueQueue = 10;

		private DialogueQueue[] dialogueQueue;

		private int indexQueue;

		private int numQueue;

		private RectTransform rootRect;

		private bool isActive;

		private InGameFollowLayout followLayout;

		public int NumQueue => default(int);

		public CharacterTalkCtrl characterTalkCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Visible(bool b, bool force = false)
		{
		}

		public static CharaDialogueCtrl Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private string GetAllSerifText(bool isDragon)
		{
			return null;
		}

		private void Initialize(GameObject parent, GameObject prefab)
		{
		}

		public void LoadDragonFont()
		{
		}

		private void OnAttachedFollowLayout()
		{
		}

		public int GetSiblingIndex()
		{
			return default(int);
		}

		public bool Display(CharacterBase chara, string str, bool leftIcon, string voice, CharaDialogueUI.Balloon balloon = CharaDialogueUI.Balloon.Standard, bool isManual = false, bool waitVoiceEnd = false, bool fastForward = false)
		{
			return default(bool);
		}

		public bool Display(int faceId, string str, bool leftIcon, string voice, InGameSound.Priority voicePriority, CharaDialogueUI.Balloon balloon = CharaDialogueUI.Balloon.Standard, bool isManual = false, bool waitVoiceEnd = false, bool fastForward = false)
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		private void SetFastForward(bool b)
		{
		}

		private int GetData()
		{
			return default(int);
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public void Release()
		{
		}

		public bool SetText(string str, string voice)
		{
			return default(bool);
		}

		public bool Close(bool force = false)
		{
			return default(bool);
		}

		public void ClearDialogueQueue()
		{
		}
	}
}
