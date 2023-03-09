Console.WriteLine("--------------------------------------  EXERCICIO 01-----------------------------------------------------------");

double[,] matrizMedia = new double[5, 3];


for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        if (coluna == 2)
        {
            matrizMedia[linha, 2] = (matrizMedia[linha, 0] + matrizMedia[linha, 1]) / 2;

        }
        else
        {
            matrizMedia[linha, coluna] = linha * coluna;
        }


        Console.Write("|" + matrizMedia[linha, coluna]);
    }

    Console.WriteLine();
}

Console.WriteLine("----------------------------------------EXERCÍCIO 02---------------------------------------------------------");

double[,] matrizOriginal = new double[5, 5];

double somaDasLinhas = 0;
double somaDasColunas = 0;
double somaDaDiagonalPrincipal = 0;
double somaDaDiagonalSecundaria = 0;


for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        matrizOriginal[linha, coluna] = linha * coluna;
        Console.Write("|" + matrizOriginal[linha, coluna]);
    }

    Console.WriteLine();
}

Console.WriteLine("--------------------------------------------------------");

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        somaDasLinhas += matrizOriginal[linha, coluna];
    }
    Console.WriteLine("A soma da linha " + linha + " é igual a: " + somaDasLinhas);
    somaDasLinhas = 0;
    Console.WriteLine();
}

Console.WriteLine("--------------------------------------------------------");


for (int coluna = 0; coluna < 5; coluna++)
{
    for (int linha = 0; linha < 5; linha++)
    {
        somaDasColunas += matrizOriginal[linha, coluna];
    }

    Console.WriteLine("A soma da coluna " + coluna + " é igual a: " + somaDasColunas);
    somaDasColunas = 0;
    Console.WriteLine();
}


Console.WriteLine("------------------------------------------------------");

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        if (linha == coluna)
        {
            somaDaDiagonalPrincipal += matrizOriginal[linha, coluna];
        }
    }
}

Console.WriteLine("A soma da diagonal primária é " + somaDaDiagonalPrincipal);

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        if ((linha + coluna) == 4)
        {
            somaDaDiagonalSecundaria += matrizOriginal[linha, coluna];
        }
    }

}

Console.WriteLine("A soma da diagonal secundária é " + somaDaDiagonalSecundaria);






Console.WriteLine("----------------------------------------EXERCÍCIO 03---------------------------------------------------------");

double[,] matrizInversa = new double[3, 3];


for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        matrizInversa[linha, coluna] = linha * coluna;
        Console.Write("|" + matrizInversa[linha, coluna]);
    }

    Console.WriteLine();
}


Console.WriteLine("------------------------------------------------------");



for (int linha = 2; linha >= 0; linha--)
{
    for (int coluna = 2; coluna >= 0; coluna--)
    {
        Console.Write("|" + matrizInversa[linha, coluna]);
    }

    Console.WriteLine();
}