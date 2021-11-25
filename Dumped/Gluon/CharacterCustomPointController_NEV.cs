using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Bullet;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_NEV : CharacterCustomPointController
	{
		public enum CommandType
		{
			None,
			SetMaxChargeLevel,
			ResetAll,
			OnShootOption,
			OnAttachedToEnemy
		}

		private bool IsExecutedAppear
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool IsReserveAppear
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private NevOptionEventAppearNevOptionParam ReserveAppearParam
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void Update()
		{
		}

		public override bool OnCommand(int commandType, int param, CharacterBase aboutChara)
		{
			return default(bool);
		}

		public void SendNevOptionEvent(NevOptionEvent.NevOptionEventTypes type, NevOptionEventParamBase param)
		{
		}

		public void OnReceiveNevOptionEvent(NevOptionEvent recvEvent)
		{
		}

		private List<NevOptionBulletObject> OnShootOption(int chargeLv, [Optional] int[] searchingProductIds)
		{
			return null;
		}

		private void OnAppearNevOption(NevOptionEventAppearNevOptionParam param)
		{
		}

		public void SetReserveAppear(NevOptionEventAppearNevOptionParam param)
		{
		}
	}
}
