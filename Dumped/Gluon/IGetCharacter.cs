namespace Gluon
{
	public interface IGetCharacter
	{
		int characterCount { get; }

		CharacterBase GetCharacter(int index);
	}
}
