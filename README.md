![CR-2](https://github.com/user-attachments/assets/77a4d99a-9524-4322-9482-3f6833d9b2a0)


## 🥁 CarnaCode 2026 - Desafio 02 - Builder

Oi, eu sou o Augusto Lima e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Builder** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML) com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros).
O código inicial usa construtores enormes ou muitos setters, tornando difícil criar relatórios

## Solução

O padrão **Builder** foi aplicado para resolver os seguintes problemas:
- ✅ **Como criar relatórios complexos sem construtores gigantes?** - Usando interface fluente com métodos encadeados.
- ✅ **Como garantir que configurações obrigatórias sejam definidas?** - Validação no método `Validar()` do produto e criação do director.
- ✅ **Como reutilizar configurações comuns entre relatórios?** - Usando o Director para pré-configurar tipos de relatórios.
- ✅ **Como tornar o processo de criação mais legível e fluente?** - API fluente com retorno `ISalesReportBuilder`.

### Estrutura do projeto

📂 src/BuilderChallenge/<br>
├── 📂 Builder/<br>
│<br>
└── ISalesReportBuilder.cs # Interface do Builder<br>
├── 📂 ConcreteBuilder/<br>
│<br>
└── SalesReportBuilder.cs # Implementação concreta do Builder<br>
├── 📂 Director/<br>
│<br>
└── SalesReportDirector.cs # Diretor que encapsula construções comuns<br>
├── 📂 Product/<br>
│<br>
└── SalesReport.cs # Produto complexo (Relatório)<br>

📂 BuilderChallenge.Runner/<br>
└── Program.cs # Exemplos de uso do padrão

### Componentes

#### 1. **Product (SalesReport)**
Representa o objeto complexo sendo construído. Contém:
- Propriedades configuráveis (título, formato, datas, colunas, etc.)
- Método `Validar()` que garante que todas as configurações obrigatórias foram definidas
- Método `Gerar()` que valida e exibe o relatório

#### 2. **Builder (ISalesReportBuilder)**
Interface que define os métodos para configurar o produto de forma fluente.

#### 3. **ConcreteBuilder (SalesReportBuilder)**
Implementação concreta que:
- Constrói o objeto `SalesReport` passo a passo
- Retorna `ISalesReportBuilder` para permitir encadeamento
- Método `Gerar()` retorna o produto final

#### 4. **Director (SalesReportDirector)**
Encapsula construções comuns:
- `BuildPdfReport()` - Pré-configura relatório PDF
- `BuildExcelReport()` - Pré-configura relatório Excel
- `BuildHtmlReport()` - Pré-configura relatório HTML

### Validações Implementadas

O método `Validar()` garante que:
- Título, formato, datas inicial e final sejam obrigatórios
- Data final não seja anterior à data inicial
- Pelo menos uma coluna seja definida
- Texto de cabeçalho seja obrigatório quando `IncludeHeader` estiver ativo
- Texto de rodapé seja obrigatório quando `IncludeFooter` estiver ativo
- Tipo de gráfico seja obrigatório quando `IncludeCharts` estiver ativo

### Tecnologias

- **.NET 8**
- **C# 12**
- **Design Pattern: Builder**

### Como Executar

1. Clone o repositório
2. Navegue até a pasta do projeto Runner:
```bash
cd BuilderChallenge.Runner
```
3. Execute o projeto:
```bash
dotnet run
```

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).
