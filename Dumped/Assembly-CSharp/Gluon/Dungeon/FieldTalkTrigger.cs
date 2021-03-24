/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class FieldTalkTrigger : FieldTriggerBase
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private List<int> fieldTalkMasterId;
		private List<FieldTalkElement> fieldTalkMasterElements;
		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;
		private BoxCollider hitCollider;
	
		// Constructors
		public FieldTalkTrigger();
	
		// Methods
		private string GetVoiceResourceName(FieldTalkElement talkElem);
		private string GetVoiceId(FieldTalkElement talkElem);
		protected override void Awake();
		protected virtual void OnCollided(GameObject target);
		protected virtual void OnTriggerEnter(Collider other);
	}
}
