# Listas de Exercícios
- [Lista 1](lista1/README.md)
- [Lista 2](lista2/README.md)

## Herança
![33333](https://user-images.githubusercontent.com/56240254/79496827-1a204f80-7ffd-11ea-871b-491904a59f5c.png)

![diagrama](https://user-images.githubusercontent.com/56240254/79788359-ea37bb80-831e-11ea-89c0-b9c3189ffc21.jpg)

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
```

### Construtores

Sempre que inicializamos uma classe filha de outra no C#, ela chama um construtor para inicializar a classe base.
Ou seja, na classe filha o construtor padrão implicito faz uma chamada ao construtor da classe pai. Exemplo:

```c#
class Carro : Veiculo
{
   public int QuantidadeAssentos { get; set; }
   
   public Carro() : base()
   {
   }
}
```

A partir do momento que fomos na classe pai e criamos um construtor, ele se torna o construtor padrão da classe.
Essa chamada ao construtor da classe pai não vai mais funcionar, pois não existe mais um construtor sem argumentos lá.
Para o código funcionar, temos que explicitamente criar o construtor padrão sem argumentos na classe pai.

```c#
public class Conta
{
  public Conta()
  {
  }
}
```
Construtores não são herdados.

Sempre que precisarmos de um construtor na classe filha igual ao da classe pai, precisamos declará-lo explicitamente.

```c#
public class ContaPoupanca : Conta
{
  public ContaPoupanca(Cliente titular)
  {
     this.Titular = titular;
  }
}
```

Esse construtor na classe filha faz exatamente a mesma coisa que o construtor da classe pai.
Podemos reaproveitar o comportamento do construtor da classe pai:

```c#
public class ContaPoupanca : Conta
{
/* chama o construtor da classe pai que tem os mesmos tipos de argumentos */
  public ContaPoupanca(Cliente titular) : base(titular)
  {
  }
}
```

*Construtores não são herdados pelas subclasses.*

*Subclasses utilizam, implicitamente ou explicitamente, construtores da superclasse para incializar os membros herdados.*

*Na forma explícita o programador chama algum construtor da superclasse através da instrução **base***.

*Na forma implícita o compilador utiliza o construtor padrão da classe base. Em caso de inexistência do construtor padrão na classe base, é gerado um erro de compilação.*

*Construtores das classes derivadas devem obrigatoriamente chamar algum construtor da classe base, seja de forma implícita ou explícita.*


### Reaproveitando a implementação da classe base

As implementações dos métodos Saca das classes Conta e ContaPoupanca são praticamente iguais, com poucas mudanças.

Quando fazemos a sobrescrita de métodos em uma classe filha, muitas vezes, queremos apenas mudar pouca coisa do comportamento da classe base.

No código da classe filha, podemos reutilizar o código da classe pai com a palavra-chave **base** chamando o comportamento que queremos reaproveitar.

Então o código do método Saca da ContaPoupanca poderia ser reescrito da seguinte forma:

```c#
public class ContaPoupanca : Conta
{
   public override void Saca(double valor)
   {
   /* chama o método da classe pai passando como argumento valor + 0.10 */
      base.Saca(valor + 0.10);
   }
}
```

Dessa forma a classe filha não está utilizando a propriedade Saldo da Conta, que pode ser private.

```c#
public class Conta
{
   public double Saldo { get; private set; }
   
   // outras propriedades e métodos
}
```
