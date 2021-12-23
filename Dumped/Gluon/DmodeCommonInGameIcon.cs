using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeCommonInGameIcon : MonoBehaviour
	{
		[SerializeField]
		[Header("Component")]
		private Graphic image;

		[SerializeField]
		private GameObject emptyGO;

		[SerializeField]
		private GameObject countPlate;

		[SerializeField]
		private Text countText;

		[SerializeField]
		private Button button;

		[SerializeField]
		private Button emptyButton;

		[SerializeField]
		private GameObject disableMask;

		[SerializeField]
		private GameObject alternativeDisableMask;

		[SerializeField]
		[Header("List")]
		private Text hpText;

		[SerializeField]
		private Text atkText;

		[SerializeField]
		private Text abilityText;

		[SerializeField]
		private DmodeItemDetailInfoBaseCell skillCell;

		[SerializeField]
		[EnumFlags]
		private DmodeCommonInGameIconAttachment.EnableFlag attachmentEnableFlag;

		private GameObject originalDisableMask;

		private DmodeCommonInGameIconAttachment attachment;

		private bool inactivePressMode;

		private DmodeDungeonItem item;

		private Action<DmodeDungeonItemType, int> onPressed;

		private Action<DmodeDungeonItemType, int> originalOnPressed;

		private Action<DmodeDungeonItemType, int> onLongPressed;

		private int customId;

		public DmodeDungeonItemType type
		{
			[CompilerGenerated]
			get
			{
				return default(DmodeDungeonItemType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int itemId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private int validId => default(int);

		private int validIdForDetail => default(int);

		private void Initialize(IconLoader.Size size)
		{
		}

		public void SetAsCurrentChara()
		{
		}

		public void SetupByTypeAndItemId(DmodeDungeonItemType type, int itemId, IconLoader.Size size = IconLoader.Size.M)
		{
		}

		public void SetupByTypeAndId(DmodeDungeonItemType type, int id, IconLoader.Size size = IconLoader.Size.M, [Optional] DmodeDungeonItem item)
		{
		}

		public void SetupByItem(DmodeDungeonItem item, IconLoader.Size size = IconLoader.Size.M)
		{
		}

		public void ClearId()
		{
		}

		public void SetupById(int id, IconLoader.Size size = IconLoader.Size.M)
		{
		}

		private void SetImageOnOff(bool v)
		{
		}

		public void SetupCallbacks(Action<DmodeDungeonItemType, int> onPressed, [Optional] Action<DmodeDungeonItemType, int> onLongPressed)
		{
		}

		public void SetCountText(int count)
		{
		}

		public void SetCustomId(int customId)
		{
		}

		public void SetButtonEnable(bool v)
		{
		}

		public void SetAlternativeDisableMask(bool toAlt)
		{
		}

		public void SwitchToInactivePressMode(bool v, bool toggleInteractive = false)
		{
		}

		public void OnPressed()
		{
		}

		public void OnLongPressed()
		{
		}
	}
}
