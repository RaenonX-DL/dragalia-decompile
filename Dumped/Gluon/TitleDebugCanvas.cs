using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TitleDebugCanvas : MonoBehaviour
	{
		[Tooltip("ã\u0083\u0087ã\u0083\u0090ã\u0083\u0083ã\u0082°ç\u0094\u00a8ã\u0081®ã\u0083\u009cã\u0082¿ã\u0083³ã\u0081®ã\u0082²ã\u0083¼ã\u0083\u00a0ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		public GameObject showDebugButton;

		[Tooltip("_GluonResourcesã\u0081®ã\u0083\u0096ã\u0083©ã\u0083³ã\u0083\u0081å\u0090\u008d")]
		public Text resourceBranchName;

		[Tooltip("ã\u0082µã\u0083¼ã\u0083\u0090ã\u0083¼ID")]
		public Text serverID;

		[Tooltip("ã\u0083\u0093ã\u0083«ã\u0083\u0089ç\u0095ªå\u008f·")]
		public Text buildNumber;

		[Tooltip("ã\u0082¢ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0081®ã\u0083¢ã\u0083¼ã\u0083\u0089")]
		public Text assetMode;

		[Tooltip("GPUã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0082¿ã\u0082¹æ\u0083\u0085å\u00a0±")]
		public Text gpuStatus;
	}
}
