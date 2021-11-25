using UnityEngine;

namespace Gluon
{
	public class InGameButtonSound : MonoBehaviour
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
			SE_Dial,
			SE_InGameDecide,
			SE_InGameCancel
		}

		public SEType seType;

		public static string GetSEName(SEType type)
		{
			return null;
		}

		protected void PlaySE(SEType type)
		{
		}

		private void Awake()
		{
		}
	}
}
