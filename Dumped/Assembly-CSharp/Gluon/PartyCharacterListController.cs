/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyCharacterListController : CommonIconListController
	{
		// Fields
		public bool isOutButtonSelect;
	
		// Constructors
		public PartyCharacterListController();
	
		// Methods
		protected override CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum);
		public void SelectPartyInfoUpdate(PartySettingList[] partyList);
		public void SetSelectIconToOutButton(bool isShowSelect);
	}
}
