using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class FieldTalkTrigger : FieldTriggerBase
	{
		[SerializeField]
		[HideInInspector]
		private List<int> fieldTalkMasterId;

		private List<FieldTalkElement> fieldTalkMasterElements;

		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;

		private BoxCollider hitCollider;

		private string GetVoiceResourceName(FieldTalkElement talkElem)
		{
			return null;
		}

		private string GetVoiceId(FieldTalkElement talkElem)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		protected virtual void OnCollided(GameObject target)
		{
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
		}
	}
}
