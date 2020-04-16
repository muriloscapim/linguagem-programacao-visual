# Listas de Exercícios
- [Lista 1](lista1/README.md)
- [Lista 2](lista2/README.md)

## Herança
![33333](https://user-images.githubusercontent.com/56240254/79496827-1a204f80-7ffd-11ea-871b-491904a59f5c.png)

![Class Diagram0](https://user-images.githubusercontent.com/56240254/79497452-1a6d1a80-7ffe-11ea-9bba-1e90b18b8a35.jpg)

```c#
class ContaPoupanca : Conta
{
}
```
A subclasse ou classe filha ContaPoupanca herda Conta e passa a ter todos os seus atributos e métodos.

A conta poupança tem o comportamento Saca() diferente, portanto podemos reescrever o comportamento na classe filha, indicando que o método foi reescrito usando a palavra *override*.
```c#
public override bool Saca(double valor)
{
    if (this.Saldo >= (valor + Taxa))
    {
        this.Saldo -= (valor + Taxa);
        return true;
    }
    return false;
}
```
Na classe pai indicamos que o método pode ser sobreescrito com a palavra-chave *virtual*.
```c#
public class Conta
{
    public virtual bool Saca(double valor)
    {
        if(this.Saldo >= valor)
        {
            this.Saldo -= valor;
            return true;
        }
        return false;
    }
}
```
```c#
ContaPoupanca c = new ContaPoupanca();
c.Taxa = 0.10;
/* A classe filha não sobrescreveu o método Deposita, o método na classe
pai será utilizado
*/
c.Deposita(100.0);
/* Usa o método Saca que foi sobrescrito na classe filha */
c.Saca(50.0);
```
O método Saca() na classe ContaPoupanca manipula o Saldo que é privado.

* Atributos **privados** só são visíveis para a classe que os declarou. Os filhos não enxergam.
* Atributos/métodos marcados como **protected** são visíveis apenas para a própria classe e para as classes filhas.

```c#
public class Conta
{
  public double Saldo { get; protected set; }
}
