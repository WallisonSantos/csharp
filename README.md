<h1 align="center"> CSharp </h1>

<p align="center">
<img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge"/>

[![GitHub stars](https://img.shields.io/github/stars/WallisonSantos/csharp?style=social)](https://github.com/WallisonSantos/csharp)

<h4 align="center"> :construction:  Projeto em construção  :construction: </h4>

<p>

# CSharp

## Bloco Padrão - Main CSharp

    using System;
    using System.Globalization;
    namespace csharp
    {
        class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }

### Declaração de Constantes CSharp

    const float Pi = 3.14f;
    System.Console.WriteLine(Pi);

### Interpolação de strings

    int id_cliente = 1002;
    double saldo_estoque = 80.900;
    string razao_soc = "Supermercado Fmz";

    System.Console.WriteLine(" num_cliente: {0} - posicao_estoque: {1:F3} - nome_cliente: {3} ", id_cliente, saldo_estoque, razao_soc);
    System.Console.WriteLine($" num_cliente: {id_cliente} - posicao_estoque {saldo_estoque:F3} - nome_cliente: {razao_soc} ");
    Console.ReadLine();

### Retorno do valor máximo para um tipo de dados

    byte    b       = byte.MaxValue;
    int     inteiro = int.MaxValue;
    double  doub    = double.MaxValue;
    decimal dec     = decimal.MaxValue;

    Console.WriteLine(b);
    Console.WriteLine(inteiro);
    Console.WriteLine(doub);
    Console.WriteLine(dec);

### Usar InvariantCulture para formatar sem considerar uma formatação especifica de país

    double salario;
    salario = 3000.222;
    System.Console.WriteLine(salario.ToString("F4",CultureInfo.InvariantCulture));

    int   salario2;

    salario2 = (int)salario;

    System.Console.WriteLine(salario2.ToString("F4",System.Globalization.CultureInfo.InvariantCulture));
    System.Console.WriteLine(salario.ToString("F4", System.Globalization.CultureInfo.InvariantCulture));

### Uso de Casting: Conversão Explicita e Operadores aritméticos

    int    n1 =  3 + 4  * 2;
    int    n2 = (3 + 4) * 2;
    int    n3 = 17 % 3;
    int    n4 = (int) 10.0 / 8;
    int    n5 = 10 / 8;
    double n6 = (double) 10 / 8;
    double n7 = 10.0 / 8;

    System.Console.WriteLine($" n1:{n1} - n2:{n2} - n3:{n3} - n4:{n4} - n5:{n5} - n6:{n6} - n7:{n7}");

    double  a = 1,  b = -3,  c = -4,  exp = 2;
    double  delta  =  Math.Pow( b, exp ) - 4 * a * c;

    double  x1 = ( -b + Math.Sqrt( delta ) ) / ( 2 * a );
    double  x2 = ( -b - Math.Sqrt( delta ) ) / ( 2 * a );

    System.Console.WriteLine(delta);
    System.Console.WriteLine(x1);
    System.Console.WriteLine(x2);

### ReadLine: Entrada de Dados: Console.ReadLine() lê da entrada padrão até a quebra de linha (teclar Enter)

    ° Retorna os dados lidos, na forma de String. O Comando irá aguardar até que seja digitado algo como retorno.

    string frase = Console.ReadLine();

    string x = Console.ReadLine();
    string y = Console.ReadLine();
    string z = Console.ReadLine();

    System.Console.WriteLine($"Você digitou...  frase:{frase},  x:{x},  y:{y},  z:{z}");


    ° Ao usar o comando Split, é possível retornar cada palavra de uma string conforme posição. Fazendo a separação por um caractere especifico.

    string[] v = Console.ReadLine().Split('*');

    string   a = v[0],  b = v[1],  c = v[2];

    System.Console.WriteLine($" {v}");

    System.Console.WriteLine($" a:{a}  - b:{b}  - c:{c}");

    - amareclo * azul * laranja
    - System.String[]
    - a:amareclo  - b:azul  - c:laranja

### Uso de Parse: O método leitor Read Line lê a entrada de dados no formato String

    ° Para isto usamos o método .Parse para devolver a entrada como um valor numérico ou qualquer outro

    int n1    = int.Parse(Console.ReadLine());
    char ch   = char.Parse(Console.ReadLine());
    double db = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    Console.WriteLine($"Você digitou: {n1} \n");
    Console.WriteLine($"Você digitou: {ch} \n");
    Console.WriteLine(db.ToString("F2", CultureInfo.InvariantCulture));

### O seguite exemplo irá quebrar a string de entrada em um vetor com cada dado formatado conforme a necessidade

    string[] vetor = Console.ReadLine().Split(' ');

    string nome    = vetor[0];
    char   sexo    = char.Parse(vetor[1]);
    int    idade   = int.Parse(vetor[2]);
    double salar   = double.Parse(vetor[3], CultureInfo.InvariantCulture);

    System.Console.WriteLine($"Nome: {nome} - Sexo:{sexo} - Idade:{idade} - Salario:" + salar.ToString("F2", CultureInfo.InvariantCulture));

### Operadores de Comparação

    int   a =     10;

    bool c1 = a < 10; False
    bool c2 = a < 20; True
    bool c3 = a > 10; False
    bool c4 = a >  5; True

    bool c5 = a <= 10; True
    bool c6 = a >= 10; True
    bool c7 = a == 10; True
    bool c8 = a != 10; False

    System.Console.WriteLine($" a:{a} - c5:{c5} - c6:{c6} - c7:{c7} - c8:{c8}");

### Operadores Lógicos

    Operador  Significa
    -------------------
      &&          E
      ||          OU
      !           NÂO
    -------------------


        Precedência
    -------------------
      !     &&     ||
    -------------------


      Tabela Verdade
    -------------------.
      A    B    A e B  |
      F    F    F      |
      F    V    F      |
      V    F    F      |
      V    V    V      |
    -------------------¬
      A    B    A ou B |
      F    F    F      |
      F    V    V      |
      V    F    V      |
      V    V    V      |
    -------------------´


    bool c1 =   2 > 3  ||  4 != 5; True
    bool c2 = !(2 > 3) &&  4 != 5; True

    System.Console.WriteLine($" c1:{c1} - c2:{c2}");

### Estrutura Condicional: If - Else

### Estrutura Condicional Simples

    bool ehSuperior = 10 > 5;

    System.Console.WriteLine("Open Pogram Cs ...");

    if (ehSuperior) {
        System.Console.WriteLine("Valor Superior !");
    }

### Estrutura Condicional Composta

    System.Console.WriteLine($" Entre com um número ... \n");

    int inNumber = int.Parse(Console.ReadLine());

    if (inNumber % 2 == 0) {
        System.Console.WriteLine($"Número {inNumber} é Par !");
    } else {
        System.Console.WriteLine($"Número {inNumber} é Impar !");
    }

### Estrutura Condicional Encadeada

    System.Console.WriteLine($" Hora Atual ... \n");

    int outH = int.Parse(Console.ReadLine());

    if (outH < 10 ) {
        System.Console.WriteLine($" Iniciando Server: {outH}:00 Hrs ...");
    }
    else if (outH < 11 ) {
        System.Console.WriteLine($" Server Fora do Ar: {outH}:00 Hrs !");
    }
    else if (outH < 18) {
        System.Console.WriteLine($" Server On Line: {outH}:00 Hrs !");
    }
    else {
        System.Console.WriteLine($" Server Encerrado: {outH}:00 Hrs !");
    }

### Também Funciona sem o uso de chaves

    System.Console.WriteLine($" Hora Atual ... \n");

    int outH = int.Parse(Console.ReadLine());

    if      ( outH < 10 )
        System.Console.WriteLine($" Iniciando Server: {outH}:00 Hrs ...");
    else if ( outH < 11 )
        System.Console.WriteLine($" Server Fora do Ar: {outH}:00 Hrs !");
    else if ( outH < 18 )
        System.Console.WriteLine($" Server On Line: {outH}:00 Hrs !");
    else
        System.Console.WriteLine($" Server Encerrado: {outH}:00 Hrs !");

### Outros exemplos

    System.Console.WriteLine("Qual a sua idade");
    int idade = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Esta acompanhado de um adulto ?");
    bool acompanhado = bool.Parse(Console.ReadLine());

    System.Console.WriteLine("É o aniversariante ?");
    bool aniversariante = bool.Parse(Console.ReadLine());

    if(idade >= 18)
    {
        System.Console.WriteLine("Pode entrar ! ");

    } else
    {
        if (idade < 18 && acompanhado)
        {
            System.Console.WriteLine("Esta acompanhado. Pode entrar ! ");
        }
        else
        {
            if (idade < 18 && aniversariante)
            {
                System.Console.WriteLine("É o aniversariante. Pode entrar ! ");
            }
            else
            {
                System.Console.WriteLine("É penetra ?");
                bool penetra = bool.Parse(Console.ReadLine());

                if ((idade < 18) && (aniversariante == false) && (acompanhado == false) && (penetra == true))
                {
                    System.Console.WriteLine("Não pode Entrar !!!");
                }
                else
                {
                    System.Console.WriteLine("É da Familia ! pode entrar. ");
                }
            }
        }
    }

### Laços de Repetição

### Usando While

    ° Calcular o valor de retorno nos 12 meses com um percentual de 0,50% sobre 1000 - De forma exponencial

    double i = 1000;
    int  mes =    1;

    while(mes <= 12)
    {
        i *= 1.005;
    System.Console.WriteLine($" No mês {mes} recebeu R$ {i.ToString("F2")}");

        mes += 1;
    }
        System.Console.WriteLine("Tecle enter para fechar ! ");
        Console.ReadLine();


    Estrutura:
    for( início ; condição ; incremento ) {
        comandos ...
    }

        início: Executa só na primeira vez.
      condição: V - executa e volta, F - pula fora.
    incremento: Executa toda vez depois de voltar.

### Usando For

    ° Calcular o valor de retorno nos 12 meses com um percentual de 0,50% sobre 1000 - De forma exponencial

    double i = 1000;

    for (int mes = 1; mes <= 12; mes++)
    {
        i *= 1.05;
        System.Console.WriteLine($"No mês {mes} você receberá R$ {i.ToString("F2")}");
    }

        System.Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();

### Encadeamento de For

    for (int anos = 1; anos <= 5; anos++)
    {
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento = investimento * fatorRendimento;
            System.Console.WriteLine($"Depois do {anos}° ano você terá: R$ {investimento.ToString("F2")} - {mes}° mês");
        }

        fatorRendimento = fatorRendimento + 0.001;
        System.Console.WriteLine($"Depois do {anos}° ano você terá um total de R$ {investimento.ToString("F2")}");
        System.Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

### Uso do Break no For

    for(int linhas = 0; linhas < 10; linhas++) {

        for(int colunas = 0; colunas < 10; colunas++) {

            if(colunas >= linhas) {

                break;
            }

            System.Console.Write("°°");
        }

        System.Console.WriteLine("°");

    }

    System.Console.WriteLine("Encerrado com sucesso ! ");

### Calculando fatorial com For

    int fatorial = 1;

    for (int indice = 1; indice <= 10; indice++) {

        fatorial = fatorial * indice;

        Console.WriteLine($"Fatorial de {indice} é {fatorial} ");

    }

### Somar com For

        static void Main(string[] args) {

            Console.Write("Quantidade ... ");
            int n = int.Parse(Console.ReadLine());

            int     soma = 0 ;
            for (int qtd = 1 ; qtd <= n ; qtd++) {

                Console.WriteLine    ($"Valor #{qtd}"    );
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }
            System.Console.WriteLine($"Soma {soma}");
        }

### Clsses em Csharp

    - Toda a Classe em Csharp é uma Subclasse da classe Object, que possuí os métodos:
        GetTYpe, retorna o tipo do objeto
        Equals, compara se um objeto é igual a outro
        GetHashCode, retorna um código hash do objeto
        ToString, converte o objeto para string

    namespace csharp {
        public class ContaCorrente {

            private double saldo = 0;
            private dynamic correntista = "";

            public double Saldo {
                get { return this.saldo;  }
                set { this.saldo = value; }
            }

            public dynamic Correntista {
                get { return this.correntista;  }
                set { this.correntista = value; }
            }

            public void Depositar ( double valor ) {
                this.saldo = this.saldo + valor;
            }

        }
    }

### Membros estáticos

    - Membros é igual a atributos e métodos
    - Membros estáticos também são chamados de membros de clase, em oposição a membros e instancias
    - São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados.
    - São chamados a partir do próprio nome da classe.
    - aplicação comum: classes Utilitárias, declaração de Constantes
    - Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não poderá ser instanciada.

    - Dentro de um método estático não se pode chamar membro de instância da mesma classe

    Ex.: Métodos na prória classe do Programa

    namespace csharp {

        public class Calcular {

            // atributo estático
            static double PI = 3.14;

            static void Main(string[] args) {

                // Entrada do usuario
                System.Console.WriteLine("Entre com o calor do raio: ");
                double v_raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura do valor digitado pelo usuário

                double circu = Circunf(v_raio);
                System.Console.WriteLine("Circunferência: " + circu.ToString("F2", CultureInfo.InvariantCulture));

                double volum = Volume(v_raio);
                System.Console.WriteLine("Volume: " + volum.ToString("F2", CultureInfo.InvariantCulture));

                System.Console.WriteLine("Valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
            }

            // não é possível, dentro da mesma classe, chamar membros que não seja estáticos, dentro um membro que seja estático.
            // static void Main, precisa receber um membro estático ...(argumentos, atributos, métodos)

            static double Circunf(double raio) {
                return 2 * PI * raio;
            }

            static double Volume(double raio) {
                return ( 4.0 / 3.0 ) * ( PI * Math.Pow(raio, 3.0) );
            }
        }
    }

    Ex.: Métodos por instancia, os valores não mudam para Calculadoras diferentes, são estáticos. O valor de Pi também é estático.

    namespace csharp {
        public class Calculadora {

            public double PI = 3.14;

            public double Circunf(double raio) {
                return 2.0 * PI * raio;
            }
            public double Volume(double raio) {
                return ( 4.0 / 3.0 ) * ( PI * Math.Pow(raio, 3.0) );
            }
            public double Pi {
                get {
                    return this.PI;
                }
                set {
                    this.PI = value;
                }
            }
        }
    }

    namespace csharp {
        public class Calcular {

            static void Main(string[] args) {

                // Instanciando os dois Objetos
                Calculadora calc1 = new Calculadora();
                Calculadora calc2 = new Calculadora();

                // Entrada do usuario
                System.Console.WriteLine("Entre com o calor do raio: ");
                double v_raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura do valor digitado pelo usuário

                // realizando o calculo do primeiro objeto ...

                double circu1 = calc1.Circunf(v_raio);
                System.Console.WriteLine("Circunferência: " + circu1.ToString("F2", CultureInfo.InvariantCulture));

                double volum1 = calc1.Volume(v_raio);
                System.Console.WriteLine("Volume: " + volum1.ToString("F2", CultureInfo.InvariantCulture));

                System.Console.WriteLine("Valor de PI: " + calc1.Pi.ToString("F2", CultureInfo.InvariantCulture));

                // realizando o calculo do segundo objeto ...

                double circu2 = calc2.Circunf(v_raio);
                System.Console.WriteLine("Circunferência: " + circu2.ToString("F2", CultureInfo.InvariantCulture));

                double volum2 = calc2.Volume(v_raio);
                System.Console.WriteLine("Volume: " + volum2.ToString("F2", CultureInfo.InvariantCulture));

                System.Console.WriteLine("Valor de PI: " + calc2.Pi.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }

    Ex.: Chamada a atributos e métodos static de uma classe, não tem a necessidade de instanciar um objeto dessa Classe: new Calculadora()
         pois atributos e métodos static são independentes de Objeto.

    namespace csharp {
        class Calculadora {
            public static double PI = 3.14;
            public static double Circunf(double raio) {
                return 2.0 * PI * raio;
            }
            public static double Volume(double raio) {
                return ( 4.0 / 3.0 ) * ( PI * Math.Pow(raio, 3) );
            }
        }
        class Conversor {
            public static double Iof = 6.0;
            public static double DolarToBRL(double cotacao, double convert) {
            double total = cotacao * convert;
            return total + ( total * Iof ) / 100.0;
            }
        }
    }

    namespace csharp {
        class Program  {

            static void Main(string[] args) {

                System.Console.Write("Digite o valor do Raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double circ = Calculadora.Circunf(raio);
                double vol  = Calculadora.Volume(raio);

                System.Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));


                Console.WriteLine("Informe a cotação do dolar para hoje: ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Valor a ser convertido: ");
                double convert = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double conversor = Conversor.DolarToBRL(cotacao, convert);

                Console.WriteLine("Valor BRL " + conversor.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }

### Construtores

    - Construtores é uma operação especial da classe, que executa no momento da instanciação do ojeto: Class objeto = new Class(ParamsDefault);
    - Uso comuns:
        Iniciar valores dos atributos
        Permitir ou obrigar que os objetos recebam dados / dependências no momento de sua instanciação (injeção de dependências)
    - Se um Construtor customizado não for especificado, a classe disponibiliza o Construtor padrão: Class objeto = new Class()
    - Sobrecarga de Construtores: Possibilidade de especificar mais de um Construtor na mesma classe

    Ex.: Construtor de exemplo

    namespace csharp {
        class ContaCorrente {
            private int agencia;
            private string? conta, correntista;
            private double saldo, vlr_saq, vlr_dep;

            public ContaCorrente(string correntista, int agencia, string conta, double vlr_dep, double vlr_saq) {
                this.correntista = correntista;
                this.agencia = agencia;
                this.vlr_dep = vlr_dep;
                this.vlr_saq = vlr_saq;
                this.conta = conta;
            }
        }
    }

### Sobrecarga

    - É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes listas de parâmetros
    - Obs.: é possível também incluir um Construtor Padrão (sem parâmetros)

    Ex.: Por padrão quando instanciado novo objeto, ele nasce com metodos e atributos padrões da classe, porém quando criamos um contrutor nosso, é necesário representa-lo dentro da classe se quisermos usar esse construtor padrão: public ContaCorrente() { }

    namespace csharp {

        class ContaCorrente {

            private int agencia;
            private string? conta, correntista;

            public ContaCorrente() { }

            public ContaCorrente(string correntista, int agencia, string conta) {
                this.correntista = correntista;
                this.agencia = agencia;
                this.conta = conta;
            }
        }
    }

    - Obs.: Podemos usar este método de Sobrecarga diretamente na instanciação do Objeto, mesmo se a classe não tiver Contrutores implementados
            Abaixo cria-se uma classe ContaCorrente com saldo, depósito e saque, em seguida se instancia o objeto cc passando valores para estes atributos

    namespace csharp {
        class ContaCorrente {

            public double saldo, vlr_saq, vlr_dep;
        }
    }

    namespace csharp {
        class Program  {

            static void Main(string[] args) {

                string[] vetor = Console.ReadLine().Split(' ');

                double saldo   = double.Parse( vetor[0], CultureInfo.InvariantCulture );
                double vlr_dep = double.Parse( vetor[1], CultureInfo.InvariantCulture );
                double vlr_saq = double.Parse( vetor[2], CultureInfo.InvariantCulture );

                ContaCorrente cc = new ContaCorrente {
                    vlr_dep = vlr_dep,
                    vlr_saq = vlr_saq,
                    saldo   = saldo,
                };
            }
        }
    }

### Uso da palavra this

    - This é uma referencia para o próprio objeto ( Conta cc = new Conta(saldo: 1000) -> this.saldo refere-se ao saldo deste objeto cc )
    - Usos Comuns:
        Diferenciar atributos de variáveis locais (Java)
        Referenciar outro construtor em um construtor
        Passar o próprio objeto como argumento na chamada de um método ou construtor

    Ex.: Raproveitando outro Construtor usando o This

    namespace csharp {
        class ContaCorrente {

            private int agencia;
            private string? conta, correntista;
            private double saldo, vlr_saq, vlr_dep;

            public ContaCorrente() {
                this.agencia = 9999;
                this.conta = "9999-X";
                this.correntista = "XYZ";
            }

            public ContaCorrente( double saldo ) : this () {
                this.saldo = saldo;
            }
        }
    }

    namespace csharp {
        class Program  {
            static void Main(string[] args) {

                ContaCorrente cc = new ContaCorrente(saldo:saldo);
                Console.WriteLine( cc );
            }
        }
    }

    >> 1000
    >> Olá XYZ, Agência 9999, Conta 9999-X, Saldo R$ 1000.00, Vlr de Saque 0, Vlr de Depósito 0

### Encapsulamento

    - É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras e que o mantenha em um estado consistente.
    - Regra de Ouro: o objeto deve sempre estar em um estado consistente e a própria classe deve garantir isso

    > Implementação Manual:
      Todo atributo é definido como Private
      Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio
    Obs.: não é usual na plataforma C#

### Properties

    - São definições de métodos encapsulados encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos.
    > https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
    Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. As propriedades podem ser usadas como se fossem membros de dados públicos, mas são métodos realmente especiais chamados acessadores. Esse recurso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos métodos.
    Ex.: Métodos get e set encapsulados
    namespace csharp {
        class ContaCorrente {
            private string? _conta, _correntista, _agencia;
            private double _saldo, _vlr_saq, _vlr_dep;
        }
    }
    public string? Conta {
        get {
            return _conta;
        }
        set {
            if (value != null && value.Length >= 4) {
                _conta = value;
            }
        }
    }

### Auto Properties

    - Propriedades autoimplementadas: É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operações Get e Set.
    > https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
    Ex.: public int MyProperty { get; set; }

    usando Properties:

    namespace csharp {
        class ContaCorrente {
            public string? Correntista { get; private set; }
            public string? Agencia { get; private set; }
            public string? Conta { get; private set; }
            private double _saldo, _vlr_saq, _vlr_dep;
            public double Saldo {
                get { return _saldo;
                }
                set { if (value >= 0 ) {
                        _saldo = value;
                    }
                }
            }
            public double Vlr_dep {
                get { return _vlr_dep;
                }
                set { if (value >= 0 ) {
                        _vlr_dep = value;
                    }
                }
            }
            public double Vlr_saq {
                get { return _vlr_saq;
                }
                set { if (value >= 0 ) {
                        _vlr_saq = value;
                    }
                }
            }
        }
    }

### Ordem sugerida para implementação de membros de classe

    > Atributos Privados
    > Propriedades autoimplementadas
    > Construtores
    > Propriedades customizadas
    > Outros métodos da Classe

### Modificadores de acesso

    - Modificadores de acesso são palavras-chave usadas para especificar a acessibilidade declarada de um membro ou tipo. Esta seção apresenta os quatro modificadores de acesso:

    ° Public
    ° Protected
    ° Internal
    ° Private

    - Os seis níveis de acessibilidade a seguir podem ser especificados usando os modificadores de acesso:

    ° Public: O acesso não é restrito.
    ° Protected: O acesso é limitado à classe ou tipos de conteúdo derivados da classe de conteúdo.
    ° Internal: O acesso é limitado ao assembly atual.
    ° Private internal: o acesso é limitado ao assembly atual ou aos tipos derivados da classe que o contém.
    ° private: O acesso é limitado ao tipo que contém.
    ° Private protected: o acesso é limitado à classe ou tipos contidos derivados da classe contida no assembly atual.

    Esta seção também apresenta o seguinte:
    Níveis de acessibilidade : usando os quatro modificadores de acesso para declarar seis níveis de acessibilidade.
    Domínio de acessibilidade : Especifica onde, nas seções do programa, um membro pode ser referenciado.
    Restrições ao Uso de Níveis de Acessibilidade : Um resumo das restrições ao uso de níveis de acessibilidade declarados.

    > https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

    - Classes

    • Acesso por qualquer classe
        public class Product

    • Acesso somente dentro do assembly
        internal class Product
        class Product: quando não informado nível de acesso, por padrão a Classe será Internal

    • Acesso somente pela classe-mãe
        private class Product
        Nota: classe aninhada (classe dentro de outra classe) por padrão, é private, só poderá ser acessada pela classe mãe dela. Dentro da qual ela foi declarada

### Tipos referência vs. tipos valor

      Classes são tipos referência:
      Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim “tentáculos” (ponteiros) para caixas
      Os objetos ficam na HEAP, eles recebem um endereço indicando sua localização na memória.
      As variáveis estão na STACK e quando recebe um objeto, passa a apontar para o endereço deste objeto ( Ex.: p1 -> 0X100358 )

    • Product p1, p2;
    • p1 = new Product("TV", 900.00, 0.00);

      Stack              Heap
      ---p1---     ->    0X100358: TV-900.00-0
      ---p2---


      Outro uso comum, é fazer uma variável receber o valor de outra variavel
      ex.: p2 = p1, neste caso a variável p2 irá passar a apontar para o endereço de memória qual já está sendo apontado pelo p1.

    • Product p1, p2;
    • p1 = new Product("TV", 900.00, 0.00);
    • p2 = p1;

      Stack              Heap
      -p1- -p2-    ->    0X100358: TV-900.00-0


      Valor "null":
      Outro ponto importante, são os Valores "null": tipos referência aceitam o valor "null", que indica que a variável aponta pra ninguém.

    • Product p1, p2;
    • p1 = new Product("TV", 900.00, 0.00);
    • p2 = null;

      Stack              Heap
      ---p1---     ->    0X100358: TV-900.00-0
      ---p2---     ->    ---------------------


      Structs são tipos valor:
      A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e não ponteiros.
      neste exemplo abaixo, a variável y irá passar a ser uma cópia de x

    • double x, y;
    • x = 10;
    • y = x;

      Stack              Heap
      -p1-  = 10         --------
      -p2-  = 10         --------

      Structs e inicialização:
      É possível criar seus próprios structs

    • Exemplo

        namespace Course
        {
            struct Point
            {
                public double X, Y;

                public override string ToString()
                {
                    return "(" + X + "," + Y + ")";
                }
            }
        }

    • Exemplo - erro: variável não atribuída
      (variável local) Point p
      Uso de variável local não atribuída "p" [csharp] csharp(CS0165)

      Point p;
      Console.WriteLine(p);

    • Exemplo - uso correto, inicializando variável

      Point p;
      p.X = 10;
      p.Y = 20;

      p = new Point();
      Console.WriteLine(p);

      Funcionaria usanto também somente o exemplo abaixo, sem fazer uso do New Point, por ser um tipo valor, esta declaração, cria as CAIXAS na stack da memória,
      podendo fazer uso normalmente dessas CAIXAS na memória.
      Point p2;
      p2.Y = 20;
      p2.X = 10;

      Valores padrão:

    • Quando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos
    • números: 0
    • bool: False
    • char: caractere código 0
    • objeto: null
    • Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", e o próprio compilador não permite que ela seja acessada.


      TIPOS REFERÊNCIA VS. TIPOS VALOR
      CLASSE                                              STRUCT
      -----------------------------------------------------------------------------------------------------------------
      Vantagem: usufrui de todos recursos OO              Vantagem: é mais simples e mais performático
      -----------------------------------------------------------------------------------------------------------------
      Variáveis são ponteiros                             Variáveis são caixas
      -----------------------------------------------------------------------------------------------------------------
      Objetos precisam ser instanciadas usando new, ou    Não é preciso instanciar usando new, mas é possível
      apontar para um objeto já existente.
      -----------------------------------------------------------------------------------------------------------------
      Aceita valor null                                   Não aceita valor null
      -----------------------------------------------------------------------------------------------------------------
      Suporte a herança                                   Não tem suporte a herança (mas pode implementar interfaces)
      -----------------------------------------------------------------------------------------------------------------
      Y = X;                                              Y = X;
      "Y passa a apontar para onde X aponta"              "Y recebe uma cópia de X"
      -----------------------------------------------------------------------------------------------------------------
      Objetos instanciados no heap                        Objetos instanciados no stack
      -----------------------------------------------------------------------------------------------------------------
      Objetos não utilizados são desalocados em um        "Objetos" são desalocados imediatamente quando
      momento próximo pelo garbage collector              seu escopo de execução é finalizado
      -----------------------------------------------------------------------------------------------------------------

### Desalocação de memória - garbage collector e escopo local

      Garbage collector

    • É um processo que automatiza o gerenciamento de memória de um programa em execução
    • O garbage collector monitora os objetos alocados dinamicamente pelo programa (no heap), desalocando aqueles que não estão mais sendo utilizados.

      Desalocação por garbage collector:

    • Product p1, p2;
    • p1 = new Product("TV", 900.00, 0);
    • p2 = new Product("Mouse", 30.00, 0);

      Stack              Heap
      ---p1---     ->    0X100358:   TV-900.00-0
      ---p2---     ->    0X111900: Mouse-30.00-0

      Confome abaixo: Ao utilizar a seguinte atribuição, p1 = p2, fazemos o p1 -> p2 (ler: a variável p1 irá apontar para onde a variável p2 aponta)
      Agora o objeto que era apontado pelo p1, perdeu todas as referencias para ele, não há ninguém mais apontando para ele
      Com isso o Garbage Collector irá identificar essa desreferencia, e então irá desalocar da memória este objeto instanciado

      Stack              Heap
      -p1- -p2-     ->   0X111900: Mouse-30.00-0

      Será
      desalocado    ->   0X100358:   TV-900.00-0
      pelo garbage


      Desalocação por escopo: Neste exemplo abaixo durante a execução, o method1 entra na stack, todos as variáveis e diretivas entram no seu escopo
    • Ao acessar method1 é criado um escopo, e dentro desse escopo temos a variável x = 10.
    • Quando chegamos na diretiva if, é criado um novo escopo para o bloco if, que também faz parte do escopo de method1, dentro de if temos a variável y = 20
    • ao final da execução do bloco if, o escopo da diretiva if será desalocadas e teremos apenas o escopo do method1 com x = 10, que também após a execução será desalocado

      Obs.: Isto é desalocação por escopo, e não Garbage Collector !

      void method1() {
         int x = 10;
         if (x > 0) {
               int y = 20;
         }
         Console.WriteLine(x);
      }

      Stack                            Heap
      -escopo    >   method1
         X           = 10
         -escopo >   if
            Y        = 20

    • Pós execução da diretiva if:

      Stack                            Heap
      -escopo    >   method1
         X           = 10


      Outro exemplo

        void method1() {
            Product p = method2();
            Console.WriteLine(p.Name);
        }

        Product method2() {
            Product prod = new Product("TV", 900.0, 0);
            return prod;
        }

    • Na Stack, dentro do method1 a variável P irá chamar o method2, que irá declarar a variável prod atribuindo na Heap o objeto Product:TV, 900, 0
    • Todos as variáveis da Stack do method2 irão ser desalocadas, após return
    • Então o programa retorna a referencia desse objeto Product criado na Heap, para a variável p dentro da Stack

      Resumo
    • Objetos alocados dinamicamente, quando não possuem mais referência para eles, serão desalocados pelo garbage collector
    • Variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução


      Nullable
    • É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null

      Uso comum:
    • Campos de banco de dados que podem valer nulo data de nascimento, algum valor numérico, etc
    • É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null
    • Dados e parâmetros opcionais.

    •          double  ValorSaq { get; private set; }
    • Nullable<double> ValorSaq { get; private set; }

    Porém existe uma forma mais simples de declarar isto:
    • public double? ValorSaq { get; private set; }

      double? X = -10;
      double? Y = 22.88;
      double? Z = null;

      if (X.HasValue == true && X.Value > 0)
      {
          System.Console.WriteLine($"O valor de X é de R$ {X.Value}");
      }
      else if (X.HasValue == false)
      {
          System.Console.WriteLine($"O valor de x esta vazio{X.Value}");
      }
      else if (Y.HasValue == true && Y.Value > 0)
      {
          System.Console.WriteLine($"O valor de Y é de R$ {Y.Value}");
      }
      else if (Z.HasValue == false)
      {
          System.Console.WriteLine($"O valor de Z esta vazio{Z.Value}");
      }
      {
          System.Console.WriteLine("Error !");
      }


      Operador de coalescência nula
    • ?? e?? = operadores (referência C#)
    • O operador de coalizão nula devolve o valor de sua operação à esquerda se não for; caso contrário, avalia o operando à direita e devolve seu resultado.
    • O operador não avalia seu operando à direita se o operand esquerdo avalia para não-nulo.??null??

    Disponível em C# 8.0 e posteriormente, o operador de atribuição de coalescing nulos atribui o valor de seu operando à direita ao seu operando à esquerda apenas se o operando à esquerda avaliar. O operador não avalia seu operando à direita se o operand esquerdo avalia para não-nulo.??=null??=

    O operador são os dois sinais de interrogação, ??
    supondo que teremos uma variável X double Nullable (double? X) que irá valer null (ou qualquer outro valor aceitável)
    e teremos também o Y que não é Nullable
    supondo que iremos atribuir o valor de X para Y teremos que fazer uma verificação, para caso seja nullable, ser aplicado o valor 0.00
    caso não seja verificado irá ocorrer um erro de conversão onde não é possível converter implicitamente double em double?

    • Erro: Não é possível converter implicitamente tipo "double?" em "double".
      Existe uma conversão explícita (há uma conversão ausente?) [csharp]csharp(CS0266)
      O tipo de valor de nulidade pode ser nulo. [csharp]csharp(CS8629)

      double? X = null;
      double  Y = X;

    • Aplicação correta
      double? X = null;
      double  Y = X ?? 0.00;

    • Outro exemplo
      double? X = null;
      double? Y = 10.00;

      double a = X ?? 5.00;
      double b = Y ?? 5.00;


      Vetores
    • Em programação, "vetor" é o nome dado a arranjos unidimensionais
    • Arranjo é uma estrutura de dados:
        Homogênea (dados do mesmo tipo)
        Ordenada (elementos acessados por meio de posições)
        Alocada de uma vez só, em um bloco contíguo de memória

      Ex.: double vetor = ( posição 0: 1.10,
                            posição 1: 1.56,
                            posição 2: 1.98
                          )

    • Vantagens:
        Acesso imediato aos elementos pela sua posição

    • Desvantagens:
        Tamanho fixo
        Dificuldade para se realizar inserções e deleções

    Ex.: Uso de vetor armazenando elementos do tipo Structs
    • Declaramos o N que irá alimentar a quantidade de posições para o vetor de forma dinâmica a partir da entrada do terminal

    • int N = int.Parse(Console.ReadLine());
    • double[] Vetor = new double[N];

      Stack              Heap
      -N        = 3      ----------------
      -Vetor     ->      0X100358 0: 1.50
      -Vetor     ->      0X100358 1: 2.00
      -Vetor     ->      0X100358 2: 2.50

    • Para alimentar o vetor teremos que utilizar For, percorrendo posição por posição e inserindo o valor para essa posição

    using System;
    using System.Globalization;

    namespace csharp
    {
        class Program
        {
            static void Main(string[] args)
            {
                System.Console.WriteLine("Digite a quantidade de elementos para o vetor: ");

                int posicao = int.Parse(Console.ReadLine());
                double[] vetor = new double[posicao];

                System.Console.WriteLine("\n");

                for (int i = 0; i < posicao; i++)
                {
                    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    while (posicao < 3)
                    {
                        System.Console.WriteLine($"VETOR {i} de {posicao}");
                    }
                }

                double sum = 0.00;
                for (int i = 0; i < posicao; i++)
                {
                    sum = sum + vetor[i];
                    System.Console.WriteLine($"SOMA {i} de {posicao} = {sum}");
                }

                double media = sum / posicao;
                System.Console.WriteLine($"AVERAGE HEIGT = {media}");
            }
        }
    }

    Ex.: Uso de vetor armazenando elementos do tipo Class
    • Declaramos o N que irá alimentar a quantidade de posições para o vetor de forma dinâmica a partir da entrada do terminal
      Este vetor será diferente pois irá criar um objeto em cada uma dessas posições ao ser acessado por meio do iterador For

    • int n = int.Parse(Console.ReadLine());
    • ContaCorrente[] vetor = new ContaCorrente[n];

      Stack              Heap
      -N        = 3      ------------------------------------------------------------------
      -Vetor     ->      0X100358 0: -> ContaCorrente: [Agencia:X, Conta:XX, ValorDep: 100]
      -Vetor     ->      0X100358 1: -> ContaCorrente: [Agencia:Y, Conta:YY, ValorDep: 100]
      -Vetor     ->      0X100358 2: -> ContaCorrente: [Agencia:Z, Conta:ZZ, ValorDep: 100]

    • Para alimentar o vetor teremos que utilizar For, percorrendo posição por posição e instanciando um novo objeto no vetor criado no Heap
      para adicionar valores aos elementos teremos que percorrer o vetor em todas as suas posição, acessando o elemento a partir do ponto

    namespace csharp {
        class Program {
            static void Main(string[] args) {

                // Variáveis auxiliares globais da Stack
                double vlrSaldo = 0.00;
                int numElements = 2;

                // Variável do tipo vetor de conta corrente, na Stack com a quantidade de Posições conforme variável numElements
                // as Posições serão criadas na memória Heap
                ContaCorrente[] vetor = new ContaCorrente[numElements];

                for (int i = 0; i < numElements; i++) {

                    // definindo atributos para o Objeto que será criado na Posição[n]
                    System.Console.Write($"Agencia Nro ({i}): ");
                    string? agencia = Console.ReadLine();
                    System.Console.Write($"Conta Nro ({i}): ");
                    string? conta = Console.ReadLine();
                    System.Console.Write($"Valor de depósito inicial ({i}): ");
                    double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    // instanciando o novo Objeto a partir da posição[n] passando os atributos definidos
                    vetor[i] = new ContaCorrente {
                        Agencia = agencia,
                        Conta = conta,
                        ValorDep = valorDep
                    };
                }

                // Acessando as Posições do vetor, aplicando o método de depositar em cada um dos Objetos da respectiva posição
                for (int i = 0; i < numElements; i++) {
                    vetor[i].Depositar(100);
                    System.Console.WriteLine(vetor[i]);
                }

                // Somar os saldos disponíveis nas contas, acessando as Posições do vetor invocando o atributo Saldo do Objeto
                for (int i = 0; i < numElements; i++) {
                    vlrSaldo += vetor[i].Saldo();
                }
                System.Console.WriteLine($"\nValor total disponível nas contas R$ {vlrSaldo}\n");

            }
        }
    }

    namespace csharp {
        class Program {
            static void Main(string[] args) {

                int numElementos = 2;
                double    indice = 0;
                double totalTaxa = 0.00;

                ContaCorrente[] vetor = new ContaCorrente[numElementos];

                for (int i = 0; i < numElementos; i++) {
                    indice += 1;

                    Console.Write($"\nCorrentista ({indice}): ");
                    string? correntista = Console.ReadLine();

                    Console.Write($"\nAgencia ({indice}): ");
                    string?     agencia = Console.ReadLine();

                    Console.Write($"\nConta ({indice}): ");
                    string?       conta = Console.ReadLine();

                    Console.Write($"\nTaxa ({indice}): ");
                    double         taxa = double.Parse(Console.ReadLine());

                    Console.Write($"\nValorDep({indice}): ");
                    double         dep = double.Parse(Console.ReadLine());

                    vetor[i] = new ContaCorrente {
                        Correntista = correntista,
                        Agencia = agencia,
                        Conta = conta,
                        Taxa = taxa,
                        ValorDep = dep,
                    };
                    Console.WriteLine($"\nVETOR ({indice}) - {vetor[i]}");
                }

                for (int i = 0; i < numElementos; i++) {
                    indice += 1;
                    totalTaxa = totalTaxa + vetor[i].Taxa;
                    Console.WriteLine($"\nTAXA DO VETOR ({indice}) {vetor[i].Taxa}");
                }

                double mediaTaxa = totalTaxa / numElementos;
                Console.WriteLine($"\nAverage rate % {mediaTaxa} \n");
            }
        }
    }



    Modificador de parâmetros: params
    • Suponha que se queira uma calculadora para calcular a soma de uma quantidade variável de valores.
    • Solução ruim usando sobrecarga:

    namespace Course {
        class Calculator {
            public static int Sum(int n1, int n2) {
                return n1 + n2;
            }
            public static int Sum(int n1, int n2, int n3) {
                return n1 + n2 + n3;
            }
            public static int Sum(int n1, int n2, int n3, int n4) {
                return n1 + n2 + n3 + n4;
            }
        }
    }

    • Solução com vetor:

    namespace Course {
        class Calculator {
            public static int Sum(int[] numbers) {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++) {
                    sum += numbers[i];
                }
                return sum;
            }
        }
    }






</p>