using UnityEngine;

namespace Gluon
{
	public class DmodeActiveAbilityListPopup : PopupBase
	{
		public enum Mode
		{
			Unit,
			Fafnir
		}

		[SerializeField]
		[Header("Content")]
		public DmodeUnifiedAbilityCell template;

		public GameObject emptyGO;

		public DmodeExAbilityCell exTemplate;

		public GameObject exLine;

		public GameObject lexLine;

		public static readonly string prefabPath;

		private Mode mode;

		public static DmodeActiveAbilityListPopup Create(Mode mode)
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
