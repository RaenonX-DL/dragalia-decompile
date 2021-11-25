using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ButtonSound : MonoBehaviour
	{
		public enum SEType
		{
			SE_None,
			SE_Decide,
			SE_Cancel,
			SE_Decide2,
			SE_Item,
			SE_ChangeChara,
			SE_WindowCutIn,
			SE_ExpCount,
			SE_LevelUpFinish,
			SE_LiruCount,
			SE_RankUp,
			SE_OpenBox,
			SE_DONOTUSE_Dial,
			SE_ChangeStamp,
			SE_PageFlipped
		}

		public SEType seType;

		private UnityAction callPlaySeAction;

		public SEType longSeType;

		private UnityAction callPlayLongSeAction;

		public static string GetSEName(SEType type)
		{
			return null;
		}

		private static string GetSEGroupStr()
		{
			return null;
		}

		protected void PlaySE(SEType type)
		{
		}

		private void Awake()
		{
		}

		public void SetActions()
		{
		}

		public UnityAction GetAction()
		{
			return null;
		}
	}
}
