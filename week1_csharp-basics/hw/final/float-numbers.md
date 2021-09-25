Существуют разные типы данных, предназначенные для хранения числовых значений. В этом задании мы частично реализуем тип данных с одинарной точностью(float) согласно стандарту IEEE_754(https://en.wikipedia.org/wiki/IEEE_754). Цель задания - разобраться в устройстве памяти компьютера и двоичной/десятичной системах счисления а также работа с битовыми операциями(сначала можно сделать в лоб, без них)

Задание: реализовать класс MyFloat32

// число с плавающей запятой, должно быть реализовано согласно стандарту IEEE_754
public class MyFloat32 
{
    // вернуть значение числа в десятичном представлении
    public float ToDecimal();

    // следующее float32 число из области значения
    public MyFloat32 Next();

    // предыдущее float32 число из области значения
    public MyFloat32 Prev();

    // операция сложения таких чисел
    public static MyFloat32 operator +(MyFloat32 a)
    // операция вычитания таких чисел
    public static Fraction operator -(Fraction a)
}

Полезные ссылки: 
- https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/built-in-types
- https://habr.com/ru/post/112953/
- https://www.h-schmidt.net/FloatConverter/IEEE754.html
- https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/operator-overloading
- https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

Классные видео по теме:
- https://www.youtube.com/watch?v=mKJiD2ZAlwM
- https://www.youtube.com/watch?v=tx-M_rqhuUA