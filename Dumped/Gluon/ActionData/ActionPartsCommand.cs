using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=39064194")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/Command : ã\u0082³ã\u0083\u009eã\u0083³ã\u0083\u0089", 0)]
	public class ActionPartsCommand : ActionParts
	{
		[SerializeField]
		private CommandData _data;

		public override PartsData data => null;
	}
}
