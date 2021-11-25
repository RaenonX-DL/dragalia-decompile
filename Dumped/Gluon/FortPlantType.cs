using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum FortPlantType
	{
		NONE,
		BASE,
		PRODUCE_GOLD,
		PRODUCE_FRUIT,
		BOOST_CHARA_WEAPON,
		BOOST_CHARA_ELEMENT,
		BOOST_CHARA_ALL,
		BOOST_DRAGON_DAMAGE,
		BOOST_DRAGON_TIME,
		DECORATION,
		BOOST_DRAGON_ELEMENT,
		CRAFT_WEAPON
	}
}
