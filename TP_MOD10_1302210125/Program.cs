using AljabarLibraries;

Double[] akarpersamaankuadrat = AljabarLibraries.QuadraticForm.akarpersamaankuadrat(new double[] { 1, -3, -10 });
Double[] hasilkuadrat = AljabarLibraries.QuadraticForm.hasilkuadrat(new double[] { 2, -3 });

Console.WriteLine($"Akar Pesamaan Kuadrat X^2-3x-10 = 0 yaitu :\n" +
    $"X1 = {akarpersamaankuadrat[0]}\n" +
    $"X2 = {akarpersamaankuadrat[1]}\n\n" +
    $"Hasil Quadrat dari (2x-3)^2 : {hasilkuadrat[0]}x^2{hasilkuadrat[1]}x+{hasilkuadrat[2]}\n" +
    $"Hasil Dalam bentuk array : {{{string.Join(", ", hasilkuadrat)}}}");