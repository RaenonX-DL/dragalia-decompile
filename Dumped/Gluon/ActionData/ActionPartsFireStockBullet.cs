using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=35742910#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E3%83%90%E3%83%AC%E3%83%83%E3%83%88%E7%B7%A8%EF%BC%89-ActionPartsFireStockBullet")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/ã\u0083\u0090ã\u0083¬ã\u0083\u0083ã\u0083\u0088/å¼¾ä\u00b8\u00b8ã\u0082¹ã\u0083\u0088ã\u0083\u0083ã\u0082\u00af(ç\u0099ºå°\u0084)", 0)]
	public class ActionPartsFireStockBullet : ActionParts
	{
		[SerializeField]
		private FireStockBulletData _data;

		public override PartsData data => null;
	}
}
