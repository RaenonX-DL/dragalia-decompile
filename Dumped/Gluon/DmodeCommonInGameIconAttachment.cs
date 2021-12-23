using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeCommonInGameIconAttachment : MonoBehaviour
	{
		[Flags]
		public enum EnableFlag
		{
			None = 0x1,
			New = 0x2,
			SkillAbility = 0x4,
			Owner = 0x8
		}

		public const EnableFlag defaultEnableFlag = EnableFlag.SkillAbility | EnableFlag.Owner;

		[SerializeField]
		[Header("Component")]
		private Graphic abilityImage;

		[SerializeField]
		private Graphic skillImage;

		[SerializeField]
		private Graphic ownerImage;

		[SerializeField]
		private GameObject newFlag;

		private static readonly string prefabPath;

		public static DmodeCommonInGameIconAttachment Create(Transform parent)
		{
			return null;
		}

		public void SetAttachments(DmodeDungeonItemType type, int id, EnableFlag enableFlag)
		{
		}
	}
}
