

// switch expression
using System.Security.Cryptography;

string ToString(int i) {
    return i switch {
        23  => "a mystical number",
        42  => "the answer to life, the universe and everything",
        187 => "MDK - murder,death,kill",
        _ => $"{i}"
    };
}

Console.WriteLine(ToString(1));
Console.WriteLine(ToString(11));
Console.WriteLine(ToString(23));
Console.WriteLine(ToString(42));
Console.WriteLine(ToString(187));
Console.WriteLine(ToString(666));


// multidimensional switch expression
string WeatherCondition(int temperature, string condition) {
    return (temperature, condition) switch {
        (>= 30, "Sunny") => "It's a hot and sunny day!",
            (>= 30, "Cloudy") => "It's warm, but the sky is overcast.",
            (>= 30, "Rainy") => "Hot and rainy weather. Keep dry!",
            (< 30, "Sunny") => "It's a pleasant day with clear skies.",
            (< 30, "Cloudy") => "The sky is overcast, and it might rain.",
            (< 5, "Rainy") => "OMG don't leave your bed today.",
            (< 30, "Rainy") => "Expect rain today. Don't forget your umbrella.",
            (_, _) => "Unknown weather condition."
    };
}


Console.WriteLine(WeatherCondition(30,"Sunny"));
Console.WriteLine(WeatherCondition(1,"Sunny"));
Console.WriteLine(WeatherCondition(1,"Rainy"));
Console.WriteLine(WeatherCondition(25,"Rainy"));
Console.WriteLine(WeatherCondition(40,"Rainy"));
Console.WriteLine(WeatherCondition(12,"Cloudy"));