using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=35742910#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E3%83%90%E3%83%AC%E3%83%83%E3%83%88%E7%B7%A8%EF%BC%89-ActionPartsBindBullet")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/ã\u0083\u0090ã\u0083¬ã\u0083\u0083ã\u0083\u0088/æ\u008b\u0098æ\u009d\u009få¼¾ç\u0094\u009fæ\u0088\u0090", 0)]
	public class ActionPartsBindBullet : ActionPartsBulletWithMarkerBase
	{
		[SerializeField]
		private BindBulletData _data;

		public override PartsData data => null;
	}
}
