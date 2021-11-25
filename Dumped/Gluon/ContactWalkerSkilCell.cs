using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactWalkerSkilCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon skillIcon;

		[SerializeField]
		private Text skillName;

		[SerializeField]
		private Text skillDiscription;

		public void Setup(SkillDataElement skillData)
		{
		}
	}
}
