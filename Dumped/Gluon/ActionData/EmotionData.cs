using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EmotionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private NotifyCharacter.EmotionType _emotion;

		public NotifyCharacter.EmotionType emotion => default(NotifyCharacter.EmotionType);
	}
}
