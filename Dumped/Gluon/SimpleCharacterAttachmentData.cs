using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class SimpleCharacterAttachmentData : ScriptableObject
	{
		public CharacterAnimatedAttachment.MotionState[] attachMotionStateList;
	}
}
