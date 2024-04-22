
//Faça um programa para ler a base e a altura de um retângulo e mostrar seu perímetro, área e diagonal.

class Program {
    public static void Main(){
        Double b,h,perimetro,area,diagonal; //definindo as variáveis que serão utilizadas
        Console.Write("Escreva o valor da base: ");
        b=Double.Parse(Console.ReadLine()); //obter valor da base
        Console.Write("Escreva o valor da altura: ");
        h=Double.Parse(Console.ReadLine()); //obter valor da altura
        perimetro=2*(h+b); //calculando o perimetro
        area=h*b; //calculando a area
        diagonal=Math.Sqrt(Math.Pow(b,2)+Math.Pow(h,2)); //calculando a diagonal
        Console.Write("Perímetro: {0}, Área: {1}, Diagonal: {2:f3}.",perimetro,area,diagonal); //resultado dos cálculos
    }
}