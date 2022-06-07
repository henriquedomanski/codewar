//QUESTION

//  Consider an array/list of sheep where some sheep may be missing from their place. 
// We need a function that counts the number of sheep present in the array (true means present).
// // For example,


// Programa para contar a quantidade de OVELHAS presentes em uma lista

using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        var sheepCounter = 0; //criando uma variavel de contador

        for (var perSheep = 0; perSheep < sheeps.Length; perSheep++)
        {

            /*1. criando uma variavel para percorrer a lista de ovelhas (perSheep) lista está em (sheeps)
              2. Se as ovelhas na posição do perSheep for igual a TRUE, o contador vai continuar
              3. Retorna quantas ovelhas tinham na lista            
            */

            if (sheeps[perSheep] == true)
            {
                sheepCounter++;
            }
        }
        return sheepCounter;

    }

}

// amostra de testes

// using System;
// using NUnit.Framework;

// [TestFixture]
// public class CountSheepsTests {

//   [Test]
//   public void SampleTest() {
//     var sheeps = new bool[] { true, false, true };

//     Assert.AreEqual(2, Kata.CountSheeps(sheeps));
//   }
// }
