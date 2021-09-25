Существуют разные типы данных, предназначенные для хранения числовых значений. В этом задании мы частично реализуем тип данных с одинарной точностью(float) согласно стандарту IEEE_754(https://en.wikipedia.org/wiki/IEEE_754). Цель задания - разобраться в устройстве памяти компьютера и двоичной/десятичной системах счисления а также работа с битовыми операциями(сначала можно сделать в лоб, без них)

Задание: реализовать класс MyFloat32

```
/// <summary>
/// число с плавающей запятой согласно стандарту IEEE_754
/// </summary>
public class MyFloat32 
{
    /// <summary>
    /// Конструктор класса MyFloat32
    /// </summary>
    /// <param name="exponent"> Экспонента в виде строки </param>
    /// <param name="mantissa"> Мантисса в виде строки </param>
    /// <param name="sign"> Знак, '+' или '-' </param>
    public MyFloat32(string exponent, string mantissa, char sign)
    
    /// <summary>
    /// Конвертировать число в десятичное представление и вернуть его значение
    /// </summary>
    /// <returns> Значение числа в десятичном представлении </returns>
    public float ToDecimal();

    /// <summary>
    /// Следующее число с плавающей запятой из области значения
    /// </summary>
    /// <returns> Значение следующего числа </returns>
    public MyFloat32 Next();

    /// <summary>
    /// Предыдущее число с плавающей запятой из области значения
    /// </summary>
    /// <returns> Значение предыдущего числа </returns>
    public MyFloat32 Prev();

    /// <summary>
    /// Операция сложения
    /// </summary>
    /// <param name="f"> Второе слагаемое </param>
    /// <returns> Сумма чисел </returns>
    public static MyFloat32 operator +(MyFloat32 f)
    /// <summary>
    /// Операция вычитания
    /// </summary>
    /// <param name="f"> Вычитаемое </param>
    /// <returns> Разность чисел </returns>
    public static MyFloat32 operator -(MyFloat32 f)
}
```

Полезные ссылки: 
- https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/built-in-types
- https://habr.com/ru/post/112953/
- https://www.h-schmidt.net/FloatConverter/IEEE754.html
- https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/operator-overloading
- https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

Классные видео по теме:
- https://www.youtube.com/watch?v=mKJiD2ZAlwM
- https://www.youtube.com/watch?v=tx-M_rqhuUA