using UnityEngine;

namespace Gluon
{
	public class ExtensionImageEffect : ImageEffectBase
	{
		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u0083ã\u0083\u0081å\u0085\u0088ã\u0081§ã\u0081®å\u0087¦ç\u0090\u0086ã\u0081®é\u00a0\u0086ç\u0095ªã\u0082\u0092æ\u008c\u0087å®\u009aã\u0081\u0099ã\u0082\u008bID")]
		private int _imageEffectSubID;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0081\u0099ã\u0082\u008bå\u0085\u0088ã\u0081®ID")]
		private int _attachmentID;

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0081\u0095ã\u0082\u008cã\u0081\u009få\u0085\u0088ã\u0081®ã\u0082«ã\u0083¡ã\u0083©")]
		protected Camera _attachCamera;

		public int imageEffectSubID => default(int);

		public int attachmentID => default(int);

		public virtual void OnAttachCamera(Camera camera)
		{
		}
	}
}
