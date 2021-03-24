/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsSabnackDarkTorrent : Gluon.ActionParts
	{
		// Fields
		private List<CharacterBase> _listTarget;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
		private readonly SabnackDarkTorrentData _partsData;
	
		// Constructors
		public ActionPartsSabnackDarkTorrent(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		private void SetUp(CondensBulletObject bullet, int idx);
		private void SetMultiPlayerTarget();
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
	}
}
