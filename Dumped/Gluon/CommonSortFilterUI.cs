using UnityEngine;

namespace Gluon
{
	public class CommonSortFilterUI : MonoBehaviour
	{
		[SerializeField]
		[Header("ç\u0084¡å\u008a¹å\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0082½ã\u0083¼ã\u0083\u0088ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		private GiftType[] disableTargetSortTypes;

		[SerializeField]
		[Header("ç\u0084¡å\u008a¹å\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0082½ã\u0083¼ã\u0083\u0088ã\u0083\u0097ã\u0083ªã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		private CommonSortModel.Preset[] disableTargetSortPresets;

		[HideInInspector]
		public GiftType targetSortType;

		[HideInInspector]
		public CommonSortModel.Preset targetSortPreset;

		private bool isForceSetActive;

		private bool isFilterActive;

		private bool isStartTaskEnded;

		private void Start()
		{
		}

		public void SetActive(bool isActive)
		{
		}
	}
}
