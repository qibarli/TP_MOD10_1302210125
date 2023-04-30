using AljabarLibraries;

Double[] akarpersamaankuadrat = AljabarLibraries.QuadraticForm.akarpersamaankuadrat(new double[] { 1, -3, -10 });
Double[] hasilkuadrat = AljabarLibraries.QuadraticForm.hasilkuadrat(new double[] { 2, -3 });

Console.WriteLine($"akar persamaan X^8-11x-2 = 2 yaitu :\n" +
    $"X1 = {akarpersamaankuadrat[0]}\n" +
    $"X2 = {akarpersamaankuadrat[1]}\n\n" +
    $"hasil quadrat (4x-2)^6 : {hasilkuadrat[0]}x^6{hasilkuadrat[1]}x+{hasilkuadrat[2]}\n" +
    $"hasil bentuk array : {{{string.Join(", ", hasilkuadrat)}}}");