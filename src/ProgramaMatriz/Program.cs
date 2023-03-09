Console.WriteLine("--------------------------------------  EXERCICIO 01-----------------------------------------------------------");

double[,] mat = new double[5, 3];

Random sorteio = new Random();


//Carregar os valores da matriz

for(int c =0; c < mat.GetLength(1); c++)
{
    for(int l=0; l < mat.GetLength(0); l++)
    {
        mat[c,l] = sorteio.Next(10);
    }
}

// calculo da terceira coluna 
Console.WriteLine("Calculando...");

    for (int l = 0; l < mat.GetLength(0); l++)
    {
        mat[l,2] = (mat[l,0]+ mat[l,1]) / 2;
    }

//impressao da matriz
Console.WriteLine("Os valores da matriz são: ");
for (int l = 0; l < mat.GetLength(0); l++)
{
    for (int c = 0; c < mat.GetLength(1); c++)
    {
        Console.Write("\tmat[" + l + "][" + c + "]=" + mat[l,c].ToString("F2"));
    }
    Console.WriteLine();
}


Console.WriteLine("----------------------------------------EXERCÍCIO 02---------------------------------------------------------");

int[,] mat1 = new int[5, 5];
Random sorteio1 = new Random();

for (int c=0; c< mat1.GetLength(1); c++)
{
    for(int l=0; l<mat1.GetLength(0); l++)
    {
        mat1[l, c] = sorteio1.Next(1000);
    }
}

Console.WriteLine("Os valores da matriz são: ");
for (int l = 0; l < mat1.GetLength(0); l++)
{
    for (int c = 0; c < mat1.GetLength(1); c++)
    {
        Console.Write("\tmat[" + l + "][" + c + "]=" + mat1[l, c].ToString("F2"));
    }
    Console.WriteLine();
}


//soma das linhas

Console.WriteLine("Soma das Linhas:");
for(int l =0; l < mat1.GetLength(0); l++)
{
    Console.Write("Soma da linha [" + l + "]= ");
    int somaLinha = 0;
    for (int c = 0; c < mat1.GetLength(1); c++)
    {
        //somalinha = somalinha + mat[l,c];
        somaLinha += mat1[l, c];
    }
    Console.WriteLine(somaLinha);
}
// soma das colunas 
Console.WriteLine("Soma das Colunas: ");
for(int c= 0; c< mat1.GetLength(1); c++)
{
    Console.WriteLine("Soma da Coluna [" + c + "]");
    int somaColuna = 0;
    for (int l = 0; l < mat1.GetLength(0); l++)
    {
        somaColuna += mat1[l,c];
    }
    Console.WriteLine(somaColuna);
}

//Soma da diagonal principal
Console.Write("Soma da Diagonal Principal..");
int diagonal = 0;
for (int c= 0;c< mat1.GetLength(1); c++)
{
    diagonal += mat1[c, c];
}
Console.WriteLine(diagonal);


// Soma diagonal Secundaria
Console.Write("Soma da Diagonal Segundária");
int diagonalsecundaria = 0;

for (int c = 0; c < mat1.GetLength(1); c++)
{
    diagonalsecundaria += mat1[c, mat1.GetLength(1)-c-1];

}
Console.WriteLine(diagonalsecundaria);




Console.WriteLine("----------------------------------------EXERCÍCIO 03---------------------------------------------------------");

int[,] mat2 = new int[3, 3];
int[,] mat3 = new int[3, 3];


Random sorteio2 = new Random();


//Carregar os valores da matriz



for (int l = 0; l < mat2.GetLength(0); l++)
{
    for (int c = 0; c < mat2.GetLength(1); c++)
    {
        mat2[l,c] = sorteio2.Next(10);
    }
    Console.WriteLine();

}

//matriz inversa
int ultimaLinha= mat.GetLength(0)-1;
int ultimaColuna = mat.GetLength(1)-1;


for (int l = 0; l < mat2.GetLength(0); l++)
{
    for (int c = 0; c < mat2.GetLength(1); c++)
    {
        mat3[ultimaLinha - l , ultimaColuna - c] = mat2[l, c]; 
    }
    Console.WriteLine();

}





//impressao da matriz
Console.WriteLine("Os valores da matriz são: ");

for (int l = 0; l < mat3.GetLength(0); l++)
{
    for (int c = 0; c < mat3.GetLength(1); c++)

    {


        Console.Write("\tmat3[" + l + "][" + c + "]=" + mat3[l, c].ToString("d4"));
    }
    Console.WriteLine();
}
    Console.WriteLine("**************************************************************************************************");





//outra forma
//matriz inversa


for (int l = 0, l2 = mat2.GetLength(0) - 1; l < mat2.GetLength(0); l++, l2--)
{
    for (int c = 0, c2 = mat2.GetLength(1); c < mat2.GetLength(1); c++, c2--)
    {
        mat3[l2, c2] = mat2[l, c];
    }
    Console.WriteLine();
}

        //impressao da matriz
        Console.WriteLine("Os valores da matriz são: ");

    for (int l = 0; l < mat3.GetLength(0); l++)
    {
        for (int c = 0; c < mat3.GetLength(1); c++)

        {


            Console.Write("\tmat3[" + l + "][" + c + "]=" + mat3[l, c].ToString("d4"));
        }
        Console.WriteLine();
    }
   