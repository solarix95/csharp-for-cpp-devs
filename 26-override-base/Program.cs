
using System.Reflection.Metadata.Ecma335;


var texture = new GameTexture();

Console.WriteLine($"{nameof(texture)}.{nameof(texture.Name)} is {texture.Name}");
Console.WriteLine($"{nameof(texture)}.{nameof(texture.id)} is {texture.id}");


//------------------------------------------------------------------------------------------------------------
class GameAsset {    // base class

    public GameAsset() {
        Name = "Asset";
        id = 0;
    }

    public int id;
    public virtual string Name { get; }
}


class GameTexture : GameAsset { // derived class

    public GameTexture() {
        id = 1;
    }

    public new int id;    // "new": don't warn... i really wont to replace "id" of the baseclass..
    public override string Name { get  { return $"{base.Name}:texture"; } } // C++: "GameAsset::Name()"
    // public sealed override string Name { get  { return "texture"; } } // "sealed" -> Variant where "Name" can't be overridden anymore
}

