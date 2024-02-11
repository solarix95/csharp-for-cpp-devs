
var asset   = new GameAsset();
var texture = new GameTexture();
var fx = new GameSoundFx();

Console.WriteLine($"{nameof(asset)}.{nameof(asset.Name)} is {asset.Name}");
Console.WriteLine($"{nameof(texture)}.{nameof(texture.Name)} is {texture.Name}");

Console.WriteLine($"{nameof(asset)} is an GameAsset: {asset is GameAsset}");
Console.WriteLine($"{nameof(asset)} is an GameTexture: {asset is GameTexture}");
Console.WriteLine($"{nameof(texture)} is an GameAsset: {texture is GameAsset}");
Console.WriteLine($"{nameof(fx)} is an GameAsset: {fx is GameAsset}");

GameAsset asset2 = texture; // "Upcast": no cast needed.
Console.WriteLine($"{nameof(asset2)} is an asset: {asset2 is GameAsset}");
GameTexture texture2 = (GameTexture)asset2; // "Downcast": cast needed.. same as "static_cast" in c++.. more or less. c++-casts don't have execption..
Console.WriteLine($"{nameof(texture2)} is an asset: {texture2 is GameAsset}");

// lets try an invalid downcast
try {
   GameSoundFx fx2 = (GameSoundFx)asset2; // "Downcast": cast needed... but asset2 is currently a "texture".. :(
} catch {
    Console.WriteLine("Ooops... that cast went wrong.");
}

// "is" operator... no exception expected :)
if (asset2 is GameTexture) // similar to "dynamic_cast" in c++
    Console.WriteLine($"Yes: cast {nameof(asset2)} to  GameTexture! ");
else 
    Console.WriteLine($"No: don't cast {nameof(asset2)} to  GameTexture!");


if (asset2 is GameSoundFx)
    Console.WriteLine($"Yes: cast {nameof(asset2)} to  GameSoundFx! ");
else 
    Console.WriteLine($"No: don't cast {nameof(asset2)} to  GameSoundFx!");

GameTexture ?texture3 = asset2 as GameTexture;
Console.WriteLine($"\"As\" operator was successful: {texture3 != null}");

//------------------------------------------------------------------------------------------------------------
class GameAsset {    // base class

    public GameAsset() {
        Name = "Asset";
    }
    public string Name {
        get;set;
    }
}


class GameTexture : GameAsset { // derived class

    public GameTexture() {
        Name = "Texture";
    }
    public int TextureId {
        get;set;
    }
}


class GameSoundFx : GameAsset {    

    public GameSoundFx() {
        Name = "FX";
    }
}