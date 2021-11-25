using UnityEngine;

namespace Gluon
{
	public class ImageEffectAttachment : ImageEffectBase
	{
		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0081\u0095ã\u0082\u008cã\u0082\u008bå\u00a0\u00b4æ\u0089\u0080ã\u0081®ID")]
		private int _attachmentID;

		private GameObject _attachImageEffectPrefab;

		public int attachmentID => default(int);

		public bool AttachImageEffect(string prefabPath)
		{
			return default(bool);
		}
	}
}
