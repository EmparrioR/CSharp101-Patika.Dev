Console.WriteLine(DateTime.Now.Hour); // Günün Şu anki saatini verir

Console.WriteLine(DateTime.Now.DayOfWeek);  // Günü string olarak
Console.WriteLine(DateTime.Now.DayOfYear); // Sayı olarak

Console.WriteLine(DateTime.Now.ToLongDateString()); // Bugünün tarihini uzun bir şekilde yazarak getirir
Console.WriteLine(DateTime.Now.ToShortDateString()); // Kısa şekilde tarihi yazar
Console.WriteLine(DateTime.Now.ToShortTimeString());
Console.WriteLine(DateTime.Now.ToLongTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(2));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMonths(11));

// DateTime Format

Console.WriteLine(DateTime.Now.ToString("dd")); // 24
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

Console.WriteLine(DateTime.Now.ToString("MM")); // 03
Console.WriteLine(DateTime.Now.ToString("MMM")); // Mar
Console.WriteLine(DateTime.Now.ToString("MMMM")); // March

Console.WriteLine(DateTime.Now.ToString("yy")); // 23
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2023

// *** Math Library ***

Console.WriteLine(Math.Abs(-25));

Console.WriteLine(Math.Ceiling(23.4)); // 24 Yukarı yuvarla
Console.WriteLine(Math.Floor(23.4)); // 23 Aşağı yuvarla
Console.WriteLine(Math.Round(23.6)); // 24 Tam olarak yuvarlama yapar 
Console.WriteLine(Math.Round(23.3)); // 23

Console.WriteLine(Math.Min(2,5)); // 2
Console.WriteLine(Math.Max(2,5)); // 5

Console.WriteLine(Math.Pow(2,5)); // 32 (üs)
Console.WriteLine(Math.Sqrt(25)); // 5 (karekök)

Console.WriteLine(Math.Log(9)); // e tabanındaki karşılığı
Console.WriteLine(Math.Exp(3)); // e üzeri 3'ü verir
Console.WriteLine(Math.Log10(100)); // 10 tabanındaki log karşılığını verir


