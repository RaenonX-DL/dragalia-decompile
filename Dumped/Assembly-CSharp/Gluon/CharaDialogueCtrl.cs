/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaDialogueCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		private const int numDialogue = 3;
		private DialogueData[] dialogueData;
		private const int numDialogueQueue = 10;
		private DialogueQueue[] dialogueQueue;
		private int indexQueue;
		private int numQueue;
		private RectTransform rootRect;
		private bool isActive;
		private InGameFollowLayout followLayout;
		[CompilerGenerated]
		private CharacterTalkCtrl _characterTalkCtrl_k__BackingField;
	
		// Properties
		public int NumQueue { get; }
		public CharacterTalkCtrl characterTalkCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private class DialogueData
		{
			// Fields
			public CharaDialogueUI charaDialogue;
			public int index;
	
			// Constructors
			public DialogueData();
		}
	
		private class DialogueQueue
		{
			// Fields
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
	
			// Constructors
			public DialogueQueue();
		}
	
		// Constructors
		public CharaDialogueCtrl();
	
		// Methods
		private void Visible(bool b, bool force = false);
		public static CharaDialogueCtrl Create(GameObject parent, int siblingIndex = -1);
		private string GetAllSerifText(bool isDragon);
		private void Initialize(GameObject parent, GameObject prefab);
		public void LoadDragonFont();
		private void OnAttachedFollowLayout();
		public int GetSiblingIndex();
		public bool Display(CharacterBase chara, string str, bool leftIcon, string voice, CharaDialogueUI.Balloon balloon = CharaDialogueUI.Balloon.Standard, bool isManual = false, bool waitVoiceEnd = false, bool fastForward = false);
		public bool Display(int faceId, string str, bool leftIcon, string voice, InGameSound.Priority voicePriority, CharaDialogueUI.Balloon balloon = CharaDialogueUI.Balloon.Standard, bool isManual = false, bool waitVoiceEnd = false, bool fastForward = false);
		public override void FastUpdate();
		private void SetFastForward(bool b);
		private int GetData();
		public bool IsActive();
		public void Release();
		public bool SetText(string str, string voice);
		public bool Close(bool force = false);
		public void ClearDialogueQueue();
	}
}
