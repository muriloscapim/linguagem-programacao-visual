# Lista 1

1. Faça um programa que receba um número e verifique se ele é negativo ou não negativo.
> Utilizar operador ternário.
2. Faça um programa que solicite a entrada de um número e exiba se o número é par ou ímpar.
> Utilizar operador ternário.
```c#
Console.WriteLine("Entre com um número inteiro: ");
// Parse() converte a representação de um nro lido de string em inteiro
int nro = int.Parse(Console.ReadLine());

if (nro % 2 == 0) {
    Console.WriteLine("Par");
}
else {
    Console.WriteLine("Impar");
}
```
3. Faça um programa que compara a soma de dois números se o valor for maior que 10 incrementa a soma em 5. Se o valor for menor que 10, decrementa a soma em 7.
4. Faça um programa que solicite ao usuário duas notas e o respectivo peso de cada uma das notas de duas provas realizadas por um aluno e calcule a média ponderada.
> A média ponderada é a soma da multiplicação de cada nota pelo seu respectivo peso e dividido pela soma dos pesos.
5. Faça um programa que calcule a velocidade média de um veículo qualquer, leia a distância percorrida pelo veículo e o tempo gasto no percurso. O cálculo da velocidade média é distância/tempo.
6. Crie um programa que calcule o salário mensal de um vendedor de uma revendedora de carros. O vendedor recebe uma comissão por cada carro vendido e mais 5% sobre o valor total das vendas.
Solicitar ao usuário o número de identificação do vendedor, seu salário fixo, a quantidade de carros vendidos, o valor da comissão por cada carro vendido e o valor total das vendas. Exibir o número de identificação e seu salário total.
7. Crie um programa que tenha como finalidade calcular o reajuste salarial de um funcionário. Solicitar ao
usuário o código do funcionário e seu salário atual. Calcular o novo salário do funcionário de acordo com as condições:
> Utilizar estrutura de seleção if/else aninhadas. 

| Índice de Aumento | Salário Atual |
| --- | --- |
| 10% | R$ 0,00 - R$ 300,00 |
| 11% | R$ 301,01 - R$ 600,00 |
| 12% | R$ 600,01 - R$ 900,00 |
| 6% | R$ 900,01 - R$ 1500,00 |
| 3% | R$ 1500,01 - R$ 2000,00 |
| Sem aumento | Acima de R$ 2000,00 |

Exibir para o usuário a seguinte mensagem: "O funcionário 123, teve um aumento de R$ 45,00,
e agora seu salário é: R$ 1545,00", caso o funcionário não tenha aumento exibir: "O funcionário 123,
não teve aumento, o salário é: R$ 2100,00".
> Utilizar a interpolação de strings e delimitar o número de casas decimais do salário.